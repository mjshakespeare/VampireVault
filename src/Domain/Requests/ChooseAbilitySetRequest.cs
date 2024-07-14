
namespace Application.CharacterCreation.Abstractions.Models.Requests
{
  public record struct ChooseAbilitySetRequest(
    AbilityCategory Primary,
    AbilityCategory Secondary,
    AbilityCategory Tertiary);
}
