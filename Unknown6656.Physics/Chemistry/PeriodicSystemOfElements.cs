using System.Collections.Concurrent;
using System.Linq;
using System;

using Unknown6656.Generics;
using Unknown6656.Common;

namespace Unknown6656.Physics.Chemistry;


// TODO: actinon        = rn-219
// TODO: thoron         = rn-220
// TODO: actinium x     = ra-223
// TODO: thorium x      = ra-224
// TODO: mesothorium 1  = ra-228
// TODO: mesothorium 2  = ac-228
// TODO: radioactinium  = th-227
// TODO: radiothorium   = th-228
// TODO: ionium         = th-230
// TODO: uranium x1     = th-234
// TODO: uranium x2     = pa-234
// TODO: radium d       = pb-210
// TODO: radium f       = po-210


public sealed partial class PeriodicTableOfElements
{
    private readonly ConcurrentDictionary<uint, Element> _elements = new();


    public static PeriodicTableOfElements Table { get; } = new();

    public Element[] ElementsByAtomicNumber => field ??= _elements.Values.OrderBy(e => e.AtomicNumber).ToArray();

    public Isotope[] IsotopesByAtomicNumber => field ??= [..(from kvp in _elements
                                                             from iso in kvp.Value.KnownIsotopes
                                                             orderby kvp.Key, iso.NeutronCount ascending
                                                             select iso)];

    // TODO : add more sorting/enumeration properties

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
            return TryGetElement(atomicNumber);

        // TODO : parse isotope/hardron notation

        return _elements.Values.FirstOrDefault(e => e.AlternateNames.Prepend(e.Name.ToLowerInvariant())
                                                                    .Append(e.Symbol.ToLowerInvariant())
                                                                    .Contains(name_or_symbol));
    }

    public Element? TryGetElement(int atomicNumber) => TryGetElement((uint)atomicNumber);

    public Element? TryGetElement(uint atomicNumber) => _elements.TryGetValue(atomicNumber, out var element) ? element : null;

    public Element GetElement(int atomicNumber) => GetElement((uint)atomicNumber);

    public Element GetElement(uint atomicNumber) => this[atomicNumber];

    public Isotope? TryGetIsotope(string name, bool fallback_to_element = false) => Isotope.TryGetIsotope(name, fallback_to_element);

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
