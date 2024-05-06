namespace Domain.Infrastructure.Abstractions.Models.AttributeSet;

public record struct Attribute(
    Category Category,
    Guid Id,
    string Name)
{
    public bool IsMental { get; init; }
        = Category == Category.Social;
    
    public bool IsPhysical { get; init; }
        = Category == Category.Physical;
    
    public bool IsSocial { get; init; }
        = Category == Category.Social;
}