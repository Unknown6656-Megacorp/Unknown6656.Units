using System;
using System.Collections.Generic;

using Unknown6656.Units.Electricity;
using Unknown6656.Units.Energy;
using Unknown6656.Units.Matter;
using Unknown6656.Units.Movement;
using Unknown6656.Units.Temporal;

namespace Unknown6656.Units.Radioactivity;


[MultiplicativeRelationship<RadiationExposure, Mass, Charge, CoulombPerKilogram, Kilogram, Coulomb, Scalar>]
public partial record RadiationExposure(CoulombPerKilogram value)
    : Quantity<RadiationExposure, CoulombPerKilogram, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "X";
}

[InverseRelationship<Activity, Time, Becquerel, Second, Scalar>]
[IdentityRelationship<Activity, Frequency, Becquerel, Hertz, Scalar>]
public partial record Activity(Becquerel value)
    : Quantity<Activity, Becquerel, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "A";
}

[MultiplicativeRelationship<SpecificActivity, Mass, Activity, BecquerelPerKilogram, Kilogram, Becquerel, Scalar>]
public partial record SpecificActivity(BecquerelPerKilogram value)
    : Quantity<SpecificActivity, BecquerelPerKilogram, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "a";
}

[IdentityRelationship<AbsorbedDose, SpecificEnergy, Gray, JoulePerKilogram, Scalar>]
[MultiplicativeRelationship<AbsorbedDose, Mass, KineticEnergy, Gray, Kilogram, Joule, Scalar>]
public partial record AbsorbedDose(Gray value)
    : Quantity<AbsorbedDose, Gray, Scalar>(value)
{
    public static IReadOnlyDictionary<TissueWeighingFactor, Scalar> TissueWeighingFactors { get; } = new Dictionary<TissueWeighingFactor, Scalar>()
    {
        [TissueWeighingFactor.Gonads] = .08,
        [TissueWeighingFactor.BoneMarrow] = .12,
        [TissueWeighingFactor.Colon] = .12,
        [TissueWeighingFactor.Lung] = .12,
        [TissueWeighingFactor.Stomach] = .12,
        [TissueWeighingFactor.Breasts] = .12,
        [TissueWeighingFactor.Bladder] = .04,
        [TissueWeighingFactor.Liver] = .04,
        [TissueWeighingFactor.Esophagus] = .04,
        [TissueWeighingFactor.Thyroid] = .04,
        [TissueWeighingFactor.Skin] = .01,
        [TissueWeighingFactor.BoneSurface] = .01,
        [TissueWeighingFactor.Brain] = .01,
        [TissueWeighingFactor.SalivaryGlands] = .01,
        [TissueWeighingFactor.Other] = .12,
    };

    public static IReadOnlyDictionary<RadiationWeightingFactor, Scalar> RadiationWeightingFactors { get; } = new Dictionary<RadiationWeightingFactor, Scalar>()
    {
        [RadiationWeightingFactor.XRay] = 1,
        [RadiationWeightingFactor.GammaRay] = 1,
        [RadiationWeightingFactor.BetaParticle] = 1,
        [RadiationWeightingFactor.Muon] = 1,
        [RadiationWeightingFactor.Neutron_Below_1MeV] = 2.5,
        [RadiationWeightingFactor.Neutron_Below_50MeV] = 5,
        [RadiationWeightingFactor.Neutron_Above_50MeV] = 2.5,
        [RadiationWeightingFactor.Proton] = 2,
        [RadiationWeightingFactor.ChargedPion] = 2,
        [RadiationWeightingFactor.AlphaParticle] = 20,
        [RadiationWeightingFactor.FissionProducts] = 20,
        [RadiationWeightingFactor.HeavyNuclei] = 20,
    };

    public static string QuantitySymbol { get; } = "D";


    public EquivalentDose this[TissueWeighingFactor tissueWeighingFactor, RadiationWeightingFactor radiationWeightingFactor] =>
        GetEquivalentDose(tissueWeighingFactor, radiationWeightingFactor);

    public EquivalentDose this[TissueWeighingFactor tissueWeighingFactor, ElectronVolt neutronEnergy] =>
        GetEquivalentDose(tissueWeighingFactor, neutronEnergy);


    public EquivalentDose GetEquivalentDose(TissueWeighingFactor tissueWeighingFactor, RadiationWeightingFactor radiationWeightingFactor) =>
        GetEquivalentDose(tissueWeighingFactor, radiationWeightingFactor, new(radiationWeightingFactor switch
        {
            RadiationWeightingFactor.Neutron_Below_1MeV => 5e5,
            RadiationWeightingFactor.Neutron_Below_50MeV => 2.5e7,
            RadiationWeightingFactor.Neutron_Above_50MeV => 7.5e7,
            _ => 0,
        }));

    public EquivalentDose GetEquivalentDose(TissueWeighingFactor tissueWeighingFactor, ElectronVolt neutronEnergy) =>
        GetEquivalentDose(tissueWeighingFactor, neutronEnergy.Value switch
        {
            <= 0 => throw new ArgumentOutOfRangeException(nameof(neutronEnergy)),
            <= 1e6 => RadiationWeightingFactor.Neutron_Below_1MeV,
            <= 5e7 => RadiationWeightingFactor.Neutron_Below_50MeV,
            > 5e7 => RadiationWeightingFactor.Neutron_Above_50MeV,
            _ => throw new ArgumentOutOfRangeException(nameof(neutronEnergy)),
        }, neutronEnergy);

    public EquivalentDose GetEquivalentDose(TissueWeighingFactor tissueWeighingFactor, RadiationWeightingFactor radiationWeightingFactor, ElectronVolt neutronEnergy)
    {
        if (!TissueWeighingFactors.TryGetValue(tissueWeighingFactor, out Scalar W_T))
            W_T = TissueWeighingFactors[TissueWeighingFactor.Other];

        Scalar W_R;

        if (radiationWeightingFactor is RadiationWeightingFactor.Neutron_Below_1MeV)
            W_R = 2.5 + 18.2 * Math.Exp(-Math.Pow(Math.Log(neutronEnergy.Value), 2) / 6);
        else if (radiationWeightingFactor is RadiationWeightingFactor.Neutron_Below_50MeV)
            W_R = 5 + 17 * Math.Exp(-Math.Pow(Math.Log(neutronEnergy.Value * 2), 2) / 6);
        else if (radiationWeightingFactor is RadiationWeightingFactor.Neutron_Above_50MeV)
            W_R = 2.5 + 3.25 * Math.Exp(-Math.Pow(Math.Log(neutronEnergy.Value * .04), 2) / 6);
        else if (!TissueWeighingFactors.TryGetValue(tissueWeighingFactor, out W_R))
            W_R = 2;

        return new(new Sievert(W_T * W_R * Value.Value));
    }
}

