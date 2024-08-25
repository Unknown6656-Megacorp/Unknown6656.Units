using System.Collections.Generic;
using System.Linq;
using System;

using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Temporal;
using System.Collections.Immutable;
using System.Collections;

namespace Unknown6656.Physics.Optics;


public record SpectralBand
{
    #region STATIC PROPERTIES

    public static SpectralBand VisibleSpectralBand { get; } = new(380d.Nanometer(), 720d.Nanometer());
    public static SpectralBand UltravioletA { get; } = new(315d.Nanometer(), 400d.Nanometer());
    public static SpectralBand UltravioletB { get; } = new(280d.Nanometer(), 315d.Nanometer());
    public static SpectralBand UltravioletC { get; } = new(100d.Nanometer(), 280d.Nanometer());
    public static SpectralBand NearUltraviolet { get; } = new(300d.Nanometer(), 400d.Nanometer());
    public static SpectralBand MiddleUltraviolet { get; } = new(200d.Nanometer(), 300d.Nanometer());
    public static SpectralBand FarUltraviolet { get; } = new(122d.Nanometer(), 200d.Nanometer());
    public static Wavelength HydrogenLymanAlphaUltraviolet { get; } = 121.6.Nanometer();
    public static SpectralBand ExtremeUltraviolet { get; } = new(10d.Nanometer(), 121d.Nanometer());
    public static SpectralBand VacuumUltraviolet { get; } = new(10d.Nanometer(), 200d.Nanometer());
    public static SpectralBand NearInfrared { get; } = new(750d.Nanometer(), 1400d.Nanometer());
    public static SpectralBand ShortwaveInfrared { get; } = new(1400d.Nanometer(), 3000d.Nanometer());
    public static SpectralBand MidwaveInfrared { get; } = new(3000d.Nanometer(), 8000d.Nanometer());
    public static SpectralBand LongwaveInfrared { get; } = new(8000d.Nanometer(), 15000d.Nanometer());
    public static SpectralBand FarInfrared { get; } = new(15000d.Nanometer(), 1_000_000d.Nanometer());
    public static SpectralBand CIE_IRABand { get; } = new(780d.Nanometer(), 1400d.Nanometer());
    public static SpectralBand CIE_IRBBand { get; } = new(1400d.Nanometer(), 3000d.Nanometer());
    public static SpectralBand CIE_IRCBand { get; } = new(3000d.Nanometer(), 1_000_000d.Nanometer());
    public static SpectralBand ISO20473_NIR { get; } = new(780d.Nanometer(), 3000d.Nanometer());
    public static SpectralBand ISO20473_MIR { get; } = new(3000d.Nanometer(), 50_000d.Nanometer());
    public static SpectralBand ISO20473_FIR { get; } = new(50_000d.Nanometer(), 1_000_000d.Nanometer());
    public static SpectralBand OpticalFiber_OBand { get; } = new(1260d.Nanometer(), 1360d.Nanometer());
    public static SpectralBand OpticalFiber_EBand { get; } = new(1360d.Nanometer(), 1460d.Nanometer());
    public static SpectralBand OpticalFiber_SBand { get; } = new(1460d.Nanometer(), 1530d.Nanometer());
    public static SpectralBand OpticalFiber_CBand { get; } = new(1530d.Nanometer(), 1565d.Nanometer());
    public static SpectralBand OpticalFiber_LBand { get; } = new(1565d.Nanometer(), 1625d.Nanometer());
    public static SpectralBand OpticalFiber_UBand { get; } = new(1625d.Nanometer(), 1675d.Nanometer());
    public static SpectralBand TerahertzGap { get; } = new(3_000_000d.Nanometer(), 30_000d.Nanometer());
    public static SpectralBand mmWaveBand => EHFBand;
    public static SpectralBand THFBand { get; } = new(3e11.Hertz(), 3e12.Hertz());
    public static SpectralBand EHFBand { get; } = new(3e10.Hertz(), 3e11.Hertz());
    public static SpectralBand SHFBand { get; } = new(3e9.Hertz(), 3e10.Hertz());
    public static SpectralBand UHFBand { get; } = new(3e8.Hertz(), 3e9.Hertz());
    public static SpectralBand VHFBand { get; } = new(3e7.Hertz(), 3e8.Hertz());
    public static SpectralBand HFBand { get; } = new(3e6.Hertz(), 3e7.Hertz());
    public static SpectralBand MFBand { get; } = new(3e5.Hertz(), 3e6.Hertz());
    public static SpectralBand LFBand { get; } = new(3e4.Hertz(), 3e5.Hertz());
    public static SpectralBand VLFBand { get; } = new(3e3.Hertz(), 3e4.Hertz());
    public static SpectralBand ULFBand { get; } = new(300d.Hertz(), 3e3.Hertz());
    public static SpectralBand SLFBand { get; } = new(30d.Hertz(), 300d.Hertz());
    public static SpectralBand ELFBand { get; } = new(3d.Hertz(), 30d.Hertz());
    public static SpectralBand IEEE521_LBand { get; } = new(1e9.Hertz(), 2e9.Hertz());
    public static SpectralBand IEEE521_SBand { get; } = new(2e9.Hertz(), 4e9.Hertz());
    public static SpectralBand IEEE521_CBand { get; } = new(4e9.Hertz(), 8e9.Hertz());
    public static SpectralBand IEEE521_XBand { get; } = new(8e9.Hertz(), 12e9.Hertz());
    public static SpectralBand IEEE521_KuBand { get; } = new(12e9.Hertz(), 18e9.Hertz());
    public static SpectralBand IEEE521_KBand { get; } = new(18e9.Hertz(), 26.5e9.Hertz());
    public static SpectralBand IEEE521_KaBand { get; } = new(26.5e9.Hertz(), 40e9.Hertz());
    public static SpectralBand IEEE521_QBand { get; } = new(33e9.Hertz(), 50e9.Hertz());
    public static SpectralBand IEEE521_UBand { get; } = new(40e9.Hertz(), 60e9.Hertz());
    public static SpectralBand IEEE521_VBand { get; } = new(50e9.Hertz(), 75e9.Hertz());
    public static SpectralBand IEEE521_WBand { get; } = new(75e9.Hertz(), 110e9.Hertz());
    public static SpectralBand IEEE521_FBand { get; } = new(90e9.Hertz(), 140e9.Hertz());
    public static SpectralBand IEEE521_DBand { get; } = new(110e9.Hertz(), 170e9.Hertz());
    public static SpectralBand IEEE521_GBand { get; } = new(110e9.Hertz(), 3e11.Hertz());
    public static SpectralBand NATO_ABand { get; } = new(0e6.Hertz(), 2.5e7.Hertz());
    public static SpectralBand NATO_BBand { get; } = new(2.5e7.Hertz(), 5e7.Hertz());
    public static SpectralBand NATO_CBand { get; } = new(5e7.Hertz(), 1e9.Hertz());
    public static SpectralBand NATO_DBand { get; } = new(1e9.Hertz(), 2e9.Hertz());
    public static SpectralBand NATO_EBand { get; } = new(2e9.Hertz(), 3e9.Hertz());
    public static SpectralBand NATO_FBand { get; } = new(3e9.Hertz(), 4e9.Hertz());
    public static SpectralBand NATO_GBand { get; } = new(4e9.Hertz(), 6e9.Hertz());
    public static SpectralBand NATO_HBand { get; } = new(6e9.Hertz(), 8e9.Hertz());
    public static SpectralBand NATO_IBand { get; } = new(8e9.Hertz(), 10e9.Hertz());
    public static SpectralBand NATO_JBand { get; } = new(10e9.Hertz(), 20e9.Hertz());
    public static SpectralBand NATO_KBand { get; } = new(20e9.Hertz(), 40e9.Hertz());
    public static SpectralBand NATO_LBand { get; } = new(40e9.Hertz(), 60e9.Hertz());
    public static SpectralBand NATO_MBand { get; } = new(60e9.Hertz(), 100e9.Hertz());
    public static SpectralBand SACLAND_NBand { get; } = new(100e9.Hertz(), 200e9.Hertz());
    public static SpectralBand SACLAND_OBand => SACLAND_NBand;
    public static SpectralBand NATO_PBand { get; } = new(225e6.Hertz(), 390e6.Hertz()); // old
    public static SpectralBand NATO_SBand { get; } = new(1.55e9.Hertz(), 3.9e9.Hertz()); // old
    public static SpectralBand NATO_XBand { get; } = new(6.2e9.Hertz(), 10.9e9.Hertz()); // old
    public static SpectralBand NATO_KuBand { get; } = new(10.9e9.Hertz(), 20e9.Hertz()); // old
    public static SpectralBand NATO_KaBand { get; } = new(20e9.Hertz(), 36e9.Hertz()); // old
    public static SpectralBand NATO_QBand { get; } = new(36e9.Hertz(), 46e9.Hertz()); // old
    public static SpectralBand NATO_VBand { get; } = new(46e9.Hertz(), 56e9.Hertz()); // old
    public static SpectralBand NATO_WBand { get; } = new(56e9.Hertz(), 100e9.Hertz()); // old
    public static SpectralBand FMRadioBand { get; } = new(87.5e6.Hertz(), 108e6.Hertz());
    public static SpectralBand LongwaveAMRadioBand { get; } = new(148.5e3.Hertz(), 283.5e3.Hertz());
    public static SpectralBand MediumwaveAMRadioBand { get; } = new(520e3.Hertz(), 1.7e6.Hertz());
    public static SpectralBand ShortwaveAMRadioBand { get; } = new(3e6.Hertz(), 30e6.Hertz());
    public static SpectralBand Airband { get; } = new(108e6.Hertz(), 137e6.Hertz());
    public static SpectralBand TVBand_I { get; } = new(47e6.Hertz(), 68e6.Hertz());
    public static SpectralBand TVBand_III { get; } = new(174e6.Hertz(), 230e6.Hertz());
    public static SpectralBand TVBand_IV { get; } = new(470e6.Hertz(), 582e6.Hertz());
    public static SpectralBand TVBand_V { get; } = new(582e6.Hertz(), 862e6.Hertz());

