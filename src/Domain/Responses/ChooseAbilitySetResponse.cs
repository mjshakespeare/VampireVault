namespace Application.CharacterCreation.Abstractions.Models.Responses;

public record struct ChooseAbilitySetResponse(
    string? Message)
{
    private bool Failed
        => Message is not null;
}
