namespace Application.CharacterCreation.Abstractions.Models;

public enum Category
{
    Physical,
    Social,
    Mental
}

public record struct ChooseAttributeSetRequest(
    Category Primary,
    Category Secondary,
    Category Tertiary)
{
}