    #endregion
    #region INSTANCE PROPERTIES

    public Wavelength LowestWavelength { get; }
    public Wavelength HighestWavelength { get; }
    public Frequency LowestFrequency { get; }
    public Frequency HighestFrequency { get; }

    public Frequency CenterFrequency => (LowestFrequency + HighestFrequency) / 2;

    public Wavelength CenterWavelength => (LowestWavelength + HighestWavelength) / 2;

    public Frequency FrequencyRange => HighestFrequency - LowestFrequency;

    public Wavelength WavelengthRange => HighestWavelength - LowestWavelength;

    public virtual bool IsSpectralLine => LowestWavelength == HighestWavelength || LowestFrequency == HighestFrequency;

    public virtual bool IsFullyVisible => Contains(VisibleSpectralBand.LowestWavelength) && Contains(VisibleSpectralBand.HighestWavelength);

    public virtual bool IsPartiallyVisible => Contains(VisibleSpectralBand.LowestWavelength) || Contains(VisibleSpectralBand.HighestWavelength);

    public virtual SpectralBand? this[Frequency low, Frequency high] => Intersect((low, high));

    public virtual SpectralBand? this[Wavelength low, Wavelength high] => Intersect((low, high));

    public virtual SpectralBand? this[SpectralBand band] => Intersect(band);

    #endregion
    #region INSTANCE METHODS

    public SpectralBand(Wavelength wavelength)
        : this(wavelength, wavelength)
    {
    }

    public SpectralBand(Frequency frequency)
        : this(frequency, frequency)
    {
    }

    public SpectralBand(Wavelength low, Wavelength high)
    {
        if (low > high)
            (low, high) = (high, low);

        if (low < Wavelength.Zero)
            throw new ArgumentOutOfRangeException(nameof(low), "The lowest wavelength must not be negative.");

        LowestWavelength = low;
        HighestWavelength = high;
        LowestFrequency = high.ComputeFrequency();
        HighestFrequency = low.ComputeFrequency();
    }

    public SpectralBand(Frequency low, Frequency high)
    {
        if (low > high)
            (low, high) = (high, low);

        if (low < Frequency.Zero)
            throw new ArgumentOutOfRangeException(nameof(low), "The lowest frequency must not be negative.");

        LowestFrequency = low;
        HighestFrequency = high;
        LowestWavelength = high.ComputeWavelength();
        HighestWavelength = low.ComputeWavelength();
    }

    public override string ToString()
    {
        bool fmt_wavelength = LowestWavelength < 30_000d.Nanometer();
        string lower = fmt_wavelength ? LowestWavelength.ToString() : LowestFrequency.ToString();

        if (IsSpectralLine)
            return $"[{lower}]";
        else
        {
            string upper = fmt_wavelength ? HighestWavelength.ToString() : HighestFrequency.ToString();

            return $"[{lower} - {upper}]";
        }
    }

    public Wavelength GetWavelengthAt(double lerp)
    {
        if (lerp < 0 || lerp > 1)
            throw new ArgumentOutOfRangeException(nameof(lerp), "The interpolation factor must be in the range [0, 1].");

        return LowestWavelength + lerp * WavelengthRange;
    }

    public Frequency GetFrequencyAt(double lerp)
    {
        if (lerp < 0 || lerp > 1)
            throw new ArgumentOutOfRangeException(nameof(lerp), "The interpolation factor must be in the range [0, 1].");

        return LowestFrequency + lerp * FrequencyRange;
    }

    public bool Contains(Wavelength wavelength)
    {
        if (this is DisjointSpectrum disjoint)
            return disjoint._spectral_bands.Any(b => b.Contains(wavelength));
        else
            return wavelength >= LowestWavelength && wavelength <= HighestWavelength;
    }

    public bool Contains(Frequency frequency)
    {
        if (this is DisjointSpectrum disjoint)
            return disjoint._spectral_bands.Any(b => b.Contains(frequency));
        else
            return frequency >= LowestFrequency && frequency <= HighestFrequency;
    }

    public bool Contains(SpectralBand band)
    {
        if (band is DisjointSpectrum disjoint)
            return disjoint._spectral_bands.All(Contains);
        else
            return Contains(band.LowestWavelength) && Contains(band.HighestWavelength);
    }

    public bool Overlaps(SpectralBand other)
    {
        if (other is DisjointSpectrum disjoint)
            return disjoint._spectral_bands.Any(Overlaps);
        else
            return Contains(other.LowestWavelength) || Contains(other.HighestWavelength);
    }

    public bool Adjoins(SpectralBand other) => LowestWavelength == other.HighestWavelength || HighestWavelength == other.LowestWavelength;

    public (SpectralBand Lower, SpectralBand Upper) Invert() => (new(Wavelength.Zero, LowestWavelength), new(HighestWavelength, double.PositiveInfinity.Nanometer()));

    public SpectralBand ScaleBy(double factor) => new(LowestWavelength * factor, HighestWavelength * factor);

    public SpectralBand ShiftBy(Frequency frequency) => new(LowestFrequency + frequency, HighestFrequency + frequency);

    public SpectralBand ShiftBy(Wavelength wavelength) => new(LowestWavelength + wavelength, HighestWavelength + wavelength);

    public SpectralBand? Intersect(SpectralBand other)
    {
        Wavelength lo = Wavelength.Max(LowestWavelength, other.LowestWavelength);
        Wavelength hi = Wavelength.Min(HighestWavelength, other.HighestWavelength);

        return lo < hi ? new(lo, hi) : null;
    }

    public SpectralBand[] Except(SpectralBand other)
    {
        if (other.Contains(this))
            return [];
        else if (Contains(other))
            return [
                new(LowestWavelength, other.LowestWavelength),
                new(other.HighestWavelength, HighestWavelength)
            ];
        else if (Contains(other.LowestWavelength))
            return [new(LowestWavelength, other.LowestWavelength)];
        else if (Contains(other.HighestWavelength))
            return [new(other.HighestWavelength, HighestWavelength)];
        else
            return [this];
    }

