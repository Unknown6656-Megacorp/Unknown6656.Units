using System.Linq;
using System.Text;
using System;

using Unknown6656.Units.Euclidean;
using Unknown6656.Units;

using Microsoft.Extensions.Primitives;

namespace Unknown6656.Physics.Geography;


public enum LocationFormatting
{
    Compact,
    Short,
    Long,
}

public enum SwissDatum
{
    LV95,
    LV03,
}

public record WGSDatum(string Name, Meter SemiMajorAxis, Meter SemiMinorAxis)
{
    public static WGSDatum WGS84 { get; } = new(nameof(WGS84), 6_378_137.Meter, 6_356_752.314245.Meter);
    public static WGSDatum GRS80 { get; } = new(nameof(GRS80), 6_378_137.Meter, 6_356_752.314140.Meter);
    public static WGSDatum WGS72 { get; } = new(nameof(WGS72), 6_378_135.Meter, 6_356_750.Meter);
    public static WGSDatum WGS66 { get; } = new(nameof(WGS66), 6_378_160.Meter, 6_356_750.Meter);

    public double Flattening { get; } = (SemiMajorAxis - SemiMinorAxis) / SemiMajorAxis;
    public double InverseFlattening { get; } = SemiMajorAxis / (SemiMajorAxis - SemiMinorAxis);
    public double SquareEccentricity => Flattening * (2 - Flattening);

    public override int GetHashCode() => Name.GetHashCode();
}

public abstract record Geolocation
{
    public WGSLocation WGS84 => field ??= ToWGS();

    public ECEFLocation ECEF84 => field ??= ToECEF();

    public SwissMNLocation SwissMN95 => field ??= ToSwissMN(SwissDatum.LV95);

    public virtual UTMLocation UTM84 => field ??= ToUTM();

    public MGRSLocation MGRS84 => field ??= ToMGRS();

    public OpenLocationCode OLC84 => field ??= new(WGS84);


    public WGSLocation ToWGS() => ToWGS(WGSDatum.WGS84);

    public abstract WGSLocation ToWGS(WGSDatum datum);

    public ECEFLocation ToECEF() => ToECEF(WGSDatum.WGS84);

    public virtual ECEFLocation ToECEF(WGSDatum datum) => ToWGS(datum).ToECEF(datum);

    public UTMLocation ToUTM() => ToUTM(WGSDatum.WGS84);

    public virtual UTMLocation ToUTM(WGSDatum datum) => new(ToWGS(datum));

    public MGRSLocation ToMGRS() => ToMGRS(WGSDatum.WGS84);

    public virtual MGRSLocation ToMGRS(WGSDatum datum) => new(ToUTM(datum));

    public virtual SwissMNLocation ToSwissMN(SwissDatum datum = SwissDatum.LV95) => ToWGS(WGSDatum.WGS84).ToSwissMN(datum);

    public virtual Length SurfaceDistanceTo(Geolocation other) => ToWGS(WGSDatum.WGS84).SurfaceDistanceTo(other.ToWGS(WGSDatum.WGS84));

    public virtual Length EucledianDistanceTo(Geolocation other) => ToECEF(WGSDatum.WGS84).EucledianDistanceTo(other.ToECEF(WGSDatum.WGS84));

    public virtual string ToGeoURI() => ToGeoURI(WGSDatum.WGS84);

    public string ToGeoURI(WGSDatum datum) => ToWGS(datum).ToGeoURI();

    public static Degree NormalizeAngle(Angle angle, GeodesicAngleOrientation orientation) => NormalizeAngle(angle.Degree, orientation);

    public static Degree NormalizeAngle(Degree angle, GeodesicAngleOrientation orientation) => NormalizeAngle(angle.Value, orientation).Degree;

    public static double NormalizeAngle(double angle, GeodesicAngleOrientation orientation)
    {
        if (orientation is GeodesicAngleOrientation.Vertical)
            angle = double.Clamp(angle, -90, 90);
        else
        {
            while (angle < -180)
                angle += 360;

            while (angle >= 180)
                angle -= 360;
        }

        return angle;
    }

    public static Length operator -(Geolocation first, Geolocation second) => first.SurfaceDistanceTo(second);
}

// TODO: ED50
// TODO: ETRS89
// TODO: NAD83 / NAVD88
// TODO: GEOREF https://en.wikipedia.org/wiki/World_Geographic_Reference_System
// TODO: ENU coordinates
// TODO: geohash https://en.wikipedia.org/wiki/Geohash
// TODO: https://en.wikipedia.org/wiki/Natural_Area_Code
// TODO: https://en.wikipedia.org/wiki/Helmert_transformation#Application

