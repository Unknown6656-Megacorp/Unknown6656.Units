using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Unknown6656.Units;
using Unknown6656.Units.Euclidean;
using Unknown6656.Units.Information;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Unknown6656.Physics.Geography;


public enum LocationFormatting
{
    Compact,
    Short,
    Long,
}

public enum WGSDatum
{
    WGS84,
    GRS80,
    WGS72,
    WGS66,
}

public enum SwissDatum
{
    LV95,
    LV03,
}

public abstract record Geolocation
{
    internal static readonly Dictionary<WGSDatum, (double a, double b)> _wgs_ellipsoid_parameters = new()
    {
        [WGSDatum.WGS84] = (a: 6_378_137, b: 6_356_752.314245),
        [WGSDatum.GRS80] = (a: 6_378_137, b: 6_356_752.314140),
        [WGSDatum.WGS72] = (a: 6_378_135, b: 6_356_750),
        [WGSDatum.WGS66] = (a: 6_378_160, b: 6_356_750),
    };

    public WGSLocation WGS84 => field ??= ToWGS(WGSDatum.WGS84);

    public ECEFLocation ECEF84 => field ??= ToECEF(WGSDatum.WGS84);

    public SwissMNLocation SwissMN95 => field ??= ToSwissMN(SwissDatum.LV95);

    public OpenLocationCode OLC => field ??= new(WGS84);


    public abstract WGSLocation ToWGS(WGSDatum datum = WGSDatum.WGS84);

    public virtual ECEFLocation ToECEF(WGSDatum datum = WGSDatum.WGS84) => ToWGS(datum).ToECEF(datum);

    public virtual SwissMNLocation ToSwissMN(SwissDatum datum = SwissDatum.LV95) => ToWGS(WGSDatum.WGS84).ToSwissMN(datum);

    public virtual Length SurfaceDistanceTo(Geolocation other) => ToWGS(WGSDatum.WGS84).SurfaceDistanceTo(other.ToWGS(WGSDatum.WGS84));

    public virtual Length EucledianDistanceTo(Geolocation other) => ToECEF(WGSDatum.WGS84).EucledianDistanceTo(other.ToECEF(WGSDatum.WGS84));

    public virtual string ToGeoURI() => ToGeoURI(WGSDatum.WGS84);

    public string ToGeoURI(WGSDatum datum) => ToWGS(datum).ToGeoURI();

    public static Degree NormalizeAngle(Angle angle, GeodesicAngleOrientation orientation) => NormalizeAngle(angle.Degree, orientation);

