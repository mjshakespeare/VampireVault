using System.Collections.Immutable;

namespace Application.CharacterCreation.Abstractions.Models;

public record struct ChooseClanResponse(
    ImmutableArray<Dicipline> Diciplines);