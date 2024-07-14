namespace Application.CharacterCreation.Abstractions.Models;

public struct Characteristic
{
    private readonly int _initialCost;

    private readonly int _perValueCost;

    private int Min { get; set; }

    private int Max { get; set; }

    private int Value { get; set; }

    public Characteristic()
    {
    }

    public Characteristic(
        int initialCost,
        int perValueCost,
        int min,
        int max,
        int value)
    {
        _initialCost = initialCost;
        _perValueCost = perValueCost;

        Min = min;
        Max = max;
        Value = value;
    }

    public int GetTotalCost(
        int value)
    {
        ArgumentOutOfRangeException
            .ThrowIfLessThan(
                value,
                Min,
                nameof(value));

        ArgumentOutOfRangeException
            .ThrowIfGreaterThan(
                value,
                Max,
                nameof(value));

        if (value == Value)
        {
            return 0;
        }

        return GetValue(value-1) - GetValue(Value-1);
    }

    // Total cost of current value
    private int GetValue(
        int value)
    {
        if (value < 0)
        {
            return 0;
        }
        
        return _initialCost + (value * _perValueCost); 
    }
}
