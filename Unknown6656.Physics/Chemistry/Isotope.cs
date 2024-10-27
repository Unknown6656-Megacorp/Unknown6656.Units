using System.Collections.Generic;
using System.Linq;
using System;

using Unknown6656.Physics.Nuclear;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Matter;

namespace Unknown6656.Physics.Chemistry;


/// <summary>
/// Represents the various modes of radioactive decay.
/// </summary>
public enum DecayMode
{
    /// <summary>
    /// Indicates that the element is stable and does not undergo radioactive decay.
    /// </summary>
    Stable = 0,
    /// <summary>
    /// Alpha decay, where the nucleus emits an alpha particle (2 protons and 2 neutrons).
    /// </summary>
    Alpha,
    /// <summary>
    /// Beta-minus decay, where a neutron is converted into a proton, an electron, and an antineutrino.
    /// </summary>
    Beta,
    BetaAlpha,
    BetaNeutronEmission,
    BetaDoubleNeutronEmission,
    BetaTripleNeutronEmission,
    BetaQuadrupleNeutronEmission,
    DeuteronEmission,
    BetaDeuteronEmission,
    BetaTritonEmission,
    /// <summary>
    /// Beta-plus decay, where a proton is converted into a neutron, a positron, and a neutrino.
    /// </summary>
    PositronEmission,
    PositronProtonEmission,
    PositronAlphaEmission,
    /// <summary>
    /// Electron capture, where an inner orbital electron is captured by the nucleus.
    /// </summary>
    ElectronCapture,
    /// <summary>
    /// Isomeric transition, where the nucleus changes from a higher to a lower energy state.
    /// </summary>
    IsomericTransition,
    /// <summary>
    /// Spontaneous fission, where the nucleus splits into two or more smaller nuclei and other particles.
    /// </summary>
    SpontaneousFission,
    /// <summary>
    /// Cluster decay, where the nucleus emits a small "cluster" of neutrons and protons.
    /// </summary>
    ClusterDecay,
    /// <summary>
    /// Neutron emission, where the nucleus emits a neutron.
    /// </summary>
    NeutronEmission,
    /// <summary>
    /// Double neutron emission, where two neutrons are emitted by the nucleus.
    /// </summary>
    DoubleNeutronEmission,
    /// <summary>
    /// Proton emission, where the nucleus emits a proton.
    /// </summary>
    ProtonEmission,
    /// <summary>
    /// Double proton emission, where two protons are emitted by the nucleus.
    /// </summary>
    DoubleProtonEmission,
    /// <summary>
    /// Double beta decay, where two neutrons are converted into two protons, two electrons, and two antineutrinos.
    /// </summary>
    DoubleBetaDecay,
    /// <summary>
    /// Double beta-plus decay, where two protons are converted into two neutrons, two positrons, and two neutrinos.
    /// </summary>
    DoublePositronEmission,
    /// <summary>
    /// Beta-gamma decay, where beta decay is followed by gamma emission.
    /// </summary>
    BetaGammaDecay,
    /// <summary>
    /// Gamma decay, where the nucleus emits a gamma ray.
    /// </summary>
    Gamma,
    /// <summary>
    /// Neutron capture, where the nucleus captures a neutron.
    /// </summary>
    NeutronCapture,
}

public record IsotopeDecayConfig(DecayMode Mode, Time HalfTime, double Probability = 1);

public record IsotopeConfig
{
    public required uint NeutronCount { get; init; }
    public required IEnumerable<IsotopeDecayConfig>? Decays { get; init; }
    public string? Name { get; init; } = null;
    public double Abundance { get; init; } = 0;
    public required Spin Spin { get; init; }
}

public class Isotope
{
    public string Name { get; }
    public Element Element { get; }
    public PeriodicTableOfElements PeriodicTable => Element.PeriodicTable;
    public uint NeutronCount { get; }
    public Dalton AtomicMass { get; }
    public double Abundance { get; }
    public uint HadronCount => NeutronCount + Element.ProtonCount;
    public Spin Spin { get; }
    public IsotopeDecay[] KnownDecays { get; }
    public bool IsStable => KnownDecays.Count(d => d.Mode != DecayMode.Stable) > 0;


    internal Isotope(Element element, IsotopeConfig config)
    {
        Element = element;
        Spin = config.Spin;
        Name = config.Name ?? element.Name;
        NeutronCount = config.NeutronCount;
        AtomicMass = Mass.AtomicMass(element.ProtonCount, config.NeutronCount);
        Abundance = double.Clamp(config.Abundance, 0, 1);

        double total_prob = config.Decays?.Sum(d => d.Probability) ?? 0;

        if (total_prob <= 0)
            total_prob = 1; // prevent div by zero

        KnownDecays = config.Decays?.Select(d => new IsotopeDecay(this, d with { Probability = d.Probability / total_prob }))?.ToArray() ?? [];
    }

    public override int GetHashCode() => HashCode.Combine(Element.ProtonCount, NeutronCount);

    public override bool Equals(object? obj) => obj is Isotope other && other.Element == Element && other.NeutronCount == NeutronCount;

    public override string ToString() => $"{Name} ({Element.AtomicNumber}, {Element.Symbol}-{Element.AtomicNumber + NeutronCount})";
}

public class IsotopeDecay
{
    private readonly (int P, int N) _target;