    public SpectralBand Union(SpectralBand other) => new(
        Wavelength.Min(LowestWavelength, other.LowestWavelength),
        Wavelength.Max(HighestWavelength, other.HighestWavelength)
    );

    public SpectralBand[] Xor(SpectralBand other)
    {
        SpectralBand union = Union(other);

        if (Intersect(other) is { } intersection)
            return [new(union.LowestWavelength, intersection.LowestWavelength), new(intersection.HighestWavelength, union.HighestWavelength)];
        else if (Adjoins(other))
            return [union];
        else
            return [this, other];
    }

    public void Deconstruct(out Wavelength low, out Wavelength high) => (low, high) = (LowestWavelength, HighestWavelength);

    public void Deconstruct(out Frequency low, out Frequency high) => (low, high) = (LowestFrequency, HighestFrequency);

    #endregion
    #region STATIC METHODS

    public static SpectralBand[] Clamp(IEnumerable<SpectralBand> bands, Frequency low, Frequency high) => Union(from band in bands
                                                                                                                let cut = band.Intersect((low, high))
                                                                                                                where cut is { }
                                                                                                                select cut);

    public static SpectralBand[] Clamp(IEnumerable<SpectralBand> bands, Wavelength low, Wavelength high) => Union(from band in bands
                                                                                                                  let cut = band.Intersect((low, high))
                                                                                                                  where cut is { }
                                                                                                                  select cut);

    public static SpectralBand[] Union(IEnumerable<SpectralBand> bands)
    {
        bands = bands.SelectMany(b => (b as DisjointSpectrum)?._spectral_bands ?? [b]);

        List<SpectralBand> result = [];

        if (bands.FirstOrDefault() is { } first)
        {
            result.Add(first);

            foreach (SpectralBand input in bands.Skip(1))
            {
                int i = 0;

                for (; 0 < result.Count; ++i)
                    if (input != result[i] && input.Overlaps(result[i]))
                    {
                        result[i] = Union(input, result[i]);

                        break;
                    }

                if (i == result.Count)
                    result.Add(input);
            }
        }

        return [..result];
    }

    public static SpectralBand Union(SpectralBand first, SpectralBand second) => first.Union(second);

    public static SpectralBand? Intersect(SpectralBand first, SpectralBand second) => first.Intersect(second);

    public static SpectralBand[] Except(SpectralBand first, SpectralBand second) => first.Except(second);

    public static SpectralBand[] Xor(SpectralBand first, SpectralBand second) => first.Xor(second);

    public static SpectralBand? GetBounds(IEnumerable<SpectralBand> bands)
    {
        if (bands.FirstOrDefault() is { } first)
        {
            foreach (SpectralBand band in bands.Skip(1))
                first = Union(first, band);

            return first;
        }
        else
            return null;
    }

    #endregion
    #region OPERATORS

    public static SpectralBand operator +(SpectralBand band) => band;

    public static Spectrum operator *(SpectralBand band, double intensity) => Spectrum.CreateConstant(band, intensity);

    public static Spectrum operator *(double intensity, SpectralBand band) => Spectrum.CreateConstant(band, intensity);

    public static Spectrum operator *(SpectralBand band, Func<Wavelength, double> intensities) => new(band, intensities);

    public static Spectrum operator *(SpectralBand band, Func<Frequency, double> intensities) => new(band, intensities);

    public static Spectrum operator *(Func<Wavelength, double> intensities, SpectralBand band) => new(band, intensities);

    public static Spectrum operator *(Func<Frequency, double> intensities, SpectralBand band) => new(band, intensities);

    public static (SpectralBand Lower, SpectralBand Upper) operator ~(SpectralBand band) => band.Invert();

    public static SpectralBand operator |(SpectralBand first, SpectralBand second) => Union(first, second);

    public static SpectralBand[] operator -(SpectralBand first, SpectralBand second) => Except(first, second);

    public static SpectralBand? operator &(SpectralBand first, SpectralBand second) => Intersect(first, second);

    public static SpectralBand[] operator ^(SpectralBand first, SpectralBand second) => Xor(first, second);

    public static SpectralBand operator >>(SpectralBand band, Frequency frequency) => band.ShiftBy(frequency);

    public static SpectralBand operator >>(SpectralBand band, Wavelength wavelength) => band.ShiftBy(wavelength);

    public static SpectralBand operator <<(SpectralBand band, Frequency frequency) => band.ShiftBy(-frequency);

    public static SpectralBand operator <<(SpectralBand band, Wavelength wavelength) => band.ShiftBy(-wavelength);

    public static explicit operator Wavelength(SpectralBand band) => band.IsSpectralLine ? band.LowestWavelength : throw new InvalidCastException($"The spectral band {band} is not a spectral line.");

    public static explicit operator Frequency(SpectralBand band) => band.IsSpectralLine ? band.LowestFrequency : throw new InvalidCastException($"The spectral band {band} is not a spectral line.");

    public static implicit operator SpectralBand(Frequency frequency) => new(frequency);

    public static implicit operator SpectralBand(Wavelength wavelength) => new(wavelength);

    public static implicit operator SpectralBand((Wavelength low, Wavelength high) wavelengths) => new(wavelengths.low, wavelengths.high);

    public static implicit operator SpectralBand((Frequency low, Frequency high) frequencies) => new(frequencies.low, frequencies.high);

    #endregion

    //public static implicit operator (Wavelength low, Wavelength high)(SpectralBand band) => (band.LowestWavelength, band.HighestWavelength);

    //public static implicit operator (Frequency low, Frequency high)(SpectralBand band) => (band.LowestFrequency, band.HighestFrequency);

    // TODO : complement operator
}