    public static Degree NormalizeAngle(Degree angle, GeodesicAngleOrientation orientation) => NormalizeAngle(angle.Value, orientation).Degree();

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
// TODO: UTM coordinates https://en.wikipedia.org/wiki/Universal_Transverse_Mercator_coordinate_system
// TODO: MGRS coordinates https://en.wikipedia.org/wiki/Military_Grid_Reference_System
// TODO: https://en.wikipedia.org/wiki/Natural_Area_Code
// TODO: https://en.wikipedia.org/wiki/Helmert_transformation#Application

/// <summary>
/// Represents a geolocation in Earth-Centered, Earth-Fixed (ECEF) coordinates.
/// </summary>
/// <param name="X">The ECEF's X coordinate.</param>
/// <param name="Y">The ECEF's Y coordinate.</param>
/// <param name="Z">The ECEF's Z coordinate.</param>
/// <param name="Datum">The WGS datum.</param>
public record ECEFLocation(Length X, Length Y, Length Z, WGSDatum Datum = WGSDatum.WGS84)
    : Geolocation
{
    public bool IsNorth => Z > Length.Zero;
    public bool IsSouth => Z < Length.Zero;
    public bool IsEquator => Z == Length.Zero;


    public ECEFLocation(double X_meters, double Y_meters, double Z_meters, WGSDatum datum = WGSDatum.WGS84)
        : this(X_meters.Meter(), Y_meters.Meter(), Z_meters.Meter(), datum)
    {
    }

    public override string ToString() => $"({X}, {Y}, {Z})";

    public override ECEFLocation ToECEF(WGSDatum datum = WGSDatum.WGS84)
    {
        if (datum == Datum)
            return this;

        // TODO: Helmert transformation https://en.wikipedia.org/wiki/Helmert_transformation#Application

        throw new NotImplementedException();
    }

    public override WGSLocation ToWGS(WGSDatum datum = WGSDatum.WGS84)
    {
        if (datum != Datum)
            return ToECEF(datum).ToWGS(datum);

        (double a, double b) = _wgs_ellipsoid_parameters[datum];
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

        return new WGSLocation(lat.Radian(), lon.Radian(), h.Meter(), datum);
    }

    public override Length EucledianDistanceTo(Geolocation other)
    {
        ECEFLocation ecef = other.ToECEF(Datum);
        double dx = (X - ecef.X).Meter.Value;
        double dy = (Y - ecef.Y).Meter.Value;
        double dz = (Z - ecef.Z).Meter.Value;

        return Math.Sqrt(dx * dx + dy * dy + dz * dz).Meter();
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
    public static WGSLocation NullIsland { get; } = new(0d.Degree(), 0d.Degree(), 0d.Meter());
    public static WGSLocation NorthPole { get; } = new(90d.Degree(), 0d.Degree(), 0d.Meter());
    public static WGSLocation SouthPole { get; } = new(-90d.Degree(), 0d.Degree(), 0d.Meter());


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
    public bool IsAntiMeridian => Longitude == 180d.Degree() || Longitude == -180d.Degree();
    public bool IsNullIsland => Latitude == Degree.Zero && Longitude == Degree.Zero;
    public bool IsUnderSeaLevel => Altitude < Meter.Zero;
    public bool IsOverSeaLevel => Altitude >= Meter.Zero;


    public WGSLocation(Angle latitude, Angle longitude, WGSDatum datum = WGSDatum.WGS84)
        : this(latitude, longitude, 0d.Meter(), datum)
    {
    }

    public WGSLocation(Angle latitude, Angle longitude, Length altitude, WGSDatum datum = WGSDatum.WGS84)
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
        (double a, double b) = _wgs_ellipsoid_parameters[Datum];
        double f = (a - b) / a;

        const double tolerance = 1e-11;

        double phi1 = Latitude.Radian.Value,
               phi2 = loc.Latitude.Radian.Value;
        double L1 = Longitude.Radian.Value,
               L2 = loc.Longitude.Radian.Value;
        double L = L2 - L1;
        double U1 = Math.Atan((1 - f) * Math.Tan(phi1));
        double U2 = Math.Atan((1 - f) * Math.Tan(phi2));
        double t;
        double lambda_old = L + 0;
        double cos_sq_alpha, cos_2sigma_m, sin_sigma, cos_sigma, sigma;

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

        return (b * A * (sigma - delta_sigma)).Meter();
    }

    public override WGSLocation ToWGS(WGSDatum datum = WGSDatum.WGS84) => datum == Datum ? this : ToECEF(datum).ToWGS();

    public override ECEFLocation ToECEF(WGSDatum datum = WGSDatum.WGS84)
    {
        if (datum != Datum)
            return ToECEF(Datum).ToECEF(datum);

        (double a, double b) = _wgs_ellipsoid_parameters[datum];
        double lat = Latitude.Radian.Value;
        double lon = Longitude.Radian.Value;
        double h = Altitude.Value;
        double e2 = 1 - (b * b) / (a * a);
        double N = a / Math.Sqrt(1 - e2 * Math.Pow(Math.Sin(lat), 2));

        double X = (N + h) * Math.Cos(lat) * Math.Cos(lon);
        double Y = (N + h) * Math.Cos(lat) * Math.Sin(lon);
        double Z = (N * (1 - e2) + h) * Math.Sin(lat);

        return new(X.Meter(), Y.Meter(), Z.Meter());
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

        return new(east.Meter(), north.Meter(), h.Meter(), datum);
    }

    public override string ToGeoURI() => $"geo:{Latitude.Value},{Longitude.Value},{Altitude.Value}";

    public string ToGeoURI(Length uncertainty) => $"geo:{Latitude.Value},{Longitude.Value},{Altitude.Value};u={uncertainty.Meter.Value}";


    public static implicit operator WGSLocation((Degree latitude, Degree longitude) tuple) => new(tuple.latitude, tuple.longitude);

    public static implicit operator WGSLocation((Degree latitude, Degree longitude, Meter altitude) tuple) => new(tuple.latitude, tuple.longitude, tuple.altitude);

    public static implicit operator WGSLocation((double latitude, double longitude) tuple) => new(tuple.latitude.Degree(), tuple.longitude.Degree());

    public static implicit operator WGSLocation((double latitude, double longitude, double altitude) tuple) => new(tuple.latitude.Degree(), tuple.longitude.Degree(), tuple.altitude.Meter());

    public static implicit operator (Degree latitude, Degree longitude)(WGSLocation location) => (location.Latitude, location.Longitude);

    public static implicit operator (Degree latitude, Degree longitude, Meter altitude)(WGSLocation location) => (location.Latitude, location.Longitude, location.Altitude);

    public static implicit operator (double latitude, double longitude)(WGSLocation location) => (location.Latitude.Value, location.Longitude.Value);

    public static implicit operator (double latitude, double longitude, double altitude)(WGSLocation location) => (location.Latitude.Value, location.Longitude.Value, location.Altitude.Value);

    public static implicit operator ECEFLocation(WGSLocation location) => location.ToECEF();

    public static implicit operator SwissMNLocation(WGSLocation location) => location.ToSwissMN();

    public static implicit operator WGSLocation(ECEFLocation location) => location.ToWGS();

    public static implicit operator WGSLocation(SwissMNLocation location) => location.ToWGS();
}

public record SwissMNLocation(Meter East, Meter North, Meter Altitude, SwissDatum Datum = SwissDatum.LV95)
    : Geolocation
{
    public static SwissMNLocation Zero { get; } = new(0d.Meter(), 0d.Meter(), 0d.Meter());
    public static SwissMNLocation ZimmerwaldObservatoryReferencePoint { get; } = new(2_602_030d.Meter(), 1_191_775d.Meter(), 898d.Meter());
    public static SwissMNLocation BerneUniversityReferencePoint { get; } = new(2_600_000d.Meter(), 1_200_000d.Meter(), 554.2.Meter());


    public SwissMNLocation(Meter east, Meter north, SwissDatum datum = SwissDatum.LV95)
        : this(east, north, 0d.Meter(), datum)
    {
    }

    public override string ToString() => $"E={East.Value}, N={North.Value}, {Altitude}";

    public override WGSLocation ToWGS(WGSDatum datum = WGSDatum.WGS84)
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

        return new(lat.Degree(), lon.Degree(), h.Meter(), datum);
    }

