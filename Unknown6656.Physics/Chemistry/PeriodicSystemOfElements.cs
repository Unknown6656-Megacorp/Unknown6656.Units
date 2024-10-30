using System.Collections.Generic;
using System.Linq;
using System;

using Unknown6656.Generics;
using Unknown6656.Common;

namespace Unknown6656.Physics.Chemistry;


public sealed partial class PeriodicTableOfElements
{
    private readonly Dictionary<uint, Element> _elements = [];


    public static PeriodicTableOfElements Table { get; } = new();

    public Element? this[string name_or_symbol] => TryGetElement(name_or_symbol);

    public Element this[int atomicNumber] => this[(uint)atomicNumber];

    public Element this[uint atomicNumber] => _elements[atomicNumber];

    public Isotope? this[int protons, int neutrons] => GetIsotope(protons, neutrons);

    public Isotope? this[uint protons, uint neutrons] => GetIsotope(protons, neutrons);


    private PeriodicTableOfElements()
    {
    }

    private Element RegisterElement(Element element) => _elements[element.AtomicNumber] = element;

    public Element? TryGetElement(string name_or_symbol)
    {
        name_or_symbol = new(name_or_symbol.RemoveDiacritics()
                                           .Where(char.IsAsciiLetterOrDigit)
                                           .ToArray(char.ToLowerInvariant));

        if (int.TryParse(name_or_symbol, out int atomicNumber))
            return GetElement(atomicNumber);

        // TODO : parse isotope/hardron notation

        return _elements.Values.FirstOrDefault(e => e.AlternateNames.Prepend(e.Name.ToLowerInvariant())
                                                                    .Append(e.Symbol.ToLowerInvariant())
                                                                    .Contains(name_or_symbol));
    }

    public Element GetElement(int atomicNumber) => GetElement((uint)atomicNumber);

    public Element GetElement(uint atomicNumber) => this[atomicNumber];

    public Isotope? GetIsotope(int protons, int neutrons) => GetIsotope((uint)protons, (uint)neutrons);

    public Isotope? GetIsotope(uint protons, uint neutrons) => GetElement(protons).GetIsotopeByNeutronCount(neutrons);

    public Isotope? GetIsotopeByHadrons(int hadrons, int protons) => GetIsotopeByHadrons((uint)hadrons, (uint)protons);

    public Isotope? GetIsotopeByHadrons(uint hadrons, uint protons) => GetIsotope(protons, hadrons - protons);

    public Isotope[] GetIsotopesByHadrons(int hadrons) => GetIsotopesByHadrons((uint)hadrons);

    public Isotope[] GetIsotopesByHadrons(uint hadrons) => [..from elem in _elements.Values
                                                              from iso in elem.KnownIsotopes
                                                              where iso.HadronCount == hadrons
                                                              select iso];
}
