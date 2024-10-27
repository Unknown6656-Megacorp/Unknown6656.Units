using System.Net;
using System.Text.RegularExpressions;

using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;

using Unknown6656.Generics;



string url = "https://en.wikipedia.org/wiki/Isotopes_of_fluorine";
HtmlDocument html = new();

using (HttpClient client = new())
    html.LoadHtml(await client.GetStringAsync(url));

string isotopes = "";
Regex re_sigma = new(@"\s*\(\s*\d+(\s*\.\s*\d+)?\s*\)\s*", RegexOptions.Compiled);
Regex re_ev = new(@"\s*\[\s*\d+(\s*\.\s*\d+)?\s*[kM]?eV\s*\]\s*", RegexOptions.Compiled | RegexOptions.IgnoreCase);

foreach (HtmlNode table in html.DocumentNode.QuerySelectorAll("table.wikitable.sortable").Select(ProcessTable))
{
    const int col_N = 2;
    const int col_halflife = 4;
    const int col_mode = 5;
    const int col_spin = 7;
    const int col_abundance = 8;

    foreach (IGrouping<string, IList<HtmlNode>>? g in from row in table.QuerySelectorAll("tr")
                                                      let cells = row.QuerySelectorAll("td")
                                                      where cells.Count() > col_N
                                                      let _n = cells[col_N].InnerText.Trim()
                                                      where _n.Length > 0 && _n.All(char.IsDigit)
                                                      group cells by _n into g
                                                      select g)
    {
        int N = int.Parse(g.Key);
        IList<HtmlNode> first = g.First();
        string halflife = first[col_halflife].InnerText.Trim().ToLower();
        string spin = first[col_spin].InnerText.Trim();
        string abundance = first[col_abundance].InnerText.Trim();

        if (spin is ['(', .., ')'])
            spin = spin[1..^1];

        spin = spin.Replace('-', '-')
                   .Replace("-", "")
                   .Replace("+", "")
                   .Replace("1/2", "0.5")
                   .Replace("3/2", "1.5")
                   .Replace("5/2", "2.5");

        if (abundance.Length > 0)
            abundance = $"\n    Abundance = {abundance},";

        if (halflife.EndsWith("ys"))
            halflife = $"{halflife[..^2]}e-24.Second()";
        else if (halflife.EndsWith("zs"))
            halflife = $"{halflife[..^2]}e-21.Second()";
        else if (halflife.EndsWith("as"))
            halflife = $"{halflife[..^2]}e-18.Second()";
        else if (halflife.EndsWith("fs"))
            halflife = $"{halflife[..^2]}e-15.Second()";
        else if (halflife.EndsWith("ps"))
            halflife = $"{halflife[..^2]}e-12.Second()";
        else if (halflife.EndsWith("ns"))
            halflife = $"{halflife[..^2]}e-9.Second()";
        else if (halflife.EndsWith("μs"))
            halflife = $"{halflife[..^2]}e-6.Second()";
        else if (halflife.EndsWith("ms"))
            halflife = $"{halflife[..^2]}e-3.Second()";
        else if (halflife.EndsWith('s'))
            halflife = $"{halflife[..^1]}.Second()";
        else if (halflife.EndsWith("min"))
            halflife += $"{halflife[..^3]}.Minute()";

        List<string> decays = [];

        foreach (IList<HtmlNode> cells in g)
        {
            string mode = '.' + cells[col_mode].InnerText.Trim();

            mode = mode.Replace(".β+α", "PositronAlphaEmission")
                       .Replace(".β+p", "PositronProtonEmission")
                       .Replace(".β+", "PositronEmission")
                       .Replace(".ε", "ElectronCapture")
                       .Replace(".β−α", "BetaAlpha")
                       .Replace(".β−n", "BetaNeutronEmission")
                       .Replace(".β−2n", "BetaDoubleNeutronEmission")
                       .Replace(".β−3n", "BetaTripleNeutronEmission")
                       .Replace(".β−4n", "BetaQuadrupleNeutronEmission")
                       .Replace(".β−", "Beta")
                       .Replace(".2p", "DoubleProtonEmission")
                       .Replace(".p", "ProtonEmission")
                       .Replace(".2n", "DoubleNeutronEmission")
                       .Replace(".n", "NeutronEmission")
                       ;

            decays.Add($"\n                new(DecayMode.{mode}, {halflife})");
        }

        if (halflife.Contains("stable", StringComparison.OrdinalIgnoreCase))
            decays = [];

        isotopes += $$"""
                new()
                {
                    NeutronCount = {{N}},
                    Spin = {{spin}},{{abundance}}
                    Decays = [{{string.Join(",", decays)}}],
                },
        """ + '\n';
    }
}

isotopes = re_sigma.Replace(isotopes, "")
                   .Replace("&#160;", "")
                   .Replace("&#91;", "")
                   .Replace("&#93;", "");
isotopes = re_ev.Replace(isotopes, "");

Console.WriteLine(isotopes);