    public override SwissMNLocation ToSwissMN(SwissDatum datum = SwissDatum.LV95)
    {
        if (datum == Datum)
            return this;
        else if (datum == SwissDatum.LV03 && Datum == SwissDatum.LV95)
            return new(East - 2_000_000d.Meter(), North - 1_000_000d.Meter(), Altitude, datum);
        else if (datum == SwissDatum.LV95 && Datum == SwissDatum.LV03)
            return new(East + 2_000_000d.Meter(), North + 1_000_000d.Meter(), Altitude, datum);
        else
            throw new NotImplementedException($"Conversion from {Datum} to {datum} is not defined.");
    }


    public static implicit operator SwissMNLocation((Meter East, Meter North) tuple) => new(tuple.East, tuple.North);

    public static implicit operator SwissMNLocation((double East, double North) tuple) => new(tuple.East.Meter(), tuple.North.Meter());

    public static implicit operator SwissMNLocation((Meter East, Meter North, Meter Altitude) tuple) => new(tuple.East, tuple.North, tuple.Altitude);

    public static implicit operator SwissMNLocation((double East, double North, double Altitude) tuple) => new(tuple.East.Meter(), tuple.North.Meter(), tuple.Altitude.Meter());

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
    public Degree MinimumRadius => field ??= (Math.Min(AngularHeight.Value, AngularWidth.Value) / 2).Degree();
    public Degree MaximumRadius => field ??= (double.Hypot(AngularWidth.Value, AngularHeight.Value) / 2).Degree();
    public bool IsPoint => AngularArea == SquareDegree.Zero;


    public GeodesicBoundingBox(WGSLocation center)
        : this(center, Degree.Zero, Degree.Zero)
    {
    }

    public GeodesicBoundingBox(WGSLocation center, Degree width, Degree height)
        : this(center.Latitude - height / 2, center.Latitude + height / 2, center.Longitude - width / 2, center.Longitude + width / 2, center.Datum)
    {
    }

    public GeodesicBoundingBox(Angle south, Angle north, Angle west, Angle east, WGSDatum datum = WGSDatum.WGS84)
        : this(south.Degree, north.Degree, west.Degree, east.Degree, datum)
    {
    }

    public GeodesicBoundingBox(Degree south, Degree north, Degree west, Degree east, WGSDatum datum = WGSDatum.WGS84)
        : this(south.Value, north.Value, west.Value, east.Value, datum)
    {
    }

    public GeodesicBoundingBox(double south, double north, double west, double east, WGSDatum datum = WGSDatum.WGS84)
    {
        west = Geolocation.NormalizeAngle(west, GeodesicAngleOrientation.Horizontal);
        east = Geolocation.NormalizeAngle(east, GeodesicAngleOrientation.Horizontal);
        north = Geolocation.NormalizeAngle(north, GeodesicAngleOrientation.Vertical);
        south = Geolocation.NormalizeAngle(south, GeodesicAngleOrientation.Vertical);

        if (south > north)
            (north, south) = (south, north);

        if (west > east)
            (east, west) = (west, east);

        SouthBoundary = south.Degree();
        NorthBoundary = north.Degree();
        WestBoundary = west.Degree();
        EastBoundary = east.Degree();
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
        : this(latitude.Degree(), longitude.Degree(), config)
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

    public override WGSLocation ToWGS(WGSDatum datum = WGSDatum.WGS84) => CenterLocation.ToWGS(datum);

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
            lat.Degree(),
            (lat + lat_res).Degree(),
            lon.Degree(),
            (lon + lon_res).Degree()
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