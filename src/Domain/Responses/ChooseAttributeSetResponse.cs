namespace Application.CharacterCreation.Abstractions.Models.Responses;

public record struct ChooseAttributeSetResponse(
    string? Message)
{
    public bool Failed { get; init; }
        = Message is not null;
}