public record Spectrum
    : SpectralBand
{
    protected readonly Func<Frequency, double> _fintensity;
    protected readonly Func<Wavelength, double> _wintensity;

    #region STATIC PROPERTIES

    public static Spectrum CIE_ChromaticResponseX { get; } = VisibleSpectralBand * ((Wavelength λ) => 1.056 * PiecewiseGaussian(λ, 599.8, 0.0264, 0.0323)
                                                                                                    + 0.362 * PiecewiseGaussian(λ, 442.0, 0.0264, 0.0374)
                                                                                                    - 0.065 * PiecewiseGaussian(λ, 501.1, 0.0490, 0.0382));

    public static Spectrum CIE_ChromaticResponseY { get; } = VisibleSpectralBand * ((Wavelength λ) => 0.821 * PiecewiseGaussian(λ, 568.8, 0.0213, 0.0247)
                                                                                                    + 0.286 * PiecewiseGaussian(λ, 530.9, 0.0613, 0.0322));

    public static Spectrum CIE_ChromaticResponseZ { get; } = VisibleSpectralBand * ((Wavelength λ) => 1.217 * PiecewiseGaussian(λ, 437.0, 0.0845, 0.0278)
                                                                                                    + 0.861 * PiecewiseGaussian(λ, 459.0, 0.0385, 0.0275));

    #endregion
    #region INSTANCE PROPERTIES

    public Spectrum? VisibleSubSpectrum => Intersect(VisibleSpectralBand) is { } band ? Create(band, _wintensity) : null;

    public virtual double this[Frequency frequency] => frequency < LowestFrequency || frequency > HighestFrequency ? 0 : _fintensity(frequency);

    public virtual double this[Wavelength wavelength] => wavelength < LowestWavelength || wavelength > HighestWavelength ? 0 : _wintensity(wavelength);

    public override Spectrum? this[SpectralBand band] => this[band.LowestWavelength, band.HighestWavelength];

    public override Spectrum? this[Frequency low, Frequency high] => Overlaps((low, high)) ? new(low, high, _fintensity) : null;

    public override Spectrum? this[Wavelength low, Wavelength high] => Overlaps((low, high)) ? new(low, high, _wintensity) : null;

    #endregion
    #region INSTANCE METHODS

    public Spectrum(Wavelength wavelength, double intensity)
        : this(wavelength, wavelength, _ => intensity)
    {
    }

    public Spectrum(Frequency frequency, double intensity)
        : this(frequency, frequency, _ => intensity)
    {
    }

    public Spectrum(SpectralBand band, Func<Wavelength, double> intensities)
        : this(band.LowestWavelength, band.HighestWavelength, intensities)
    {
    }

    public Spectrum(SpectralBand band, Func<Frequency, double> intensities)
        : this(band.LowestFrequency, band.HighestFrequency, intensities)
    {
    }

    public Spectrum(Wavelength low, Wavelength high, Func<Wavelength, double> intensities)
        : base(low, high)
    {
        _wintensity = λ => double.Max(0, intensities(λ));
        _fintensity = f => double.Max(0, intensities(f.ComputeWavelength()));
    }

    public Spectrum(Frequency low, Frequency high, Func<Frequency, double> intensities)
        : base(low, high)
    {
        _fintensity = f => double.Max(0, intensities(f));
        _wintensity = λ => double.Max(0, intensities(λ.ComputeFrequency()));
    }

    public override string ToString() => $"Spectrum{base.ToString()}";

    public double GetIntensityAt(double lerp)
    {
        if (lerp < 0 || lerp > 1)
            throw new ArgumentOutOfRangeException(nameof(lerp), "The interpolation factor must be in the range [0, 1].");

        return _wintensity(GetWavelengthAt(lerp));
    }

    public double GetIntensity(Frequency frequency) => this[frequency];

    public double GetIntensity(Wavelength wavelength) => this[wavelength];

    public virtual Spectrum Invert(double base_intensity) => new(Wavelength.Zero, double.PositiveInfinity.Nanometer(), λ => base_intensity - _wintensity(λ));

    public virtual Spectrum Add(Spectrum other)
    {
        if (other is DisjointSpectrum disjoint)
            return disjoint.Add(this);

        SpectralBand band = Union(this, other);

        return new(band, (Wavelength f) => GetIntensity(f) + other.GetIntensity(f));
    }

    public virtual Spectrum Subtract(Spectrum other)
    {
        if (other is DisjointSpectrum disjoint)
            return disjoint.Subtract(this);

        SpectralBand band = Union(this, other);

        return new(band, (Wavelength f) => GetIntensity(f) - other.GetIntensity(f));
    }

    public virtual Spectrum Max(Spectrum other)
    {
        if (other is DisjointSpectrum disjoint)
            return disjoint.Max(this);

        SpectralBand band = Union(this, other);

        return new(band, (Wavelength f) => GetIntensity(f) + other.GetIntensity(f));
    }

    public virtual Spectrum Min(Spectrum other)
    {
        if (other is DisjointSpectrum disjoint)
            return disjoint.Min(this);

        SpectralBand band = Union(this, other);

        return new(band, (Wavelength f) => GetIntensity(f) + other.GetIntensity(f));
    }

    public virtual Spectrum? Multiply(Spectrum other)
    {
        if (other is DisjointSpectrum disjoint)
            return disjoint.Multiply(this);

        SpectralBand? bounds = Intersect(this, other);

        return bounds is null ? null : new(bounds.LowestWavelength, bounds.HighestWavelength, f => GetIntensity(f) * other.GetIntensity(f));
    }

    public virtual Spectrum AmplifyIntensity(double factor) => new(LowestWavelength, HighestWavelength, λ => _wintensity(λ) * factor);

    public virtual Spectrum ShiftIntensity(double offset) => new(LowestWavelength, HighestWavelength, λ => _wintensity(λ) + offset);

    public virtual Spectrum ShiftLowerBound(Wavelength wavelength) => new(LowestWavelength + wavelength, HighestWavelength, _wintensity);

    public virtual Spectrum ShiftLowerBound(Frequency frequency) => new(LowestFrequency + frequency, HighestFrequency, _fintensity);

    public virtual Spectrum ShiftUpperBound(Wavelength wavelength) => new(LowestWavelength, HighestWavelength + wavelength, _wintensity);

    public virtual Spectrum ShiftUpperBound(Frequency frequency) => new(LowestFrequency, HighestFrequency + frequency, _fintensity);

    public virtual Spectrum ShiftSpectrumBy(Wavelength wavelength) => new(LowestWavelength + wavelength, HighestWavelength + wavelength, λ => _wintensity(λ + wavelength));

    public virtual Spectrum ShiftSpectrumBy(Frequency frequency) => new(LowestFrequency + frequency, HighestFrequency + frequency, f => _fintensity(f + frequency));

    public Spectrum? Intersect(Spectrum other)
    {
        Wavelength lo = Wavelength.Max(LowestWavelength, other.LowestWavelength);
        Wavelength hi = Wavelength.Min(HighestWavelength, other.HighestWavelength);

        return lo < hi ? new Spectrum(lo, hi, λ => _wintensity(λ) * other._wintensity(λ)) : null;
    }

    public DisjointSpectrum Union(Spectrum other) => DisjointSpectrum.CreateFromSpectra([this, other]);

    public DisjointSpectrum Xor(Spectrum other)
    {
        IEnumerable<SpectralBand> spectra = [this, other];
        SpectralBand union = Union(other);

        if (Intersect(other) is { } intersection)
            spectra = [new(union.LowestWavelength, intersection.LowestWavelength), new(intersection.HighestWavelength, union.HighestWavelength)];
        else if (Adjoins(other))
            spectra = [union];

        return DisjointSpectrum.CreateFromBands(spectra, λ => _wintensity(λ) + other._wintensity(λ)); // TODO: check whether lambda function is correct
    }

    public new DisjointSpectrum Except(SpectralBand other) => DisjointSpectrum.CreateFromBands(base.Except(other), _wintensity);

    #endregion
    #region STATIC METHODS

    public static DisjointSpectrum Union(IEnumerable<Spectrum> spectra)
    {
        List<Spectrum> result = [];

        if (spectra.FirstOrDefault() is { } first)
        {
            result.Add(first);

            foreach (Spectrum input in spectra.Skip(1))
            {
                int i = 0;

                for (; 0 < result.Count; ++i)
                    if (input != result[i] && input.Overlaps(result[i]))
                    {
                        result[i] = Union(input, result[i]);

                        break;
                    }

                if (i == result.Count)
                    result.Add(input);
            }
        }

        return DisjointSpectrum.CreateFromSpectra([..result]);
    }

    public static DisjointSpectrum Union(Spectrum first, Spectrum second) => first.Union(second);

    public static Spectrum? Intersect(Spectrum first, Spectrum second) => first.Intersect(second);

    public static DisjointSpectrum Except(Spectrum first, SpectralBand second) => first.Except(second);

    public static DisjointSpectrum Xor(Spectrum first, Spectrum second) => first.Xor(second);

    public static Spectrum CreateConstant(Wavelength wavelength, double intensity = 1) => CreateConstant(wavelength, wavelength, intensity);

    public static Spectrum CreateConstant(Frequency frequency, double intensity = 1) => CreateConstant(frequency, frequency, intensity);

    public static Spectrum CreateConstant(SpectralBand band, double intensity = 1) => Create(band, (Wavelength _) => intensity);

    public static Spectrum CreateConstant(Wavelength low, Wavelength high, double intensity = 1) => Create(low, high, _ => intensity);

    public static Spectrum CreateConstant(Frequency low, Frequency high, double intensity = 1) => Create(low, high, _ => intensity);

    public static Spectrum Create(SpectralBand band, Func<Wavelength, double> intensities) => Create(band.LowestWavelength, band.HighestWavelength, intensities);

    public static Spectrum Create(SpectralBand band, Func<Frequency, double> intensities) => Create(band.LowestFrequency, band.HighestFrequency, intensities);

    public static Spectrum Create(Wavelength low, Wavelength high, Func<Wavelength, double> intensities) => new(low, high, intensities);

    public static Spectrum Create(Frequency low, Frequency high, Func<Frequency, double> intensities) => new(low, high, intensities);

    #endregion
    #region OPERATORS

    public static implicit operator Func<Frequency, double>(Spectrum spectrum) => spectrum._fintensity;

    public static implicit operator Func<Wavelength, double>(Spectrum spectrum) => spectrum._wintensity;

    public static Spectrum operator +(Spectrum spectrum) => spectrum;

    public static Spectrum operator +(Spectrum first, Spectrum second) => first.Add(second);

    public static Spectrum operator -(Spectrum first, Spectrum second) => first.Subtract(second);

    public static Spectrum operator +(double shift, Spectrum spectrum) => spectrum.ShiftIntensity(shift);

    public static Spectrum operator +(Spectrum spectrum, double shift) => spectrum.ShiftIntensity(shift);

    public static Spectrum operator -(double base_intensity, Spectrum spectrum) => spectrum.Invert(base_intensity);

    public static Spectrum operator -(Spectrum spectrum, double shift) => spectrum.ShiftIntensity(-shift);

    public static Spectrum operator *(Spectrum spectrum, double factor) => spectrum.AmplifyIntensity(factor);

    public static Spectrum operator *(double factor, Spectrum spectrum) => spectrum.AmplifyIntensity(factor);

    public static Spectrum operator /(Spectrum spectrum, double factor) => spectrum.AmplifyIntensity(1d / factor);

    public static Spectrum operator >>(Spectrum spectrum, Wavelength wavelength) => spectrum.ShiftSpectrumBy(wavelength);

    public static Spectrum operator <<(Spectrum spectrum, Wavelength wavelength) => spectrum.ShiftSpectrumBy(-wavelength);

    public static Spectrum operator >>(Spectrum spectrum, Frequency frequency) => spectrum.ShiftSpectrumBy(frequency);

    public static Spectrum operator <<(Spectrum spectrum, Frequency frequency) => spectrum.ShiftSpectrumBy(-frequency);

    #endregion

    internal static double PiecewiseGaussian(Wavelength λ, double μ, double τ1, double τ2)
    {
        double x = λ.value.Value;
        double τ = x < μ ? τ1 : τ2;

        τ *= x - μ;

        return double.Exp(-τ * τ * .5);
    }
}

