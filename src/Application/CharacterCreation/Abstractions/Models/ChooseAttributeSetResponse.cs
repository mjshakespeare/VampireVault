namespace Application.CharacterCreation.Abstractions.Models;

public record struct ChooseAttributeSetResponse(
    string? Message)
{
    public bool Failed { get; init; }
        = Message is not null;
}