using System;

using Unknown6656.Units.Kinematics;

namespace Unknown6656.Physics.Nuclear;


public record Spin
{
    private readonly uint _value = 0;


    public bool IsFermion => _value % 2 == 1;

    public bool IsBoson => !IsFermion;

    public float QuantumNumber => _value * .5f;

    public AngularMomentum Momentum => QuantumNumber * AngularMomentum.ReducedPlanckConstant;


    public Spin(AngularMomentum momentum)
        : this(momentum / AngularMomentum.ReducedPlanckConstant)
    {
    }

    public Spin(int quantum_number)
        : this((uint)quantum_number)
    {
        if (quantum_number < 0)
            throw new ArgumentOutOfRangeException(nameof(quantum_number), "The quantum number must be non-negative.");
    }

    public Spin(uint quantum_number) => _value = quantum_number * 2;

    public Spin(double quantum_number)
    {
        quantum_number = Math.Round(quantum_number * 2) / 2;

        _value = quantum_number >= 0 ? (uint)(quantum_number * 2) : throw new ArgumentOutOfRangeException(nameof(quantum_number), "The quantum number must be non-negative.");
    }

    public override string ToString() => IsFermion ? $"{_value}/2" : (_value / 2).ToString();

    public static Spin operator +(Spin a) => a;

    public static Spin operator +(Spin a, Spin b) => new(a._value + b._value);

    public static Spin operator -(Spin a, Spin b) => new(a._value - b._value);

    public static Spin operator *(double factor, Spin a) => a * factor;

    public static Spin operator *(Spin a, double factor) => new(a.QuantumNumber * factor);

    public static Spin operator /(Spin a, double factor) => new(a.QuantumNumber / factor);

    public static implicit operator Spin(int quantum_number) => new(quantum_number);

    public static implicit operator Spin(uint quantum_number) => new(quantum_number);

    public static implicit operator Spin(double quantum_number) => new(quantum_number);

    public static implicit operator Spin(AngularMomentum momentum) => new(momentum);

    public static implicit operator AngularMomentum(Spin spin) => spin.Momentum;

    public static implicit operator float(Spin spin) => spin.QuantumNumber;
}