public record DisjointSpectrum
    : Spectrum
{
    internal readonly SpectralBand[] _spectral_bands;

    #region INSTANCE PROPERTIES

    public override double this[Frequency frequency]
    {
        get
        {
            if (frequency >= LowestFrequency && frequency <= HighestFrequency && _spectral_bands.Any(band => band.Contains(frequency)))
                return _fintensity(frequency);
            else
                return 0;
        }
    }

    public override double this[Wavelength wavelength]
    {
        get
        {
            if (wavelength >= LowestWavelength && wavelength <= HighestWavelength && _spectral_bands.Any(band => band.Contains(wavelength)))
                return _wintensity(wavelength);
            else
                return 0;
        }
    }

    public override DisjointSpectrum? this[SpectralBand band] => this[band.LowestWavelength, band.HighestWavelength];

    public override DisjointSpectrum? this[Frequency low, Frequency high] => Clamp(low, high);

    public override DisjointSpectrum? this[Wavelength low, Wavelength high] => Clamp(low, high);

    public virtual bool HasSpectralLines => IsSpectralLine || _spectral_bands.Any(b => b.IsSpectralLine);

    public virtual bool HasContinuousSpectrum => !IsSpectralLine && _spectral_bands.Any(b => !b.IsSpectralLine);

    public virtual bool IsContinuousSpectrum => !IsSpectralLine && !_spectral_bands.Any(b => b.IsSpectralLine);

    public virtual bool HasDisjointSpectra => _spectral_bands.Length > 1;

    public override bool IsFullyVisible => _spectral_bands.All(b => b.IsFullyVisible);

    public override bool IsPartiallyVisible => _spectral_bands.Any(b => b.IsPartiallyVisible);

    public SpectralBand[] SpectralBands => _spectral_bands;

    public Spectrum[] Spectra => _spectral_bands.Select(b => new Spectrum(b, _wintensity)).ToArray();

    #endregion
    #region INSTANCE METHODS

    private protected DisjointSpectrum(SpectralBand[] bands, Frequency low, Frequency high, Func<Frequency, double> intensities)
        : base(low, high, intensities) => _spectral_bands = Clamp(bands, low, high);

    private protected DisjointSpectrum(SpectralBand[] bands, Wavelength low, Wavelength high, Func<Wavelength, double> intensities)
        : base(low, high, intensities) => _spectral_bands = Clamp(bands, low, high);

    public override string ToString() => $"Spectrum({string.Join(", ", _spectral_bands as IEnumerable<SpectralBand>)})";

    public override DisjointSpectrum Invert(double base_intensity)
    {
        Wavelength lo = Wavelength.Zero;
        Wavelength hi = double.PositiveInfinity.Nanometer();

        return new([(lo, hi)], lo, hi, λ => base_intensity - _wintensity(λ));
    }

    public override DisjointSpectrum Add(Spectrum other)
    {
        IEnumerable<SpectralBand> bands = Union(_spectral_bands.Append(other));

        return CreateFromBands(bands, (Wavelength λ) => GetIntensity(λ) + other.GetIntensity(λ));
    }

    public override DisjointSpectrum Subtract(Spectrum other)
    {
        IEnumerable<SpectralBand> bands = Union(_spectral_bands.Append(other));

        return CreateFromBands(bands, (Wavelength λ) => GetIntensity(λ) - other.GetIntensity(λ));
    }

    public override DisjointSpectrum Max(Spectrum other)
    {
        IEnumerable<SpectralBand> bands = Union(_spectral_bands.Append(other));

        return CreateFromBands(bands, (Wavelength λ) => Math.Max(GetIntensity(λ), other.GetIntensity(λ)));
    }

    public override DisjointSpectrum Min(Spectrum other)
    {
        IEnumerable<SpectralBand> bands = Union(_spectral_bands.Append(other));

        return CreateFromBands(bands, (Wavelength λ) => Math.Min(GetIntensity(λ), other.GetIntensity(λ)));
    }

    public override DisjointSpectrum Multiply(Spectrum other)
    {
        IEnumerable<SpectralBand> bands = Union(_spectral_bands.Append(other));

        return CreateFromBands(bands, (Wavelength λ) => GetIntensity(λ) * other.GetIntensity(λ));
    }

    public override DisjointSpectrum AmplifyIntensity(double factor) => new(_spectral_bands, LowestWavelength, HighestWavelength, λ => _wintensity(λ) * factor);

    public override DisjointSpectrum ShiftIntensity(double offset) => new(_spectral_bands, LowestWavelength, HighestWavelength, λ => _wintensity(λ) + offset);

    public override DisjointSpectrum ShiftLowerBound(Wavelength wavelength) => new(_spectral_bands, LowestWavelength + wavelength, HighestWavelength, _wintensity);

    public override DisjointSpectrum ShiftLowerBound(Frequency frequency) => new(_spectral_bands, LowestFrequency + frequency, HighestFrequency, _fintensity);

    public override DisjointSpectrum ShiftUpperBound(Wavelength wavelength) => new(_spectral_bands, LowestWavelength, HighestWavelength + wavelength, _wintensity);

    public override DisjointSpectrum ShiftUpperBound(Frequency frequency) => new(_spectral_bands, LowestFrequency, HighestFrequency + frequency, _fintensity);

    public override DisjointSpectrum ShiftSpectrumBy(Wavelength wavelength) => new(_spectral_bands, LowestWavelength + wavelength, HighestWavelength + wavelength, λ => _wintensity(λ + wavelength));

    public override DisjointSpectrum ShiftSpectrumBy(Frequency frequency) => new(_spectral_bands, LowestFrequency + frequency, HighestFrequency + frequency, f => _fintensity(f + frequency));

    public DisjointSpectrum? Intersect(DisjointSpectrum other)
    {
        SpectralBand[] bands = Union(from b1 in _spectral_bands
                                     from b2 in other._spectral_bands
                                     let result = b1.Intersect(b2)
                                     where result is { }
                                     select result);

        return CreateFromBands(bands, (Wavelength λ) => bands.Any(b => b.Contains(λ)) ? _wintensity(λ) * other._wintensity(λ) : 0);
    }

    public DisjointSpectrum Xor(DisjointSpectrum other)
    {
        SpectralBand[] bands = Union(from b1 in _spectral_bands
                                     from b2 in other._spectral_bands
                                     from band in b1.Xor(b2)
                                     select band);

        return CreateFromBands(bands, (Wavelength λ) => bands.Any(b => b.Contains(λ)) ? _wintensity(λ) + other._wintensity(λ) : 0);
    }

    public virtual DisjointSpectrum? Clamp(Frequency low, Frequency high)
    {
        SpectralBand[] bands = Clamp(_spectral_bands, low, high);

        return bands.Length > 0 ? CreateFromBands(bands, _wintensity) : null;
    }

    public virtual DisjointSpectrum? Clamp(Wavelength low, Wavelength high)
    {
        SpectralBand[] bands = Clamp(_spectral_bands, low, high);

        return bands.Length > 0 ? CreateFromBands(bands, _wintensity) : null;
    }

    #endregion
    #region STATIC METHODS

    public static DisjointSpectrum? Clamp(DisjointSpectrum spectrum, Frequency low, Frequency high) => spectrum.Clamp(low, high);

    public static DisjointSpectrum? Clamp(DisjointSpectrum spectrum, Wavelength low, Wavelength high) => spectrum.Clamp(low, high);

    public static new DisjointSpectrum CreateConstant(Wavelength wavelength, double intensity = 1) => CreateConstant(wavelength, wavelength, intensity);

    public static new DisjointSpectrum CreateConstant(Frequency frequency, double intensity = 1) => CreateConstant(frequency, frequency, intensity);

    public static new DisjointSpectrum CreateConstant(Wavelength low, Wavelength high, double intensity = 1) => Create(low, high, _ => intensity);

    public static new DisjointSpectrum CreateConstant(Frequency low, Frequency high, double intensity = 1) => Create(low, high, _ => intensity);

    public static new DisjointSpectrum CreateConstant(SpectralBand band, double intensity = 1) => Create(band, (Wavelength _) => intensity);

    public static new DisjointSpectrum Create(Wavelength low, Wavelength high, Func<Wavelength, double> intensities) => Create(new(low, high), intensities);

    public static new DisjointSpectrum Create(Frequency low, Frequency high, Func<Frequency, double> intensities) => Create(new(low, high), intensities);

    public static new DisjointSpectrum Create(SpectralBand band, Func<Wavelength, double> intensities) => CreateFromBands([band], intensities);

    public static new DisjointSpectrum Create(SpectralBand band, Func<Frequency, double> intensities) => CreateFromBands([band], intensities);

    public static DisjointSpectrum CreateEmissionSpectrum(IEnumerable<Wavelength> wavelengths, double intensity = 1) => CreateFromBands(wavelengths.Select(λ => (SpectralBand)λ), intensity);

    public static DisjointSpectrum CreateEmissionSpectrum(IEnumerable<Frequency> frequencies, double intensity = 1) => CreateFromBands(frequencies.Select(f => (SpectralBand)f), intensity);

    public static DisjointSpectrum CreateEmissionSpectrum(IDictionary<Wavelength, double> intensities) =>
        CreateFromBands(intensities.Select(kvp => (SpectralBand)kvp.Key), (Wavelength λ) => intensities.TryGetValue(λ, out double d) ? d : 0);

    public static DisjointSpectrum CreateEmissionSpectrum(IDictionary<Frequency, double> intensities) =>
        CreateFromBands(intensities.Select(kvp => (SpectralBand)kvp.Key), (Frequency f) => intensities.TryGetValue(f, out double d) ? d : 0);

    public static DisjointSpectrum CreateAbsorptionSpectrum(Spectrum @base, IEnumerable<Wavelength> absorptions, double absorption_intensity = 1) =>
        @base - CreateEmissionSpectrum(absorptions, absorption_intensity);

    public static DisjointSpectrum CreateAbsorptionSpectrum(Spectrum @base, IEnumerable<Frequency> absorptions, double absorption_intensity = 1) =>
        @base - CreateEmissionSpectrum(absorptions, absorption_intensity);

    public static DisjointSpectrum CreateFromSpectra(IEnumerable<Spectrum> spectra) =>
        CreateFromBands(spectra, (Wavelength λ) => spectra.Sum(b => b.GetIntensity(λ)));

    public static DisjointSpectrum CreateFromBands(IEnumerable<SpectralBand> bands, double intensity) => CreateFromBands(bands, (Wavelength _) => intensity);

    public static DisjointSpectrum CreateFromBands(IEnumerable<SpectralBand> bands, Func<Wavelength, double> intensities)
    {
        SpectralBand[] result = Union(bands.SelectMany(s => (s as DisjointSpectrum)?._spectral_bands ?? [s]));
        SpectralBand band = GetBounds(result) ?? throw new ArgumentException("No spectral bands provided.", nameof(bands));

        return new DisjointSpectrum(result, band.LowestWavelength, band.HighestWavelength, intensities);
    }

    public static DisjointSpectrum CreateFromBands(IEnumerable<SpectralBand> bands, Func<Frequency, double> intensities)
    {
        SpectralBand[] result = Union(bands.SelectMany(s => (s as DisjointSpectrum)?._spectral_bands ?? [s]));
        SpectralBand band = GetBounds(result) ?? throw new ArgumentException("No spectral bands provided.", nameof(bands));

        return new DisjointSpectrum(result, band.LowestFrequency, band.HighestFrequency, intensities);
    }

    #endregion
    #region OPERATORS

    public static DisjointSpectrum operator +(DisjointSpectrum spectrum) => spectrum;

    public static DisjointSpectrum operator +(DisjointSpectrum first, Spectrum second) => first.Add(second);

    public static DisjointSpectrum operator +(Spectrum first, DisjointSpectrum second) => second.Add(first);

    public static DisjointSpectrum operator -(DisjointSpectrum first, Spectrum second) => first.Subtract(second);

    public static DisjointSpectrum operator -(Spectrum first, DisjointSpectrum second) => CreateFromSpectra([first]).Subtract(second);

    public static DisjointSpectrum operator +(double shift, DisjointSpectrum spectrum) => spectrum.ShiftIntensity(shift);

    public static DisjointSpectrum operator +(DisjointSpectrum spectrum, double shift) => spectrum.ShiftIntensity(shift);

    public static DisjointSpectrum operator -(double base_intensity, DisjointSpectrum spectrum) => spectrum.Invert(base_intensity);

    public static DisjointSpectrum operator -(DisjointSpectrum spectrum, double shift) => spectrum.ShiftIntensity(-shift);

    public static DisjointSpectrum operator *(DisjointSpectrum spectrum, double factor) => spectrum.AmplifyIntensity(factor);

    public static DisjointSpectrum operator *(double factor, DisjointSpectrum spectrum) => spectrum.AmplifyIntensity(factor);

    public static DisjointSpectrum operator /(DisjointSpectrum spectrum, double factor) => spectrum.AmplifyIntensity(1d / factor);

    public static DisjointSpectrum operator >>(DisjointSpectrum spectrum, Wavelength wavelength) => spectrum.ShiftSpectrumBy(wavelength);

    public static DisjointSpectrum operator <<(DisjointSpectrum spectrum, Wavelength wavelength) => spectrum.ShiftSpectrumBy(-wavelength);

    public static DisjointSpectrum operator >>(DisjointSpectrum spectrum, Frequency frequency) => spectrum.ShiftSpectrumBy(frequency);

    public static DisjointSpectrum operator <<(DisjointSpectrum spectrum, Frequency frequency) => spectrum.ShiftSpectrumBy(-frequency);

    #endregion
}

