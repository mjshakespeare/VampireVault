using Microsoft.AspNetCore.Components;

namespace VampireVault.Client.Components;

public partial class Characteristic
    : ComponentBase
{
    [Parameter]
    public string Name { get; set; }
        = string.Empty;
    
    [Parameter]
    public byte Value { get; set; }
    
    [Parameter]
    public byte MaxValue { get; set; }

    public int PointsToDistribute
        => Value == 0
            ? 3
            : Value * 2;

    public int PointsToRefund
        => Value == 1
            ? 3
            : Math.Abs(Value - 1 * 2);
    
    public void RefundPoint()
    {
        Console.WriteLine("RefundPoint");
        Value--;
    }
    
    public void BuyPoint()
    {
        Console.WriteLine("BuyPoint");
        
        Value++;
    }
}