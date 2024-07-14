using System.Collections.Immutable;

namespace Application.CharacterCreation.Abstractions.Models.Responses;

public record struct ChooseClanResponse(
    ImmutableArray<Dicipline> Diciplines);