/// <summary>
/// Represents a geolocation in Earth-Centered, Earth-Fixed (ECEF) coordinates.
/// </summary>
/// <param name="X">The ECEF's X coordinate.</param>
/// <param name="Y">The ECEF's Y coordinate.</param>
/// <param name="Z">The ECEF's Z coordinate.</param>
/// <param name="Datum">The WGS datum.</param>
public record ECEFLocation(Length X, Length Y, Length Z, WGSDatum Datum)
    : Geolocation
{
    public bool IsNorth => Z > Length.Zero;
    public bool IsSouth => Z < Length.Zero;
    public bool IsEquator => Z == Length.Zero;


    public ECEFLocation(Length X, Length Y, Length Z)
        : this(X, Y, Z, WGSDatum.WGS84)
    {
    }

    public ECEFLocation(double X_meters, double Y_meters, double Z_meters)
        : this(X_meters, Y_meters, Z_meters, WGSDatum.WGS84)
    {
    }

    public ECEFLocation(double X_meters, double Y_meters, double Z_meters, WGSDatum datum)
        : this(X_meters.Meter, Y_meters.Meter, Z_meters.Meter, datum)
    {
    }

    public override string ToString() => $"({X}, {Y}, {Z})";

    public override ECEFLocation ToECEF(WGSDatum datum)
    {
        if (datum == Datum)
            return this;

        // TODO: Helmert transformation https://en.wikipedia.org/wiki/Helmert_transformation#Application

        throw new NotImplementedException();
    }

    public override WGSLocation ToWGS(WGSDatum datum)
    {
        if (datum != Datum)
            return ToECEF(datum).ToWGS(datum);

        double a = datum.SemiMajorAxis.Value;
        double b = datum.SemiMinorAxis.Value;
        double X = this.X.Meter.Value;
        double Y = this.Y.Meter.Value;
        double Z = this.Z.Meter.Value;

        double Z2 = Z * Z;
        double a2 = a * a;
        double b2 = b * b;
        double e2 = 1 - b2 / a2;

        double p = Math.Sqrt(X * X + Y * Y);
        double F = 54 * b2 * Z2;
        double G = p * p + (1 - e2) * Z2 - e2 * (a2 - b2);
        double c = (e2 * e2 * F * p * p) / (G * G * G);
        double s = Math.Pow(1 + c + Math.Sqrt(c * c + 2 * c), 1.0 / 3.0);
        double k = s + 1 + 1 / s;
        double P = F / (3 * k * k * G * G);
        double Q = Math.Sqrt(1 + 2 * e2 * e2 * P);
        double r0 = -(P * e2 * p) / (1 + Q) + Math.Sqrt(0.5 * a2 * (1 + 1 / Q) - P * (1 - e2) * Z2 / (Q * (1 + Q)) - 0.5 * P * p * p);
        double U = Math.Sqrt(Math.Pow(p - e2 * r0, 2) + Z2);
        double V = Math.Sqrt(Math.Pow(p - e2 * r0, 2) + (1 - e2) * Z2);
        double z0 = b2 * Z / (a * V);

        double h = U * (1 - b2 / (a * V));
        double lat = Math.Atan((Z + (a2 - b2) / b2 * z0) / p);
        double lon = Math.Atan2(Y, X);

        return new WGSLocation(lat.Radian, lon.Radian, h.Meter, datum);
    }

    public override Length EucledianDistanceTo(Geolocation other)
    {
        ECEFLocation ecef = other.ToECEF(Datum);
        double dx = (X - ecef.X).Meter.Value;
        double dy = (Y - ecef.Y).Meter.Value;
        double dz = (Z - ecef.Z).Meter.Value;

        return Math.Sqrt(dx * dx + dy * dy + dz * dz).Meter;
    }

    public static ECEFLocation operator +(ECEFLocation location) => location;

    public static ECEFLocation operator -(ECEFLocation location) => new(-location.X, -location.Y, -location.Z);

    public static ECEFLocation operator +(ECEFLocation a, ECEFLocation b) => new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

    public static ECEFLocation operator -(ECEFLocation a, ECEFLocation b) => new(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public static ECEFLocation operator *(ECEFLocation location, double scalar) => new(location.X * scalar, location.Y * scalar, location.Z * scalar);

    public static ECEFLocation operator *(double scalar, ECEFLocation location) => new(location.X * scalar, location.Y * scalar, location.Z * scalar);

    public static ECEFLocation operator /(ECEFLocation location, double scalar) => new(location.X / scalar, location.Y / scalar, location.Z / scalar);

    public static ECEFLocation operator %(ECEFLocation location, double scalar) => new(location.X % scalar, location.Y % scalar, location.Z % scalar);

    public static implicit operator ECEFLocation((Length X, Length Y, Length Z) tuple) => new(tuple.X, tuple.Y, tuple.Z);

    public static implicit operator (Length X, Length Y, Length Z)(ECEFLocation location) => (location.X, location.Y, location.Z);

    public static implicit operator ECEFLocation((double X, double Y, double Z) tuple) => new(tuple.X, tuple.Y, tuple.Z);

    public static implicit operator (double X, double Y, double Z)(ECEFLocation location) =>
        (location.X.Meter.Value, location.Y.Meter.Value, location.Z.Meter.Value);
}

/// <summary>
/// Represents a geolocation in World Geodetic System (WGS) coordinates.
/// The default <see cref="Datum"/> is <see cref="WGSDatum.WGS84"/>.
/// </summary>
public record WGSLocation
    : Geolocation
{
    public static WGSLocation NullIsland { get; } = new(0.Degree, 0.Degree, 0.Meter);
    public static WGSLocation NorthPole { get; } = new(90.Degree, 0.Degree, 0.Meter);
    public static WGSLocation SouthPole { get; } = new(-90.Degree, 0.Degree, 0.Meter);


    public Degree Latitude { get; }
    public Degree Longitude { get; }
    public Meter Altitude { get; }
    public WGSDatum Datum { get; }

    // TODO : heading (relative to null island)

    public bool IsNorth => Latitude > Angle.Zero;
    public bool IsSouth => Latitude < Angle.Zero;
    public bool IsEast => Longitude > Angle.Zero;
    public bool IsWest => Longitude < Angle.Zero;
    public bool IsEquator => Latitude == Degree.Zero;
    public bool IsPrimeMeridian => Longitude == Degree.Zero;
    public bool IsAntiMeridian => Math.Abs(Longitude.Value) == 180;
    public bool IsNullIsland => Latitude == Degree.Zero && Longitude == Degree.Zero;
    public bool IsUnderSeaLevel => Altitude < Meter.Zero;
    public bool IsOverSeaLevel => Altitude >= Meter.Zero;


    public WGSLocation(Angle latitude, Angle longitude)
        : this(latitude, longitude, WGSDatum.WGS84)
    {
    }

    public WGSLocation(Angle latitude, Angle longitude, WGSDatum datum)
        : this(latitude, longitude, Meter.Zero, datum)
    {
    }

    public WGSLocation(Angle latitude, Angle longitude, Length altitude)
        : this(latitude, longitude, altitude, WGSDatum.WGS84)
    {
    }

    public WGSLocation(Angle latitude, Angle longitude, Length altitude, WGSDatum datum)
    {
        Datum = datum;
        Altitude = altitude; // TODO : clamp altitude to valid range for datum (esp. inside the Earth)
        Latitude = NormalizeAngle(latitude, GeodesicAngleOrientation.Vertical);
        Longitude = NormalizeAngle(longitude, GeodesicAngleOrientation.Horizontal);
    }

    public override string ToString() => ToString(LocationFormatting.Long);

    public string ToString(LocationFormatting formatting)
    {
        if (formatting is LocationFormatting.Compact)
            return $"{Latitude}, {Longitude}, {Altitude}";
        else
        {
            double lat = Math.Abs(Latitude.Value);
            double lon = Math.Abs(Longitude.Value);
            StringBuilder sb = new();

            if (formatting is LocationFormatting.Long)
                sb.Append(new Degree(lat).ToSexagesimalNotation(GeodesicAngleOrientation.Vertical));
            else
                sb.Append($"{lat}°{(IsNorth ? 'N' : 'S')}");

            sb.Append(", ");

            if (formatting is LocationFormatting.Long)
                sb.Append(new Degree(lon).ToSexagesimalNotation(GeodesicAngleOrientation.Horizontal));
            else
                sb.Append($"{lon}°{(IsEast ? 'E' : 'W')}");

            sb.Append(", ");

            if (formatting is LocationFormatting.Long)
                sb.Append(Unit.Format(Altitude.Value, "m", null, null, UnitDisplay.MetricNoSIPrefixes, SIUnitScale.Base_1000));
            else
                sb.Append(Altitude);

            return sb.ToString();
        }
    }

    public override Length SurfaceDistanceTo(Geolocation other)
    {
        WGSLocation loc = other.ToWGS(Datum);
        double a = Datum.SemiMajorAxis.Value;
        double b = Datum.SemiMinorAxis.Value;
        double f = Datum.Flattening;

        const double tolerance = 1e-11;

        double phi1 = Latitude.Radian.Value,
               phi2 = loc.Latitude.Radian.Value;
        double L1 = Longitude.Radian.Value,
               L2 = loc.Longitude.Radian.Value;
        double L = L2 - L1;
        double lambda_old = L + 0;
        double U1 = Math.Atan((1 - f) * Math.Tan(phi1));
        double U2 = Math.Atan((1 - f) * Math.Tan(phi2));
        double cos_sq_alpha, cos_2sigma_m, sin_sigma, cos_sigma, sigma, t;

        while (true)
        {
            t = Math.Cos(U2) * Math.Sin(lambda_old);
            t *= t;
            t += Math.Pow(Math.Cos(U1) * Math.Sin(U2) -
                          Math.Sin(U1) * Math.Cos(U2) * Math.Cos(lambda_old), 2);

            sin_sigma = Math.Sqrt(t);
            cos_sigma = Math.Sin(U1) * Math.Sin(U2)
                      + Math.Cos(U1) * Math.Cos(U2) * Math.Cos(lambda_old);
            sigma = Math.Atan2(sin_sigma, cos_sigma);

            double sin_alpha = Math.Cos(U1) * Math.Cos(U2) * Math.Sin(lambda_old) / sin_sigma;

            cos_sq_alpha = 1 - sin_alpha * sin_alpha;
            cos_2sigma_m = cos_sigma - 2 * Math.Sin(U1) * Math.Sin(U2) / cos_sq_alpha;

            double C = f * cos_sq_alpha * (4 + f * (4 - 3 * cos_sq_alpha)) / 16;

            t = sigma + C * sin_sigma * (cos_2sigma_m + C * cos_sigma * (-1 + 2 * cos_2sigma_m * cos_2sigma_m));

            double lambda_new = L + (1 - C) * f * sin_alpha * t;

            if (Math.Abs(lambda_new - lambda_old) <= tolerance)
                break;
            else
                lambda_old = lambda_new;
        }

        double u2 = cos_sq_alpha * ((a * a - b * b) / (b * b));
        double A = 1 + u2 / 16384 * (4096 + u2 * (-768 + u2 * (320 - 175 * u2)));
        double B = u2 / 1024 * (256 + u2 * (-128 + u2 * (74 - 47 * u2)));

        t = cos_2sigma_m + 0.25 * B * (cos_sigma * (-1 + 2 * cos_2sigma_m * cos_2sigma_m));
        t -= B / 6 * cos_2sigma_m * (-3 + 4 * sin_sigma * sin_sigma) * (-3 + 4 * cos_2sigma_m * cos_2sigma_m);

        double delta_sigma = B * sin_sigma * t;

        return (b * A * (sigma - delta_sigma)).Meter;
    }

    public override WGSLocation ToWGS(WGSDatum datum) => datum == Datum ? this : ToECEF(datum).ToWGS();

    public override ECEFLocation ToECEF(WGSDatum datum)
    {
        if (datum != Datum)
            return ToECEF(Datum).ToECEF(datum);

        double a = datum.SemiMajorAxis.Value;
        double b = datum.SemiMinorAxis.Value;
        double lat = Latitude.Radian.Value;
        double lon = Longitude.Radian.Value;
        double h = Altitude.Value;
        double e2 = 1 - (b * b) / (a * a);
        double N = a / Math.Sqrt(1 - e2 * Math.Pow(Math.Sin(lat), 2));

        double X = (N + h) * Math.Cos(lat) * Math.Cos(lon);
        double Y = (N + h) * Math.Cos(lat) * Math.Sin(lon);
        double Z = (N * (1 - e2) + h) * Math.Sin(lat);

        return new(X.Meter, Y.Meter, Z.Meter);
    }

    public override SwissMNLocation ToSwissMN(SwissDatum datum = SwissDatum.LV95)
    {
        if (Datum != WGSDatum.WGS84)
            return ToWGS(WGSDatum.WGS84).ToSwissMN(datum);

        static double degree_to_sexagesimal(double angle)
        {
            int deg = (int)angle;
            int min = (int)((angle - deg) * 60);
            double sec = ((angle - deg) * 60 - min) * 60;

            return deg + min / 100.0 + sec / 10000.0;
        }

        static double degree_to_seconds(double angle)
        {
            int deg = (int)angle;
            int min = (int)((angle - deg) * 100);
            double sec = ((angle - deg) * 100 - min) * 100;

            return sec + min * 60 + deg * 3600;
        }

        double lat = degree_to_sexagesimal(Latitude.Value);
        double lon = degree_to_sexagesimal(Longitude.Value);
        double phi = degree_to_seconds(lat);
        double theta = degree_to_seconds(lon);

        phi = (phi - 169028.66) * .0001;
        theta = (theta - 26782.5) * .0001;

        double east = 2600072.37
                    + 211455.93 * theta
                    - 10938.51 * phi * theta
                    - 0.36 * phi * phi * theta
                    - 44.54 * theta * theta * theta;
        double north = 1200147.07
                     + 308807.95 * phi
                     + 76.63 * phi * phi
                     + 119.79 * phi * phi * phi
                     + 3745.25 * theta * theta
                     - 194.56 * phi * theta * theta;
        double h = Altitude.Value
                 - 49.55
                 + 2.73 * phi
                 + 6.94 * theta;

        if (datum == SwissDatum.LV03)
        {
            east -= 2_000_000;
            north -= 1_000_000;
        }

        return new(east.Meter, north.Meter, h.Meter, datum);
    }

    public override string ToGeoURI() => $"geo:{Latitude.Value},{Longitude.Value},{Altitude.Value}";

    public string ToGeoURI(Length uncertainty) => $"geo:{Latitude.Value},{Longitude.Value},{Altitude.Value};u={uncertainty.Meter.Value}";


    public static implicit operator WGSLocation((Degree latitude, Degree longitude) tuple) => new(tuple.latitude, tuple.longitude);

    public static implicit operator WGSLocation((Degree latitude, Degree longitude, Meter altitude) tuple) => new(tuple.latitude, tuple.longitude, tuple.altitude);

    public static implicit operator WGSLocation((double latitude, double longitude) tuple) => new(tuple.latitude.Degree, tuple.longitude.Degree);

    public static implicit operator WGSLocation((double latitude, double longitude, double altitude) tuple) => new(tuple.latitude.Degree, tuple.longitude.Degree, tuple.altitude.Meter);

    public static implicit operator (Degree latitude, Degree longitude)(WGSLocation location) => (location.Latitude, location.Longitude);

    public static implicit operator (Degree latitude, Degree longitude, Meter altitude)(WGSLocation location) => (location.Latitude, location.Longitude, location.Altitude);

    public static implicit operator (double latitude, double longitude)(WGSLocation location) => (location.Latitude.Value, location.Longitude.Value);

    public static implicit operator (double latitude, double longitude, double altitude)(WGSLocation location) => (location.Latitude.Value, location.Longitude.Value, location.Altitude.Value);

    public static implicit operator ECEFLocation(WGSLocation location) => location.ToECEF();

    public static implicit operator SwissMNLocation(WGSLocation location) => location.ToSwissMN();

    public static implicit operator WGSLocation(ECEFLocation location) => location.ToWGS();

    public static implicit operator WGSLocation(SwissMNLocation location) => location.ToWGS();

    // TODO : more implicit conversions
}

public record SwissMNLocation(Meter East, Meter North, Meter Altitude, SwissDatum Datum = SwissDatum.LV95)
    : Geolocation
{
    public static SwissMNLocation Zero { get; } = new(0.Meter, 0.Meter, 0.Meter);
    public static SwissMNLocation ZimmerwaldObservatoryReferencePoint { get; } = new(2_602_030.Meter, 1_191_775.Meter, 898.Meter);
    public static SwissMNLocation BerneUniversityReferencePoint { get; } = new(2_600_000.Meter, 1_200_000.Meter, 554.2.Meter);


    public SwissMNLocation(Meter east, Meter north, SwissDatum datum = SwissDatum.LV95)
        : this(east, north, 0.Meter, datum)
    {
    }

    public override string ToString() => $"E={East.Value}, N={North.Value}, {Altitude}";

    public override WGSLocation ToWGS(WGSDatum datum)
    {
        if (datum != WGSDatum.WGS84)
            return ToWGS(WGSDatum.WGS84).ToWGS(datum);

        double y = East.Value;
        double x = North.Value;

        if (Datum == SwissDatum.LV03)
        {
            y += 2_000_000;
            x += 1_000_000;
        }

        y = (y - 2_600_000) * 1e-6;
        x = (x - 1_200_000) * 1e-6;

        double lat = 16.9023892
                   + 3.238272 * x
                   - 0.270978 * y * y
                   - 0.002528 * x * x
                   - 0.0447 * y * y * x
                   - 0.0140 * x * x * x;
        double lon = 2.6779094
                   + 4.728982 * y
                   + 0.791484 * y * x
                   + 0.1306 * y * x * x
                   - 0.0436 * y * y * y;
        double h = Altitude.Value
                 + 49.55
                 - 12.60 * y
                 - 22.64 * x;

        lat *= 10 / 3.6;
        lon *= 10 / 3.6;

        return new(lat.Degree, lon.Degree, h.Meter, datum);
    }

    public override SwissMNLocation ToSwissMN(SwissDatum datum = SwissDatum.LV95)
    {
        if (datum == Datum)
            return this;
        else if (datum == SwissDatum.LV03 && Datum == SwissDatum.LV95)
            return new(East - 2_000_000.Meter, North - 1_000_000.Meter, Altitude, datum);
        else if (datum == SwissDatum.LV95 && Datum == SwissDatum.LV03)
            return new(East + 2_000_000.Meter, North + 1_000_000.Meter, Altitude, datum);
        else
            throw new NotImplementedException($"Conversion from {Datum} to {datum} is not defined.");
    }


    public static implicit operator SwissMNLocation((Meter East, Meter North) tuple) => new(tuple.East, tuple.North);

    public static implicit operator SwissMNLocation((double East, double North) tuple) => new(tuple.East.Meter, tuple.North.Meter);

    public static implicit operator SwissMNLocation((Meter East, Meter North, Meter Altitude) tuple) => new(tuple.East, tuple.North, tuple.Altitude);

    public static implicit operator SwissMNLocation((double East, double North, double Altitude) tuple) => new(tuple.East.Meter, tuple.North.Meter, tuple.Altitude.Meter);

    public static implicit operator (Meter East, Meter North)(SwissMNLocation location) => (location.East, location.North);

    public static implicit operator (double East, double North)(SwissMNLocation location) => (location.East.Value, location.North.Value);

    public static implicit operator (Meter East, Meter North, Meter Altitude)(SwissMNLocation location) => (location.East, location.North, location.Altitude);

    public static implicit operator (double East, double North, double Altitude)(SwissMNLocation location) => (location.East.Value, location.North.Value, location.Altitude.Value);
}

public record GeodesicBoundingBox
{
    public Degree NorthBoundary { get; }
    public Degree SouthBoundary { get; }
    public Degree WestBoundary { get; }
    public Degree EastBoundary { get; }
    public WGSDatum Datum { get; }
    public Degree CenterLatitude => field ??= (NorthBoundary + SouthBoundary) / 2;
    public Degree CenterLongitude => field ??= (WestBoundary + EastBoundary) / 2;
    public WGSLocation Center => new(CenterLatitude, CenterLongitude, Datum);
    public WGSLocation NorthWestCorner => new(NorthBoundary, WestBoundary, Datum);
    public WGSLocation NorthEastCorner => new(NorthBoundary, EastBoundary, Datum);
    public WGSLocation SouthWestCorner => new(SouthBoundary, WestBoundary, Datum);
    public WGSLocation SouthEastCorner => new(SouthBoundary, EastBoundary, Datum);
    public Degree AngularHeight => field ??= NorthBoundary - SouthBoundary;
    public Degree AngularWidth => field ??= EastBoundary - WestBoundary;
    public Meter SurfaceHeight => field ??= .5 * (NorthWestCorner - SouthWestCorner) + .5 * (NorthEastCorner - SouthEastCorner);
    public Meter SurfaceWidth => field ??= .5 * (NorthWestCorner - NorthEastCorner) + .5 * (SouthWestCorner - SouthEastCorner);
    public SquareDegree AngularArea => field ??= (Angle)AngularHeight * (Angle)AngularWidth;
    public SquareMeter SurfaceArea => field ??= (Length)SurfaceHeight * (Length)SurfaceWidth;
    public Degree MinimumRadius => field ??= (Math.Min(AngularHeight.Value, AngularWidth.Value) / 2).Degree;
    public Degree MaximumRadius => field ??= (double.Hypot(AngularWidth.Value, AngularHeight.Value) / 2).Degree;
    public bool IsPoint => AngularArea == SquareDegree.Zero;


    public GeodesicBoundingBox(WGSLocation center)
        : this(center, Degree.Zero, Degree.Zero)
    {
    }

    public GeodesicBoundingBox(WGSLocation center, Degree width, Degree height)
        : this(center.Latitude - height / 2, center.Latitude + height / 2, center.Longitude - width / 2, center.Longitude + width / 2, center.Datum)
    {
    }

    public GeodesicBoundingBox(Angle south, Angle north, Angle west, Angle east)
        : this(south, north, west, east, WGSDatum.WGS84)
    {
    }

    public GeodesicBoundingBox(Angle south, Angle north, Angle west, Angle east, WGSDatum datum)
        : this(south.Degree, north.Degree, west.Degree, east.Degree, datum)
    {
    }

    public GeodesicBoundingBox(Degree south, Degree north, Degree west, Degree east)
        : this(south, north, west, east, WGSDatum.WGS84)
    {
    }

    public GeodesicBoundingBox(Degree south, Degree north, Degree west, Degree east, WGSDatum datum)
        : this(south.Value, north.Value, west.Value, east.Value, datum)
    {
    }

    public GeodesicBoundingBox(double south, double north, double west, double east)
        : this(south, north, west, east, WGSDatum.WGS84)
    {
    }

    public GeodesicBoundingBox(double south, double north, double west, double east, WGSDatum datum)
    {
        west = Geolocation.NormalizeAngle(west, GeodesicAngleOrientation.Horizontal);
        east = Geolocation.NormalizeAngle(east, GeodesicAngleOrientation.Horizontal);
        north = Geolocation.NormalizeAngle(north, GeodesicAngleOrientation.Vertical);
        south = Geolocation.NormalizeAngle(south, GeodesicAngleOrientation.Vertical);

        if (south > north)
            (north, south) = (south, north);

        if (west > east)
            (east, west) = (west, east);

        SouthBoundary = south.Degree;
        NorthBoundary = north.Degree;
        WestBoundary = west.Degree;
        EastBoundary = east.Degree;
        Datum = datum;
    }

    public override string ToString()
    {
        if (IsPoint)
            return $"{CenterLatitude.ToSexagesimalNotation(GeodesicAngleOrientation.Vertical)}, {CenterLongitude.ToSexagesimalNotation(GeodesicAngleOrientation.Horizontal)}";
        else
            return $"{SouthBoundary.ToSexagesimalNotation(GeodesicAngleOrientation.Vertical)} -> {NorthBoundary.ToSexagesimalNotation(GeodesicAngleOrientation.Vertical)}, "
                 + $"{WestBoundary.ToSexagesimalNotation(GeodesicAngleOrientation.Horizontal)} -> {EastBoundary.ToSexagesimalNotation(GeodesicAngleOrientation.Horizontal)}";
    }
}

public record OpenLocationCodeConfig
{
    public static OpenLocationCodeConfig Default { get; } = new()
    {
        CodeLength = 10,
        PlusSign = '+',
        Alphabet = "23456789CFGHJMPQRVWX",
        PairResolutions = 5,
        GridRows = 5,
        GridColumns = 4,
        FirstLatitudeResolution = 20.0,
        FirstLongitudeResolution = 20.0,
        LatitudeOrigin = -90.0,
        LongitudeOrigin = -180.0,
        UpperCase = true,
    };

    public required int CodeLength { get; init; }
    public required char PlusSign { get; init; }
    public required string Alphabet { get; init; }
    public required int PairResolutions { get; init; }
    public required int GridRows { get; init; }
    public required int GridColumns { get; init; }
    public required double FirstLatitudeResolution { get; init; }
    public required double FirstLongitudeResolution { get; init; }
    public required double LatitudeOrigin { get; init; }
    public required double LongitudeOrigin { get; init; }
    public required bool UpperCase { get; init; }
}

public record OpenLocationCode
    : Geolocation
{
    public OpenLocationCodeConfig Config { get; }
    public GeodesicBoundingBox BoundingBox { get; }
    public WGSLocation CenterLocation => BoundingBox.Center;
    public string Code { get; }


    public OpenLocationCode(double latitude, double longitude, OpenLocationCodeConfig? config = null)
        : this(latitude.Degree, longitude.Degree, config)
    {
    }

    public OpenLocationCode(Degree latitude, Degree longitude, OpenLocationCodeConfig? config = null)
        : this((Angle)latitude, (Angle)longitude, config)
    {
    }

    public OpenLocationCode(Angle latitude, Angle longitude, OpenLocationCodeConfig? config = null)
        : this(new WGSLocation(latitude, longitude, WGSDatum.WGS84), config)
    {
    }

    public OpenLocationCode(WGSLocation location, OpenLocationCodeConfig? config = null)
        : this(new GeodesicBoundingBox(location), config)
    {
    }

    public OpenLocationCode(GeodesicBoundingBox bounding_box, OpenLocationCodeConfig? config = null)
    {
        BoundingBox = bounding_box;
        Config = config ?? OpenLocationCodeConfig.Default;
        Code = Encode(bounding_box.Center.Latitude.Value, bounding_box.Center.Longitude.Value, Config);
    }

    public OpenLocationCode(string code, OpenLocationCodeConfig? config = null)
    {
        Code = code; // TODO: refine/compress code
        Config = config ?? OpenLocationCodeConfig.Default;
        BoundingBox = Decode(code, Config);
    }

    public override string ToString() => Code;

    public override WGSLocation ToWGS(WGSDatum datum) => CenterLocation.ToWGS(datum);

    private static string Encode(double latitude, double longitude, OpenLocationCodeConfig config)
    {
        // TODO: verify this constraint
        if (config.CodeLength < 2 || config.CodeLength > 15 || config.CodeLength % 2 != 0)
            throw new ArgumentOutOfRangeException(nameof(config.CodeLength), "CodeLength must be an even number between 2 and 15.");

        latitude = NormalizeAngle(latitude, GeodesicAngleOrientation.Vertical);
        longitude = NormalizeAngle(longitude, GeodesicAngleOrientation.Horizontal);
        latitude -= config.LatitudeOrigin;
        longitude -= config.LongitudeOrigin;

        double lat_resolution = config.FirstLatitudeResolution;
        double lon_resolution = config.FirstLongitudeResolution;
        string code = "";
        int pair_length = Math.Min(config.CodeLength, config.PairResolutions * 2);

        for (int i = 0; i < pair_length; i += 2)
        {
            int lat_digit = (int)Math.Min(latitude / lat_resolution, config.Alphabet.Length - 1);
            int lon_digit = (int)Math.Min(longitude / lon_resolution, config.Alphabet.Length - 1);

            code += config.Alphabet[lat_digit];
            code += config.Alphabet[lon_digit];

            latitude -= lat_digit * lat_resolution;
            longitude -= lon_digit * lon_resolution;
            lat_resolution /= config.Alphabet.Length;
            lon_resolution /= config.Alphabet.Length;

            if (code.Length == 8)
                code += '+';
        }

        if (config.CodeLength > 10)
        {
            double latResolution = lat_resolution;
            double lonResolution = lon_resolution;

            for (int i = 10; i < config.CodeLength; i++)
            {
                latResolution /= config.GridRows;
                lonResolution /= config.GridColumns;

                int row = (int)Math.Min(latitude / latResolution, config.GridRows - 1);
                int column = (int)Math.Min(longitude / lonResolution, config.GridColumns - 1);

                code += config.Alphabet[row * config.GridColumns + column];
                latitude -= row * latResolution;
                longitude -= column * lonResolution;
            }
        }

        return code;
    }

    private static GeodesicBoundingBox Decode(string code, OpenLocationCodeConfig config)
    {
        code = new([.. code.ToUpperInvariant().Where(c => c == config.PlusSign || config.Alphabet.Contains(c))]);

        int plus = code.IndexOf(config.PlusSign);

        if (code.Length == 0)
            throw new ArgumentException("Open location code is empty.", nameof(code));
        else if (plus < 0)
            throw new FormatException($"Invalid open location code: missing '{config.PlusSign}'.");

        code = code.Replace(config.PlusSign.ToString(), "");

        if (code.Length < 2 || code.Length > 15)
            throw new FormatException($"Invalid open location code length {code.Length}.");

        int pair_length = Math.Min(code.Length, 10);

        if (pair_length % 2 != 0)
            throw new FormatException($"Invalid open location code pair length {pair_length}.");

        double lat = config.LatitudeOrigin;
        double lon = config.LongitudeOrigin;
        double lat_res = config.FirstLatitudeResolution;
        double lon_res = config.FirstLongitudeResolution;

        for (int i = 0; i < pair_length; i += 2)
        {
            lat += config.Alphabet.IndexOf(code[i]) * lat_res;
            lon += config.Alphabet.IndexOf(code[i + 1]) * lon_res;
            lat_res /= config.Alphabet.Length;
            lon_res /= config.Alphabet.Length;
        }

        for (int i = 10; i < code.Length; i++)
        {
            int value = config.Alphabet.IndexOf(code[i]);
            int row = value / config.GridColumns;
            int column = value % config.GridColumns;

            lat_res /= config.GridRows;
            lon_res /= config.GridColumns;
            lat += row * lat_res;
            lon += column * lon_res;
        }

        return new GeodesicBoundingBox(
            lat.Degree,
            (lat + lat_res).Degree,
            lon.Degree,
            (lon + lon_res).Degree
        );
    }

#warning TODO: implement shorten & recover nearest
    // public static string Shorten(string code, double referenceLatitude, double referenceLongitude)
    // {
    //     if (string.IsNullOrWhiteSpace(code))
    //         throw new ArgumentException("Code is empty.", nameof(code));
    // 
    //     code = code.Trim().ToUpperInvariant();
    // 
    //     int separator = code.IndexOf('+');
    // 
    //     if (separator != 8)
    //         throw new FormatException(
    //             "Shorten requires a full OLC with '+' at position 8.");
    // 
    //     string clean = code.Replace("+", "");
    // 
    //     if (clean.Length < 6)
    //         throw new FormatException("Invalid OLC.");
    // 
    //     if (clean.Contains('0'))
    //         throw new FormatException("Padded OLCs cannot be shortened.");
    // 
    //     referenceLatitude = Math.Max(-90.0,
    //         Math.Min(90.0, referenceLatitude));
    // 
    //     referenceLongitude = NormalizeLongitude(referenceLongitude);
    // 
    //     Area area = Decode(code);
    // 
    //     double latOffset =
    //         Math.Abs(area.CenterLatitude - referenceLatitude);
    // 
    //     double lonOffset =
    //         Math.Abs(area.CenterLongitude - referenceLongitude);
    // 
    //     double maxOffset = Math.Max(latOffset, lonOffset);
    // 
    //     // Remove six characters.
    //     //
    //     // Six characters correspond to a 20-degree pair followed
    //     // by a 1-degree pair. The resulting 4-character code has
    //     // 1-degree precision.
    //     if (clean.Length >= 10 && 1.0 > 2.0 * maxOffset)
    //         return code.Substring(6);
    // 
    //     // Remove four characters.
    //     //
    //     // Four characters correspond to 1-degree precision.
    //     // The resulting 6-character code has 0.05-degree precision.
    //     if (clean.Length >= 8 && 20.0 > 2.0 * maxOffset)
    //         return code.Substring(4);
    // 
    //     // Remove two characters.
    //     //
    //     // The resulting code has 20-degree precision.
    //     if (clean.Length >= 6 && 400.0 > 2.0 * maxOffset)
    //         return code.Substring(2);
    // 
    //     return code;
    // }
    // 
    // public static string RecoverNearest(string shortCode, double referenceLatitude, double referenceLongitude)
    // {
    //     if (string.IsNullOrWhiteSpace(shortCode))
    //         throw new ArgumentException(
    //             "Code is empty.", nameof(shortCode));
    // 
    //     shortCode = shortCode.Trim().ToUpperInvariant();
    // 
    //     int separator = shortCode.IndexOf('+');
    // 
    //     if (separator < 0)
    //         throw new FormatException(
    //             "Invalid OLC: missing '+'.");
    // 
    //     if (separator > 8)
    //         throw new FormatException(
    //             "Code is not a short OLC.");
    // 
    //     string clean = shortCode.Replace("+", "");
    // 
    //     if (clean.Length < 2)
    //         throw new FormatException(
    //             "Short OLC must contain at least two digits.");
    // 
    //     int digitsRemoved = 8 - separator;
    // 
    //     if (digitsRemoved < 2 || digitsRemoved > 6 ||
    //         digitsRemoved % 2 != 0)
    //     {
    //         throw new FormatException(
    //             "Invalid number of removed OLC digits.");
    //     }
    // 
    //     referenceLatitude = Math.Max(-90.0,
    //         Math.Min(90.0, referenceLatitude));
    // 
    //     referenceLongitude = NormalizeLongitude(referenceLongitude);
    // 
    //     // Determine the resolution represented by the missing prefix.
    //     double resolution = 20.0;
    // 
    //     for (int i = 2; i < digitsRemoved; i += 2)
    //         resolution /= 20.0;
    // 
    //     // Encode the reference location at the resolution of the
    //     // missing prefix.
    //     string referenceCode = Encode(
    //         referenceLatitude,
    //         referenceLongitude,
    //         digitsRemoved + clean.Length);
    // 
    //     // Extract the prefix from the reference code.
    //     string prefix =
    //         referenceCode.Replace("+", "")
    //                     .Substring(0, digitsRemoved);
    // 
    //     string fullCode =
    //         prefix + clean;
    // 
    //     // Restore the separator after 8 characters.
    //     fullCode =
    //         fullCode.Substring(0, 8) +
    //         "+" +
    //         fullCode.Substring(8);
    // 
    //     // Decode candidate and determine whether the nearest
    //     // adjacent prefix should be used.
    //     Area area = Decode(fullCode);
    // 
    //     double latitudeDifference =
    //         referenceLatitude - area.CenterLatitude;
    // 
    //     double longitudeDifference =
    //         referenceLongitude - area.CenterLongitude;
    // 
    //     // If the reference is more than half a resolution away,
    //     // move the candidate one cell toward the reference.
    //     if (Math.Abs(latitudeDifference) > resolution / 2.0)
    //     {
    //         int direction = latitudeDifference > 0 ? 1 : -1;
    //         fullCode = ShiftLatitudePrefix(
    //             fullCode, direction, resolution);
    //     }
    // 
    //     if (Math.Abs(longitudeDifference) > resolution / 2.0)
    //     {
    //         int direction = longitudeDifference > 0 ? 1 : -1;
    //         fullCode = ShiftLongitudePrefix(
    //             fullCode, direction, resolution);
    //     }
    // 
    //     return fullCode;
    // }
    // 
    // private static string ShiftLatitudePrefix(string code, int direction, double resolution)
    // {
    //     string clean = code.Replace("+", "");
    // 
    //     // The first digit is latitude.
    //     int index = CodeAlphabet.IndexOf(clean[0]);
    // 
    //     if (index < 0)
    //         throw new FormatException("Invalid OLC.");
    // 
    //     // Determine which prefix pair needs modification.
    //     //
    //     // For a 6-character missing prefix, modify character 0.
    //     // For a 4-character missing prefix, modify character 2.
    //     // For a 2-character missing prefix, modify character 4.
    //     //
    //     // The resolution determines this.
    //     int digitPosition;
    // 
    //     if (resolution >= 20.0)
    //         digitPosition = 0;
    //     else if (resolution >= 1.0)
    //         digitPosition = 2;
    //     else
    //         digitPosition = 4;
    // 
    //     index = CodeAlphabet.IndexOf(clean[digitPosition]);
    //     index += direction;
    // 
    //     if (index < 0 || index >= CodeAlphabet.Length)
    //         return code;
    // 
    //     char[] chars = clean.ToCharArray();
    //     chars[digitPosition] = CodeAlphabet[index];
    // 
    //     string result = new string(chars);
    // 
    //     return result.Substring(0, 8) +
    //            "+" +
    //            result.Substring(8);
    // }
    // 
    // private static string ShiftLongitudePrefix(string code, int direction, double resolution)
    // {
    //     string clean = code.Replace("+", "");
    // 
    //     int digitPosition;
    // 
    //     if (resolution >= 20.0)
    //         digitPosition = 1;
    //     else if (resolution >= 1.0)
    //         digitPosition = 3;
    //     else
    //         digitPosition = 5;
    // 
    //     int index = CodeAlphabet.IndexOf(clean[digitPosition]);
    // 
    //     if (index < 0)
    //         throw new FormatException("Invalid OLC.");
    // 
    //     index += direction;
    // 
    //     if (index < 0 || index >= CodeAlphabet.Length)
    //         return code;
    // 
    //     char[] chars = clean.ToCharArray();
    //     chars[digitPosition] = CodeAlphabet[index];
    // 
    //     string result = new string(chars);
    // 
    //     return result.Substring(0, 8) +
    //            "+" +
    //            result.Substring(8);
    // }

    public static implicit operator OpenLocationCode(string code) => new(code);

    public static implicit operator string(OpenLocationCode code) => code.Code;

    public static implicit operator WGSLocation(OpenLocationCode code) => code.CenterLocation;

    public static implicit operator GeodesicBoundingBox(OpenLocationCode code) => code.BoundingBox;

    public static implicit operator OpenLocationCode(WGSLocation location) => new(location);

    public static implicit operator OpenLocationCode(GeodesicBoundingBox bounding_box) => new(bounding_box);
}

public record UTMLocation
    : Geolocation
{
    private const double _K0 = 0.9996;

    public int Zone { get; }
    public bool IsNorthernHemisphere { get; }
    public double Easting { get; }
    public double Northing { get; }
    public WGSDatum Datum { get; }


    public UTMLocation(int zone, bool is_northern_hemisphere, double easting, double northing)
        : this(zone, is_northern_hemisphere, easting, northing, WGSDatum.WGS84)
    {
    }

    public UTMLocation(int zone, bool is_northern_hemisphere, double easting, double northing, WGSDatum datum)
    {
        if (zone < 1 || zone > 60)
            throw new ArgumentOutOfRangeException(nameof(zone));
        else if (easting < 100000.0 || easting > 1000000.0)
            throw new ArgumentOutOfRangeException(nameof(easting));
        else if (northing < 0.0 || northing > 10000000.0)
            throw new ArgumentOutOfRangeException(nameof(northing));

        Zone = zone;
        Easting = easting;
        Northing = northing;
        IsNorthernHemisphere = is_northern_hemisphere;
        Datum = datum;
    }

    public UTMLocation(WGSLocation location)
    {
        Degree longitude = NormalizeAngle(location.Longitude, GeodesicAngleOrientation.Horizontal);

        if (location.Latitude.Value < -80 || location.Latitude.Value > 84)
            throw new ArgumentOutOfRangeException(nameof(location.Latitude), "UTM is defined from 80°S to 84°N.");

        Zone = ComputeUTMZone(location.Latitude.Value, location.Longitude.Value);
        IsNorthernHemisphere = location.Latitude > Angle.Zero;
        Datum = location.Datum;

        double a = Datum.SemiMajorAxis.Value;
        double e2 = Datum.SquareEccentricity;
        double ep2 = e2 / (1 - e2);
        double lat = location.Latitude.Radian.Value;
        double lon = longitude.Radian.Value;
        double lon0 = (Zone * 6 - 183).Degree.Radian.Value;
        double cos_lat = Math.Cos(lat);
        double tan_lat = Math.Tan(lat);

        double N = a / Math.Sqrt(1 - e2 * Math.Sin(lat) * Math.Sin(lat));
        double T = tan_lat * tan_lat;
        double C = ep2 * cos_lat * cos_lat;
        double A1 = cos_lat * (lon - lon0);

        double M = a * (
                      (1 - .25 * e2 -   .046875 * e2 * e2 -           .01953125 * e2 * e2 * e2) * lat
                    - (   .375 * e2 +    .09375 * e2 * e2 +         .0439453125 * e2 * e2 * e2) * Math.Sin(2 * lat)
                    + (               .05859375 * e2 * e2 +         .0439453125 * e2 * e2 * e2) * Math.Sin(4 * lat)
                    - (                                     .011393229166666666 * e2 * e2 * e2) * Math.Sin(6 * lat)
                  );

        Easting = _K0 * N * (
                    A1
                    + (1 - T + C) * A1 * A1 * A1 / 6
                    + (5 - 18 * T + T * T + 72 * C - 58 * ep2) * Math.Pow(A1, 5) / 120
                ) + 500_000;

        Northing = _K0 * (M + N * tan_lat * (
                            A1 * A1 / 2
                            + (5 - T + 9 * C + 4 * C * C) * Math.Pow(A1, 4) / 24
                            + (61 - 58 * T + T * T + 600 * C - 330 * ep2) * Math.Pow(A1, 6) / 720
                        ));

        if (location.Latitude < Angle.Zero)
            Northing += 10_000_000;
    }

    private static int ComputeUTMZone(double latitude, double longitude)
    {
        int zone = (int)Math.Floor(longitude / 6 + 30) + 1;

        if (latitude is >= 56 and < 64 && longitude is >= 3 and < 12)
            return 32; // Norway
        else if (latitude is >= 72 and < 84)
            return longitude switch
            {
                >= 0 and < 9 => 31,
                >= 9 and < 21 => 33,
                >= 21 and < 33 => 35,
                >= 33 and < 42 => 37,
                _ => zone,
            }; // Svalbard
        else
            return zone;
    }

    public override string ToString() => $"{Zone}{(IsNorthernHemisphere ? 'N' : 'S')} {Easting} {Northing}";

    public override WGSLocation ToWGS(WGSDatum datum)
    {
        double x = Easting - 500_000;
        double y = IsNorthernHemisphere ? Northing : Northing - 10_000_000;
        double a = Datum.SemiMajorAxis.Value;
        double e2 = Datum.SquareEccentricity;
        double ep2 = e2 / (1 - e2);
        double lon0 = (Zone * 6 - 183).Degree.Radian.Value;
        double M = y / _K0;
        double mu = M / (a * (1 -     .25 * e2
                                - .046875 * e2 * e2
                                - .015625 * e2 * e2 * e2
                             ));
        double e1 = (1 - Math.Sqrt(1 - e2))
                  / (1 + Math.Sqrt(1 - e2));
        double phi1 = mu
                    + (   1.5 * e1      - 0.84375 * e1 * e1 * e1)      * Math.Sin(2 * mu)
                    + (1.3125 * e1 * e1 - 1.71875 * e1 * e1 * e1 * e1) * Math.Sin(4 * mu)
                    + (1.572916666666666666666667 * e1 * e1 * e1)      * Math.Sin(6 * mu)
                    + (               2.142578125 * e1 * e1 * e1 * e1) * Math.Sin(8 * mu);

        double sin_phi1_2 = Math.Sin(phi1);

        sin_phi1_2 *= sin_phi1_2;

        double cos_phi1 = Math.Cos(phi1);
        double tan_phi1 = Math.Tan(phi1);

        double C1 = ep2 * cos_phi1 * cos_phi1;
        double T1 = tan_phi1 * tan_phi1;
        double N1 = a / Math.Sqrt(1 - e2 * sin_phi1_2);
        double R1 = a * (1 - e2) / Math.Pow(1 - e2 * sin_phi1_2, 1.5);
        double D = x / (N1 * _K0);

        double lat = phi1 - (N1 * tan_phi1 / R1) * (
                        .5 * D * D
                        - (5 + 3 * T1 + 10 * C1 - 4 * C1 * C1 - 9 * ep2) * Math.Pow(D, 4) / 24
                        + (61 + 90 * T1 + 298 * C1 + 45 * T1 * T1 - 252 * ep2 - 3 * C1 * C1)
                        * Math.Pow(D, 6) / 720
                    );
        double lon = lon0 + (
                        D
                        - (1 + 2 * T1 + C1) * D * D * D / 6
                        + (5 - 2 * C1 + 28 * T1 - 3 * C1 * C1 + 8 * ep2 + 24 * T1 * T1) * Math.Pow(D, 5) / 120
                ) / cos_phi1;

        return new WGSLocation(lat.Radian, lon.Radian, Datum).ToWGS(datum);
    }
}

public record MGRSLocation
    : Geolocation
{
    private const string _BANDS = "CDEFGHJKLMNPQRSTUVWXX";
    private static readonly string[] _COLUMN_SETS =
    {
        "ABCDEFGH", // zones 1, 4, 7, ...
        "JKLMNPQR", // zones 2, 5, 8, ...
        "STUVWXYZ", // zones 3, 6, 9, ...
    };
    private const string _ODD_ROWS = "ABCDEFGHJKLMNPQRSTUV";
    private const string _EVEN_ROWS = "FGHJKLMNPQRSTUVABCDE";


    private readonly UTMLocation _utm;


    public override UTMLocation UTM84 => field ??= _utm;

    public Meter Precision { get; }

    public string Code { get; }


    public MGRSLocation(double latitude, double longitude)
        : this(latitude.Degree, longitude.Degree)
    {
    }

    public MGRSLocation(double latitude, double longitude, WGSDatum datum)
        : this(latitude.Degree, longitude.Degree, datum)
    {
    }

    public MGRSLocation(Degree latitude, Degree longitude)
        : this((Angle)latitude, (Angle)longitude)
    {
    }

    public MGRSLocation(Degree latitude, Degree longitude, WGSDatum datum)
        : this((Angle)latitude, (Angle)longitude, datum)
    {
    }

    public MGRSLocation(Angle latitude, Angle longitude)
        : this(latitude, longitude, WGSDatum.WGS84)
    {
    }

    public MGRSLocation(Angle latitude, Angle longitude, WGSDatum datum)
        : this(new WGSLocation(latitude, longitude, datum))
    {
    }

    public MGRSLocation(WGSLocation location)
        : this(location, new(location))
    {
    }

    public MGRSLocation(UTMLocation location)
        : this(location.ToWGS(location.Datum), location)
    {
    }

    private MGRSLocation(WGSLocation location, UTMLocation utm, int precision = 5)
    {
        if (precision is < 0 or > 5)
            throw new ArgumentOutOfRangeException(nameof(precision));

        int scale = (int)Math.Pow(10, 5 - precision);
        char band = GetLatitudeBand(location.Latitude.Value);
        char column = GetColumnLetter(utm.Zone, utm.Easting);
        char row = GetRowLetter(utm.Zone, utm.Northing);
        string east = precision == 0 ? "" : ((int)(utm.Easting % 100_000 / scale)).ToString($"D{precision}");
        string north = precision == 0 ? "" : ((int)(utm.Northing % 100_000 / scale)).ToString($"D{precision}");

        _utm = utm;
        Code = $"{utm.Zone:00}{band} {column} {row} {east} {north}".Trim();
        Precision = scale.Meter;
    }

    public MGRSLocation(string code)
        : this(code, WGSDatum.WGS84)
    {
    }

    public MGRSLocation(string code, WGSDatum datum)
    {
        Code = code = new([.. from c in code
                              where char.IsAsciiLetterOrDigit(c)
                              select char.ToUpperInvariant(c)]);

        if (code.Length < 3)
            throw new FormatException($"Invalid MGRS coordinate '{code}'.");

        int zone = char.IsDigit(code[0]) ? code[0] - '0' : throw new FormatException($"Invalid MGRS zone '{code}'.");
        int p = 1;

        if (char.IsDigit(code[1]))
        {
            zone = zone * 10 + (code[1] - '0');
            p = 2;
        }

        if (zone < 1 || zone > 60)
            throw new FormatException($"Invalid MGRS zone {zone}.");
        else if (p + 3 > code.Length)
            throw new FormatException($"Invalid MGRS coordinate '{code}'.");

        char band = code[p++];
        char column = code[p++];
        char row = code[p++];

        if (_BANDS.IndexOf(band) < 0)
            throw new FormatException($"Invalid MGRS latitude band '{band}'.");

        double easting = GetColumnEasting(zone, column);
        double northing = GetRowNorthing(zone, row);
        int digit_count = code.Length - p;

        if ((digit_count & 1) != 0)
            throw new FormatException("MGRS easting/northing must contain equal numbers of digits.");
        else if (digit_count > 10)
            throw new FormatException("MGRS precision cannot exceed 5 digits.");

        int precision = digit_count / 2;
        int eastingDigits = int.Parse(code[p..(p + precision)]);
        int northingDigits = int.Parse(code[(p + precision)..]);
        int scale = (int)Math.Pow(10, 5 - precision);

        easting += eastingDigits * scale;
        northing += northingDigits * scale;
        Precision = scale.Meter;

        double lat_candidate = northing;

        for (int i = 0; i < 6; ++i)
        {
            if (lat_candidate is >= 0 and <= 10_000_000)
            {
                _utm = new(zone, band >= 'N', easting, lat_candidate);

                WGSLocation wgs = _utm.ToWGS(datum);

                if (LatitudeBelongsToBand(wgs.Latitude.Value, band))
                    return;
            }

            lat_candidate += 2_000_000;
        }

        throw new FormatException("MGRS northing is inconsistent with its latitude band.");
    }

    public override string ToString() => Code;

    public override WGSLocation ToWGS(WGSDatum datum) => _utm.ToWGS(datum);

    public static MGRSLocation Parse(string code) => new(code);

    public static implicit operator string(MGRSLocation location) => location.Code;

    public static implicit operator MGRSLocation(string code) => Parse(code);


    private static int GetColumnEasting(int zone, char letter)
    {
        string set = _COLUMN_SETS[(zone - 1) % 3];
        int index = set.IndexOf(letter);

        return index >= 0 ? (index + 1) * 100_000 : throw new FormatException($"Invalid MGRS easting letter '{letter}' for zone {zone}.");
    }

    private static int GetRowNorthing(int zone, char letter)
    {
        string rows = (zone & 1) != 0 ? _ODD_ROWS : _EVEN_ROWS;
        int index = rows.IndexOf(letter);

        return index >= 0 ? index * 100_000 : throw new FormatException($"Invalid MGRS northing letter '{letter}'.");
    }

    private static char GetColumnLetter(int zone, double easting)
    {
        int column = (int)(easting / 100_000);

        return column < 1 || column > 8 ? throw new ArgumentOutOfRangeException(nameof(easting)) : _COLUMN_SETS[(zone - 1) % 3][column - 1];
    }

    private static char GetRowLetter(int zone, double northing)
    {
        string rows = (zone & 1) != 0 ? _ODD_ROWS : _EVEN_ROWS;
        int index = ((int)(northing / 100_000)) % 20;

        return rows[index];
    }

    private static char GetLatitudeBand(double latitude)
    {
        if (latitude < -80 || latitude > 84)
            throw new ArgumentOutOfRangeException(nameof(latitude));
        else if (latitude >= 72)
            return 'X';
        else
            return _BANDS[(int)(latitude / 8 + 10)];
    }

    private static bool LatitudeBelongsToBand(double latitude, char band)
    {
        int index = _BANDS.IndexOf(band);

        if (index < 0)
            return false;
        else if (band == 'X')
            return latitude is >= 72 and <= 84;
        else
        {
            double min = -80 + index * 8;

            return latitude >= min && latitude < min + 8;
        }
    }
}

// public record MercatorLocation()
//     : Geolocation
// {
//     public override WGSLocation ToWGS(WGSDatum datum = WGSDatum.WGS84)
//     {
//         if (datum != WGSDatum.WGS84)
//             return ToWGS(WGSDatum.WGS84).ToWGS(datum);
// 
//     }
// 
//     function toMercator(lon, lat)
//     {
//         var x = lon * 20037508.34 / 180;
//         var y = Math.log(Math.tan((90 + lat) * Math.PI / 360)) / (Math.PI / 180);
//         y = y * 20037508.34 / 180;
// 
//         return [x, y];
//     }
// 
//     function inverseMercator(x, y)
//     {
//         var lon = (x / 20037508.34) * 180;
//         var lat = (y / 20037508.34) * 180;
// 
//         lat = 180 / Math.PI * (2 * Math.atan(Math.exp(lat * Math.PI / 180)) - Math.PI / 2);
// 
//         return [lon, lat];
//     }
// }