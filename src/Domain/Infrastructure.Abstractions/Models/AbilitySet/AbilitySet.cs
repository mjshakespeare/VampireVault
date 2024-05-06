using System.Collections.Immutable;

namespace Domain.Infrastructure.Abstractions.Models.AbilitySet;

public record struct AbilitySet(
    ImmutableArray<Ability> Abilities)
{
    public ImmutableArray<Ability> Abilities { get; init; }
        = [
            ..Abilities
                .OrderBy(
                    x => x.Name)
        ];
}