public record SparseSpectrum
    : DisjointSpectrum
{
    private readonly IDictionary<Wavelength, double> _intensities;

    #region INSTANCE PROPERTIES

    public override double this[Frequency frequency] => this[frequency.ComputeWavelength()];

    public override double this[Wavelength wavelength] => _intensities.TryGetValue(wavelength, out double intensity) ? intensity : 0;

    public override SparseSpectrum? this[SpectralBand band] => this[band.LowestWavelength, band.HighestWavelength];

    public override SparseSpectrum? this[Frequency low, Frequency high] => Clamp(low, high);

    public override SparseSpectrum? this[Wavelength low, Wavelength high] => Clamp(low, high);

    public override bool HasSpectralLines => _intensities.Count > 0;

    public override bool HasContinuousSpectrum => false;

    public override bool IsContinuousSpectrum => false;

    public override bool HasDisjointSpectra => _intensities.Count > 1;

    public Wavelength[] SpectralLines => [.. _intensities.Keys];

    public (Wavelength Wavelength, double Intensity)[] Intensities => _intensities.Select(kvp => (kvp.Key, kvp.Value)).ToArray();

    #endregion
    #region INSTANCE METHODS

    public SparseSpectrum(IDictionary<Frequency, double> intensities)
        : this(intensities.Select(kvp => (kvp.Key.ComputeWavelength(), kvp.Value)))
    {
    }

    public SparseSpectrum(IDictionary<Wavelength, double> intensities)
        : this(intensities.Select(kvp => (kvp.Key, kvp.Value)))
    {
    }

    public SparseSpectrum(IEnumerable<(Frequency Frequency, double Intensity)> intensities)
        : this(intensities.Select(t => (t.Frequency.ComputeWavelength(), t.Intensity)))
    {
    }

    public SparseSpectrum(IEnumerable<(Wavelength Wavelength, double Intensity)> intensities)
        : this(intensities.Where(t => t.Intensity > 0).ToDictionary() is { Count: > 0 } arr ? arr : throw new ArgumentException("The spectrum must have at least one spectral line with an intensity greater than zero.", nameof(intensities)), null)
    {
    }

    private SparseSpectrum(IDictionary<Wavelength, double> intensities, object? _/*dummy parameter*/)
        : base(
            [.. intensities.Keys.Select(t => (SpectralBand)t)],
            intensities.Keys.Min()!,
            intensities.Keys.Max()!,
            λ => intensities.TryGetValue(λ, out double d) ? d : 0
        ) => _intensities = intensities;

    public override SparseSpectrum Invert(double base_intensity) => new(_intensities.ToDictionary(kvp => kvp.Key, kvp => base_intensity - kvp.Value));

    public SparseSpectrum Normalize() => AmplifyIntensity(1 / _intensities.Values.Max());

    public SparseSpectrum NormalizeVisible()
    {
        double max = 0;

        foreach ((Wavelength λ, double intensity) in _intensities)
            if (VisibleSpectralBand.Contains(λ))
                max = Math.Max(max, intensity);

        return max is 0 or 1 ? this : AmplifyIntensity(1 / max);
    }

    public SparseSpectrum? ToVisibleSpectrum() => this[VisibleSpectralBand];

    public SparseSpectrum Add(SparseSpectrum other)
    {
        Dictionary<Wavelength, double> intensities = new(_intensities);

        foreach ((Wavelength λ, double intensity) in other._intensities)
            intensities[λ] = intensities.TryGetValue(λ, out double d) ? d + intensity : intensity;

        return new(intensities);
    }

    public SparseSpectrum Subtract(SparseSpectrum other)
    {
        Dictionary<Wavelength, double> intensities = new(_intensities);

        foreach ((Wavelength λ, double intensity) in other._intensities)
            if (intensities.TryGetValue(λ, out double d))
                intensities[λ] = Math.Max(d - intensity, 0);

        return new(intensities);
    }

    public SparseSpectrum Max(SparseSpectrum other)
    {
        Dictionary<Wavelength, double> intensities = new(_intensities);

        foreach ((Wavelength λ, double intensity) in other._intensities)
            intensities[λ] = intensities.TryGetValue(λ, out double d) ? Math.Max(d, intensity) : intensity;

        return new(intensities);
    }

    public SparseSpectrum Min(SparseSpectrum other)
    {
        Dictionary<Wavelength, double> intensities = new(_intensities);

        foreach ((Wavelength λ, double intensity) in other._intensities)
            intensities[λ] = intensities.TryGetValue(λ, out double d) ? Math.Min(d, intensity) : intensity;

        return new(intensities);
    }

    public SparseSpectrum Multiply(SparseSpectrum other)
    {
        Dictionary<Wavelength, double> intensities = [];

        foreach ((Wavelength λ, double intensity) in _intensities)
            if (other._intensities.TryGetValue(λ, out double d))
                intensities[λ] = intensity * d;

        return new(intensities);
    }

    public override SparseSpectrum AmplifyIntensity(double factor) => new(_intensities.ToDictionary(kvp => kvp.Key, kvp => kvp.Value * factor));

    public override SparseSpectrum ShiftIntensity(double offset) => new(_intensities.ToDictionary(kvp => kvp.Key, kvp => kvp.Value + offset));

    public override SparseSpectrum ShiftSpectrumBy(Wavelength wavelength) => new(_intensities.ToDictionary(kvp => kvp.Key + wavelength, kvp => kvp.Value));

    public override SparseSpectrum ShiftSpectrumBy(Frequency frequency) => ShiftSpectrumBy(frequency.ComputeWavelength());

    public SparseSpectrum? Intersect(SparseSpectrum other)
    {
        IEnumerable<(Wavelength Key, double)> intensities = from kvp1 in _intensities
                                                            from kvp2 in other._intensities
                                                            where kvp1.Key == kvp2.Key
                                                            select (kvp1.Key, kvp1.Value + kvp2.Value);

        return intensities.Any() ? new(intensities.ToDictionary()) : null;
    }

    public SparseSpectrum Xor(SparseSpectrum other)
    {
        Dictionary<Wavelength, double> intensities = new(_intensities);

        foreach ((Wavelength λ, double intensity) in other._intensities)
            if (!intensities.Remove(λ))
                intensities[λ] = intensity;

        return new(intensities);
    }

    public override SparseSpectrum? Clamp(Frequency low, Frequency high) => Clamp(low.ComputeWavelength(), high.ComputeWavelength());

    public override SparseSpectrum? Clamp(Wavelength low, Wavelength high)
    {
        Dictionary<Wavelength, double> intensities = [];

        foreach ((Wavelength λ, double d) in _intensities)
            if (λ >= low && λ <= high)
                intensities[λ] = d;

        return intensities.Count != 0 ? new(intensities) : null;
    }

    #endregion
    #region STATIC METHODS

    public static SparseSpectrum? Clamp(SparseSpectrum spectrum, Frequency low, Frequency high) => spectrum.Clamp(low, high);

    public static SparseSpectrum? Clamp(SparseSpectrum spectrum, Wavelength low, Wavelength high) => spectrum.Clamp(low, high);

    public static SparseSpectrum Create(Wavelength wavelength, double intensity = 1) => Create([wavelength], intensity);

    public static SparseSpectrum Create(Frequency frequency, double intensity = 1) => Create([frequency], intensity);

    public static SparseSpectrum Create(IEnumerable<Wavelength> wavelengths, double intensity = 1) => Create(wavelengths.ToDictionary(λ => λ, _ => intensity));

    public static SparseSpectrum Create(IEnumerable<Frequency> frequencies, double intensity = 1) => Create(frequencies.ToDictionary(f => f, _ => intensity));

    public static SparseSpectrum Create(IDictionary<Wavelength, double> intensities) => new(intensities);

    public static SparseSpectrum Create(IDictionary<Frequency, double> intensities) => new(intensities);

    public static SparseSpectrum Create(IEnumerable<(Frequency Frequency, double Intensity)> intensities) => new(intensities);

    public static SparseSpectrum Create(IEnumerable<(Wavelength Wavelength, double Intensity)> intensities) => new(intensities);

    #endregion
    #region OPERATORS

    public static implicit operator SparseSpectrum((Wavelength Wavelength, double Intensity)[] intensities) => new(intensities as IEnumerable<(Wavelength, double)>);

    public static implicit operator SparseSpectrum((Frequency Frequency, double Intensity)[] intensities) => new(intensities as IEnumerable<(Frequency, double)>);

    public static SparseSpectrum operator +(SparseSpectrum first, SparseSpectrum second) => first.Add(second);

    public static SparseSpectrum operator -(SparseSpectrum first, SparseSpectrum second) => first.Subtract(second);

    public static SparseSpectrum operator *(SparseSpectrum first, SparseSpectrum second) => first.Multiply(second);

    public static SparseSpectrum operator +(SparseSpectrum spectrum, double shift) => spectrum.ShiftIntensity(shift);

    public static SparseSpectrum operator +(double shift, SparseSpectrum spectrum) => spectrum.ShiftIntensity(shift);

    public static SparseSpectrum operator -(SparseSpectrum spectrum, double shift) => spectrum.ShiftIntensity(-shift);

    public static SparseSpectrum operator *(SparseSpectrum spectrum, double factor) => spectrum.AmplifyIntensity(factor);

    public static SparseSpectrum operator *(double factor, SparseSpectrum spectrum) => spectrum.AmplifyIntensity(factor);

    public static SparseSpectrum operator /(SparseSpectrum spectrum, double factor) => spectrum.AmplifyIntensity(1d / factor);

    public static SparseSpectrum operator >>(SparseSpectrum spectrum, Wavelength wavelength) => spectrum.ShiftSpectrumBy(wavelength);

    public static SparseSpectrum operator <<(SparseSpectrum spectrum, Wavelength wavelength) => spectrum.ShiftSpectrumBy(-wavelength);

    public static SparseSpectrum operator >>(SparseSpectrum spectrum, Frequency frequency) => spectrum.ShiftSpectrumBy(frequency);

    public static SparseSpectrum operator <<(SparseSpectrum spectrum, Frequency frequency) => spectrum.ShiftSpectrumBy(-frequency);

    #endregion
}