static HtmlNode ProcessTable(HtmlNode tableNode)
{
    HtmlNode ret = tableNode.Clone();
    HtmlNodeCollection rows = ret.SelectNodes(".//tr");

    int num_rows = rows.Count;
    int num_cols = rows.Max(row => row.SelectNodes(".//td|.//th").Count);

    // Build ColSpans
    for (int idx_row = 0; idx_row < rows.Count; idx_row++)
    {
        HtmlNode row = rows[idx_row];
        HtmlNodeCollection cells = row.SelectNodes(".//td|.//th");

        for (int idx_col = 0; idx_col < num_cols; idx_col++)
            if (idx_col < cells.Count)
            {
                HtmlNode cell = cells[idx_col];
                int colspan = cell.GetAttributeValue("colspan", 0);

                if (colspan > 0)
                {
                    cell.Attributes["colspan"]?.Remove();

                    for (int i = 1; i < colspan; i++)
                    {
                        //if (idx_col + i >= num_cols)
                        //    continue;

                        HtmlNode newCell = HtmlNode.CreateNode(cell.OuterHtml);

                        row.InsertAfter(newCell, cell);
                    }
                }
            }
            else
                row.AppendChild(HtmlNode.CreateNode("<td></td>"));
    }

    num_rows = rows.Count;
    num_cols = rows.Max(row => row.SelectNodes(".//td|.//th").Count);

    // Build RowSpans
    for (int idx_col = 0; idx_col < num_cols; idx_col++)
        for (int idx_row = 0; idx_row < num_rows; idx_row++)
        {
            HtmlNodeCollection row = rows[idx_row].SelectNodes(".//td|.//th");

            if (idx_col >= row.Count)
                continue;

            HtmlNode cell = row[idx_col];

            int rowspan = cell.GetAttributeValue("rowspan", 0);

            if (rowspan > 0)
            {
                cell.Attributes["rowspan"]?.Remove();

                for (int i = 1; i < rowspan; i++)
                {
                    if (idx_row + i >= rows.Count)
                        continue;

                    HtmlNode subRow = rows[idx_row + i];
                    HtmlNodeCollection subRowCells = subRow.SelectNodes(".//td|.//th");
                    HtmlNode newCell = HtmlNode.CreateNode(cell.OuterHtml);
                    int targetCellIndex = Math.Min(subRowCells.Count - 1, idx_col);
                    HtmlNode targetCell = subRowCells[targetCellIndex];

                    if (idx_col > subRowCells.Count - 1)
                        subRow.InsertAfter(newCell, targetCell);
                    else
                        subRow.InsertBefore(newCell, targetCell);
                }
            }
        }

    return ret;
}


#if false

Dictionary<string, Dictionary<double, double>> dic = [];

foreach (string file in Directory.GetFiles("D:\\DEV\\Unknown6656.Units\\Unknown6656.Physics\\Chemistry", "*.csv"))
{
    string[] lines = File.ReadAllText(file).Replace("\r\n", "\n").Trim().Split('\n');
    string[] header = lines[0].Split(',');

    int col_elem = header.IndexOf("element");
    int col_intens = header.IndexOf("intens");
    var col_wl = header.WithIndex().SelectWhere(t => t.Item.Contains("_wl") && t.Item.Contains("nm"), t => t.Index);
    bool missing_elem = col_elem < 0;

    foreach (string line in lines)
        if (!line.Contains("intens") && !string.IsNullOrWhiteSpace(line))
        {
            string[] cells = line.Split(',');
            string elem = missing_elem ? Path.GetFileNameWithoutExtension(file) : cells[col_elem];

            if (!dic.TryGetValue(elem, out var itens))
                itens = [];

            string wl = col_wl.Select(i => cells[i]).FirstOrDefault(c => !string.IsNullOrWhiteSpace(c)) ?? "";
            var it = cells[col_intens];

            wl = new(wl.Where(c => char.IsDigit(c) || c is '.').ToArray());
            it = new(it.Where(c => char.IsDigit(c) || c is '.').ToArray());

            double wl_d = double.Parse(wl);
            double it_d = double.Parse(it);

            itens[wl_d] = it_d;
            dic[elem] = itens;
        }
}

StringBuilder sb1 = new();
StringBuilder sb2 = new();

sb2.AppendLine("element,wavelength,intensity");

foreach ((string elem, var list) in dic)
{
    double max = list.Values.Max();

    sb1.AppendLine($"""
    //--------------- {elem} ---------------//
            new SparseSpectrum([
    """);

    foreach ((double wl, double intens) in list)
    {
        sb1.AppendLine($"            ({wl}d.Nanometer(), {intens / max}),");
        sb2.AppendLine($"{elem},{wl},{intens / max}");
    }

    sb1.AppendLine("        ]),");
}

File.WriteAllText("D:\\DEV\\Unknown6656.Units\\Unknown6656.Physics\\Chemistry\\spectra.txt", sb1.ToString());
File.WriteAllText("D:\\DEV\\Unknown6656.Units\\Unknown6656.Physics\\Chemistry\\spectra.csv", sb2.ToString());
#endif