    public Isotope SourceIsotope { get; }
    public DecayMode Mode { get; }
    public Time HalfTime { get; }
    public double Probability { get; }
    public Element SourceElement => SourceIsotope.Element;
    public Isotope? TargetIsotope => PeriodicTable[_target.P, _target.N];
    public Element? TargetElement => TargetIsotope?.Element;
    public PeriodicTableOfElements PeriodicTable => SourceElement.PeriodicTable;
    public int ProtonDifference => _target.P - (int)SourceElement.ProtonCount;
    public int NeutronDifference => _target.N - (int)SourceIsotope.NeutronCount;
    public int HadronDifference => ProtonDifference + NeutronDifference;


    internal IsotopeDecay(Isotope source, IsotopeDecayConfig config)
    {
        Mode = config.Mode;
        HalfTime = config.HalfTime;
        Probability = config.Probability;
        SourceIsotope = source;

        (int P, int N) = config.Mode switch
        {
            DecayMode.Stable or
            DecayMode.IsomericTransition => (0, 0),
            DecayMode.Alpha => (-2, -2),
            DecayMode.PositronAlphaEmission => (-3, -1),
            DecayMode.PositronProtonEmission => (-2, -1),
            DecayMode.ProtonEmission => (-1, 0),
            DecayMode.DoubleProtonEmission => (-2, 0),
            DecayMode.NeutronEmission => (0, -1),
            DecayMode.DoubleNeutronEmission or
            DecayMode.BetaDeuteronEmission => (0, -2),
            DecayMode.NeutronCapture => (0, 1),
            DecayMode.ElectronCapture or
            DecayMode.PositronEmission => (-1, 1),
            DecayMode.Beta or
            DecayMode.BetaGammaDecay => (1, -1),
            DecayMode.DoubleBetaDecay => (2, -2),
            DecayMode.DoublePositronEmission => (-2, 2),
            DecayMode.DeuteronEmission => (-1, -1),
            DecayMode.BetaAlpha => (-1, -3),
            DecayMode.BetaTritonEmission => (0, -3),
            DecayMode.BetaNeutronEmission => (1, -2),
            DecayMode.BetaDoubleNeutronEmission => (1, -3),
            DecayMode.BetaTripleNeutronEmission => (1, -4),
            DecayMode.BetaQuadrupleNeutronEmission => (1, -5),

            //DecayMode.ClusterDecay => (, ),
            //DecayMode.SpontaneousFission => (, ),
            //DecayMode.Gamma => (, ),

            _ => throw new NotImplementedException($"I'm terribly sorry, but I haven't yet implemented the decay mode {config.Mode}. it's on my TODO list.")
        };

        P += (int)source.Element.ProtonCount;
        N += (int)source.NeutronCount;

        _target = (P, N);
    }

    public override string ToString() => $"{SourceIsotope} --[{Mode switch
    {
        DecayMode.Stable => "stable",
        DecayMode.IsomericTransition => "IT",
        DecayMode.Alpha => "α",
        DecayMode.PositronAlphaEmission => "β⁺α",
        DecayMode.PositronProtonEmission => "β⁺p",
        DecayMode.ProtonEmission => "p",
        DecayMode.DoubleProtonEmission => "2p",
        DecayMode.NeutronEmission => "n",
        DecayMode.DoubleNeutronEmission => "2n",
        DecayMode.BetaDeuteronEmission => "β⁻d",
        DecayMode.NeutronCapture => "η",
        DecayMode.ElectronCapture => "ε",
        DecayMode.PositronEmission => "β⁺",
        DecayMode.Beta => "β⁻",
        DecayMode.BetaGammaDecay => "β⁻γ",
        DecayMode.DoubleBetaDecay => "2β⁻",
        DecayMode.DoublePositronEmission => "2β⁺",
        DecayMode.DeuteronEmission => "d",
        DecayMode.BetaAlpha => "β⁻α",
        DecayMode.BetaTritonEmission => "β⁻t",
        DecayMode.BetaNeutronEmission => "β⁻n",
        DecayMode.BetaDoubleNeutronEmission => "β⁻2n",
        DecayMode.BetaTripleNeutronEmission => "β⁻3n",
        DecayMode.BetaQuadrupleNeutronEmission => "β⁻4n",
        DecayMode.SpontaneousFission => "SF",
        DecayMode.ClusterDecay => "CD",
        DecayMode.Gamma => "γ",
        _ => "(?)"
    }}, {HalfTime}, {Probability:P2}]--> {TargetIsotope}";
}

/* DECAY MODES:

  \ P|     |     |     |     |     |     |     |     |
 N \ |  -4 |  -3 |  -2 |  -1 |  0  |  +1 |  +2 |  +3 |
----\+-----+-----+-----+-----+-----+-----+-----+-----+
  -5 |     |     |     |     |     | β4n |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  -4 |     |     |     |     |     | β3n |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  -3 |     |     |     |  βα |  βt | β2n |     |     |
-----+-----+-----+-----+-----+--+--+-----+-----+-----+
  -2 |     |     |  α  |     |2n|βd|  βn |  2β |     |
-----+-----+-----+-----+--+--+--+--+-----+-----+-----+
  -1 |     | β+α | β+p |β+| ε|  n  |  β  |     |     |
-----+-----+-----+-----+--+--+--+--+-----+-----+-----+
   0 |     |     |  2p |  p  | S|IT|     |     |     |
-----+-----+-----+-----+-----+--+--+-----+-----+-----+
  +1 |     |     |     |  d  |  η  |     |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  +2 |     |     | 2β+ |     |     |     |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
  +3 |     |     |     |     |     |     |     |     |
-----+-----+-----+-----+-----+-----+-----+-----+-----+
*/