// TODO : eye response spectrum
// TODO : simulate color blindness transformations
//      - protanopia
//      - deuteranopia
//      - tritanopia
//      - protanomaly
//      - deutanomaly
//      - tritanomaly



#if false // TODO : check if we need to implement any of the following code

class SparseSpectrum
{
    public HDRColor ToVisibleColor() => ToVisibleColor(1);

    public HDRColor ToVisibleColor(double α) => ToVisibleColor(Wavelength.LowestVisibleWavelength, Wavelength.HighestVisibleWavelength, 0, α);

    public override HDRColor ToVisibleColor(Wavelength lowest, Wavelength highest, double _ignored_, double α)
    {
        if (lowest > highest)
            (lowest, highest) = (highest, lowest);

        HDRColor color = new();

        foreach (KeyValuePair<Wavelength, double> kvp in Intensities)
            if (kvp.Key.IsVisible && kvp.Key >= lowest && kvp.Key <= highest)
                color += kvp.Value * kvp.Key.ToColor();

        return color;
    }

    public ColorPalette ToColorPalette() => new(Intensities.Keys.Select(λ => (RGBAColor)λ.ToColor()));

    public DiscreteColorMap ToColorMap()
    {
        if (Intensities.Keys.OrderBy(λ => λ.InNanometers).ToArray() is { Length: > 0 } wavelengths)
        {
            Scalar min = wavelengths[^1].InNanometers;
            Scalar max = wavelengths[0].InNanometers;

            return new(wavelengths.Select(λ => ((λ.InNanometers - min) / (max - min), (RGBAColor)λ.ToColor())));
        }
        else
            throw new InvalidOperationException("The spectrum must not be empty.");
    }

