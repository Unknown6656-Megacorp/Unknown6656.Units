using System;

using Unknown6656.Units.Kinematics;

namespace Unknown6656.Physics.Nuclear;


public sealed record Spin
    : IComparable<Spin>
{
    private readonly int _value = 0;

    public static Spin Zero { get; } = new(0);

    public static Spin HiggsBoson => Zero;
    public static Spin Photon => new(1);
    public static Spin Gluon => new(1);
    public static Spin WBoson => new(1);
    public static Spin ZBoson => new(1);
    public static Spin Graviton => new(2);
    public static Spin Electron => new(.5);
    public static Spin Muon => new(.5);
    public static Spin Tau => new(.5);
    public static Spin Positron => new(.5);
    public static Spin Quark => new(.5);
    public static Spin Neutrino => new(.5);


    public bool IsFermion => _value % 2 == 1;

    public bool IsBoson => !IsFermion;

    public double QuantumNumber => _value * .5;

    public AngularMomentum Momentum => QuantumNumber * AngularMomentum.ReducedPlanckConstant;


    public Spin(AngularMomentum momentum)
        : this(momentum / AngularMomentum.ReducedPlanckConstant)
    {
    }

    public Spin(int quantum_number) => _value = quantum_number * 2;

    public Spin(double quantum_number) => _value = (int)Math.Round(quantum_number * 2) / 2;

    public int CompareTo(Spin? other) => _value.CompareTo(other?._value);

    public override string ToString() => IsFermion ? $"{_value}/2" : (_value / 2).ToString();

    public static Spin operator +(Spin a) => a;

    public static Spin operator -(Spin a) => new(-a.QuantumNumber);

    public static Spin operator +(Spin a, Spin b) => new(a.QuantumNumber + b.QuantumNumber);

    public static Spin operator -(Spin a, Spin b) => new(a.QuantumNumber - b.QuantumNumber);

    public static Spin operator *(double factor, Spin a) => a * factor;

    public static Spin operator *(Spin a, double factor) => new(a.QuantumNumber * factor);

    public static Spin operator /(Spin a, double factor) => new(a.QuantumNumber / factor);

    public static implicit operator Spin(int quantum_number) => new(quantum_number);

    public static implicit operator Spin(double quantum_number) => new(quantum_number);

    public static implicit operator Spin(AngularMomentum momentum) => new(momentum);

    public static implicit operator AngularMomentum(Spin spin) => spin.Momentum;

    public static implicit operator double(Spin spin) => spin.QuantumNumber;
}
