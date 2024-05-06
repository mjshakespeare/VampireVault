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
}