    public override string ToString() => $"{Intensities.Count} Wavelengths: [{string.Join(", ", Intensities.Select(kvp => $"{kvp.Key.InNanometers}nm:{kvp.Value}"))}]";

    public IEnumerator<(Wavelength Wavelength, double Intensity)> GetEnumerator() => Intensities.Select(kvp => (kvp.Key, kvp.Value)).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


    public static implicit operator ColorPalette(DiscreteSpectrum spectrum) => spectrum.ToColorPalette();

    public static implicit operator DiscreteColorMap(DiscreteSpectrum spectrum) => spectrum.ToColorMap();

    public static implicit operator ContinuousSpectrum(DiscreteSpectrum spectrum) => spectrum.ToContinuous();

    public static implicit operator HDRColor(DiscreteSpectrum spectrum) => spectrum.ToVisibleColor();
}

public abstract partial class __Spectrum
{
    //public virtual ContinuousColorMap ToColorMap(Wavelength lowest, Wavelength highest)
    //{
    //    if (lowest > highest)
    //        (lowest, highest) = (highest, lowest);
    //
    //    double dist = (highest - lowest).InNanometers;
    //
    //    return new(s => GetIntensity(s * dist + lowest.InNanometers));
    //
    //}
    //
    //public ContinuousColorMap ToVisibleColorMap() => ToColorMap(Wavelength.LowestVisibleWavelength, Wavelength.HighestVisibleWavelength);

    public HDRColor ToVisibleColor(Wavelength lowest, Wavelength highest, double wavelength_resolution_in_nm) =>
        ToVisibleColor(lowest, highest, wavelength_resolution_in_nm, 1);

    public virtual HDRColor ToVisibleColor(Wavelength lowest, Wavelength highest, double wavelength_resolution_in_nm, double α)
    {
        if (lowest > highest)
            (lowest, highest) = (highest, lowest);

        wavelength_resolution_in_nm = Math.Max(wavelength_resolution_in_nm, Scalar.ComputationalEpsilon);

        HDRColor color = new();

        for (Wavelength nm = lowest; nm <= highest; nm += wavelength_resolution_in_nm)
            if (nm.IsVisible)
                color += GetIntensity(nm) * nm.ToColor();

        return color;
    }
}

public readonly struct __Wavelength
{
    public readonly HDRColor ToColor() => HDRColor.FromWavelength(in this);

    public readonly HDRColor ToColor(double α) => HDRColor.FromWavelength(in this, α);

    public readonly RGBAColor ToRGBAColor() => ToColor();

    public readonly RGBAColor ToRGBAColor(double α) => ToColor(α);


    public static implicit operator HDRColor(Wavelength wavelength) => wavelength.ToColor();

    public static implicit operator RGBAColor(Wavelength wavelength) => wavelength.ToRGBAColor();
}

public class DiscreteSpectrum
    : Spectrum
    , IEnumerable<(Wavelength Wavelength, double Intensity)>
{
    public DiscreteSpectrum ToVisibleSpectrum() => new(Intensities.Where(kvp => kvp.Key.IsVisible).ToDictionary(kvp => kvp.Key, kvp => kvp.Value));

    public HDRColor ToVisibleColor() => ToVisibleColor(1);

    public HDRColor ToVisibleColor(double α) => ToVisibleColor(Wavelength.LowestVisibleWavelength, Wavelength.HighestVisibleWavelength, 0, α);

    public override HDRColor ToVisibleColor(Wavelength lowest, Wavelength highest, double _ignored_, double α)
    {
        if (lowest > highest)
            (lowest, highest) = (highest, lowest);

        HDRColor color = new();

        foreach (KeyValuePair<Wavelength, double> kvp in Intensities)
            if (kvp.Key.IsVisible && kvp.Key >= lowest && kvp.Key <= highest)
                color += kvp.Value * kvp.Key.ToColor();

        return color;
    }

    public ColorPalette ToColorPalette() => new(Intensities.Keys.Select(λ => (RGBAColor)λ.ToColor()));

    public DiscreteColorMap ToColorMap()
    {
        if (Intensities.Keys.OrderBy(λ => λ.InNanometers).ToArray() is { Length: > 0 } wavelengths)
        {
            Scalar min = wavelengths[^1].InNanometers;
            Scalar max = wavelengths[0].InNanometers;

            return new(wavelengths.Select(λ => ((λ.InNanometers - min) / (max - min), (RGBAColor)λ.ToColor())));
        }
        else
            throw new InvalidOperationException("The spectrum must not be empty.");
    }


    public static implicit operator ColorPalette(DiscreteSpectrum spectrum) => spectrum.ToColorPalette();

    public static implicit operator HDRColor(DiscreteSpectrum spectrum) => spectrum.ToVisibleColor();
}

#endif