using System.Net;
using System.Text.RegularExpressions;

using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;

using Unknown6656.Generics;



string url = "https://en.wikipedia.org/wiki/Isotopes_of_nitrogen";
HtmlDocument html = new();

using (HttpClient client = new())
    html.LoadHtml(await client.GetStringAsync(url));

string isotopes = "";
Regex re_sigma = new(@"\s*\(\s*\d+(\s*\.\s*\d+)?\s*\)\s*", RegexOptions.Compiled);

foreach (HtmlNode table in html.DocumentNode.QuerySelectorAll("table.wikitable.sortable").Select(ProcessTable))
{
    const int col_N = 2;
    const int col_halflife = 4;
    const int col_mode = 5;
    const int col_spin = 7;
    const int col_abundance = 9;

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
        string halflife = first[col_halflife].InnerText.Trim().Replace("&#160;", "");
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

            decays.Add($"\n                new(DecayMode.{mode}, {halflife}.Second())");
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

isotopes = re_sigma.Replace(isotopes, "");

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