public enum RadiationWeightingFactor
{
    XRay,
    GammaRay,
    BetaParticle,
    Muon,
    Neutron_Below_1MeV,
    Neutron_Below_50MeV,
    Neutron_Above_50MeV,
    Proton,
    ChargedPion,
    AlphaParticle,
    FissionProducts,
    HeavyNuclei,
}

public enum TissueWeighingFactor
{
    Gonads,
    BoneMarrow,
    Colon,
    Lung,
    Stomach,
    Breasts,
    Bladder,
    Liver,
    Esophagus,
    Thyroid,
    Skin,
    BoneSurface,
    Brain,
    SalivaryGlands,
    Other
}

[IdentityRelationship<AbsorbedDose, EquivalentDose, Gray, Sievert, Scalar>]
[IdentityRelationship<EquivalentDose, SpecificEnergy, Sievert, JoulePerKilogram, Scalar>]
[MultiplicativeRelationship<Speed, EquivalentDose, MeterPerSecond, Sievert, Scalar>]
[MultiplicativeRelationship<EquivalentDose, Mass, KineticEnergy, Sievert, Kilogram, Joule, Scalar>]
public partial record EquivalentDose(Sievert value)
    : Quantity<EquivalentDose, Sievert, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "H";


    public Sievert AirportScreeningDose { get; } = new(2.5e-7);
    public Sievert AverageDentalRadiographDose { get; } = new(1e-5);
    public Sievert AverageChestRadiographDose { get; } = new(1e-5);
    public Sievert TwoViewMammogramDose { get; } = new(5e-4);
    public Sievert FullBodyCTScanDose { get; } = new(3e-3);
    public Sievert AverageDosePerAnnum { get; } = new(1e-3);
    public Sievert BariumFluoroscopyDose { get; } = new(6e-3);
    public Sievert TotalDosePerAnnumLimitUS { get; } = new(5e-2);
    public Sievert ISSDosePerAnnum { get; } = new(.16);
    public Sievert SolarSystemBackgroundRadiationPerAnnum { get; } = new(.6);
    public Sievert NASADosePerLifetimeLimit { get; } = new(1);
    public Sievert HumanLD50_In30Days { get; } = new(4.5);
    public Sievert FatalAcuteDose_HarryDaghlian { get; } = new(5.1);
#if USE_DIACRITICS
    public Sievert FatalAcuteDose_GoiâniaIncident { get; } = new(6);
#else
    public Sievert FatalAcuteDose_GoianiaIncident { get; } = new(6);
#endif
    public Sievert FatalAcuteDose_HisashiOuchi { get; } = new(17);
    public Sievert FatalAcuteDose_LouisSlotin { get; } = new(21);
    public Sievert FatalAcuteDose_CecilKelley { get; } = new(36);
    public Sievert FatalAcuteDose_BorisKorchilov { get; } = new(54);
}

[MultiplicativeRelationship<DoseRate, Time, EquivalentDose, SievertPerSecond, Second, Sievert, Scalar>]
public partial record DoseRate(SievertPerSecond value)
    : Quantity<DoseRate, SievertPerSecond, Scalar>(value)
{
}


// kerma https://en.wikipedia.org/wiki/Kerma_(physics)

