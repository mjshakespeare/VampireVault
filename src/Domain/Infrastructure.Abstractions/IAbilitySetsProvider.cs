using System.Collections.Immutable;
using Domain.Infrastructure.Abstractions.Models.AbilitySet;

namespace Domain.Infrastructure.Abstractions;

public interface IAbilitySetsProvider
{
    ValueTask<ImmutableArray<AbilitySet>> GetAllAbilitySetsAsync(
        CancellationToken cancellationToken);

    ValueTask<AbilitySet> GetAbilitySetAsync(
        Category category,
        CancellationToken cancellationToken);
}