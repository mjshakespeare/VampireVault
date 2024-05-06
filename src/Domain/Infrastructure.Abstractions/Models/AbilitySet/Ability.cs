using Domain.Infrastructure.Abstractions.Models.AttributeSet;

namespace Domain.Infrastructure.Abstractions.Models.AbilitySet;

public readonly record struct Ability(
    Category Category,
    Guid Id,
    string Name)
{
    public bool IsKnowledge { get; init; }
        = Category == Category.Knowledges;
    
    public bool IsSkill { get; init; }
        = Category == Category.Skills;
    
    public bool IsTalent { get; init; }
        = Category == Category.Talents;
}