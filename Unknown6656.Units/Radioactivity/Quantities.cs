using System.Collections.Generic;
using System;

using Unknown6656.Units.Electricity;
using Unknown6656.Units.Movement;
using Unknown6656.Units.Temporal;
using Unknown6656.Units.Energy;
using Unknown6656.Units.Matter;

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

    public static EquivalentDose AirportScreeningDose { get; } = new Sievert(2.5e-7);
    public static EquivalentDose AverageDentalRadiographDose { get; } = new Sievert(1e-5);
    public static EquivalentDose AverageChestRadiographDose { get; } = new Sievert(1e-5);
    public static EquivalentDose TwoViewMammogramDose { get; } = new Sievert(5e-4);
    public static EquivalentDose FullBodyCTScanDose { get; } = new Sievert(3e-3);
    public static EquivalentDose AverageDosePerAnnum { get; } = new Sievert(1e-3);
    public static EquivalentDose BariumFluoroscopyDose { get; } = new Sievert(6e-3);
    public static EquivalentDose TotalDosePerAnnumLimitUS { get; } = new Sievert(5e-2);
    public static EquivalentDose ISSDosePerAnnum { get; } = new Sievert(.16);
    public static EquivalentDose SolarSystemBackgroundRadiationPerAnnum { get; } = new Sievert(.6);
    public static EquivalentDose NASADosePerLifetimeLimit { get; } = new Sievert(1);
    public static EquivalentDose HumanLD50_In30Days { get; } = new Sievert(4.5);
    public static EquivalentDose FatalAcuteDose_HarryDaghlian { get; } = new Sievert(5.1);
#if USE_DIACRITICS
    public static EquivalentDose FatalAcuteDose_GoiâniaIncident { get; } = new Sievert(6);
#else
    public static EquivalentDose FatalAcuteDose_GoianiaIncident { get; } = new Sievert(6);
#endif
    public static EquivalentDose FatalAcuteDose_HisashiOuchi { get; } = new Sievert(17);
    public static EquivalentDose FatalAcuteDose_LouisSlotin { get; } = new Sievert(21);
    public static EquivalentDose FatalAcuteDose_CecilKelley { get; } = new Sievert(36);
    public static EquivalentDose FatalAcuteDose_BorisKorchilov { get; } = new Sievert(54);
}

[MultiplicativeRelationship<DoseRate, Time, EquivalentDose, SievertPerSecond, Second, Sievert, Scalar>]
public partial record DoseRate(SievertPerSecond value)
    : Quantity<DoseRate, SievertPerSecond, Scalar>(value)
{
    public static string QuantitySymbol { get; } = "H/t";

    public static DoseRate TotalDoseRateLimitUS { get; } = new SievertPerYear(EquivalentDose.TotalDosePerAnnumLimitUS.Sievert.Value);
    public static DoseRate ISSDoseRate { get; } = new SievertPerYear(EquivalentDose.ISSDosePerAnnum.Sievert.Value);
    public static DoseRate SolarSystemBackgroundRadiation { get; } = new SievertPerYear(EquivalentDose.SolarSystemBackgroundRadiationPerAnnum.Sievert.Value);
    public static DoseRate RecommendedMaximumHumanIrradiation { get; } = new SievertPerYear(1e-3);
    public static DoseRate BackgroundRadiationGlobalAverage { get; } = new SievertPerYear(2.4e-3);
    public static DoseRate ChernobylOutsideNSC { get; } = new SievertPerYear(8e-3);
    public static DoseRate BackgroundRadiationFinland { get; } = new SievertPerYear(8e-3);
    public static DoseRate BackgroundRadiationCruisingAltitude { get; } = new SievertPerYear(.024);
    public static DoseRate ChernobylInsideNSC { get; } = new SievertPerYear(.046);
    public static DoseRate ChernobylInsideTheClaw { get; } = new SievertPerYear(.35);
    public static DoseRate GuarapariBeach { get; } = new SievertPerYear(.18);
    public static DoseRate HighRadiationAreaLimit { get; } = new SievertPerYear(9);
    public static DoseRate TrinityMaxFallout { get; } = new SievertPerYear(1.7e3);
    public static DoseRate PWRFuelWaste { get; } = new SievertPerYear(2.3e6);
    public static DoseRate FukushimaDaiichi2017 { get; } = new SievertPerYear(5e6);
}

// kerma https://en.wikipedia.org/wiki/Kerma_(physics)

