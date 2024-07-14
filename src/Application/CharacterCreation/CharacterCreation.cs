using Application.CharacterCreation.Abstractions;

namespace Application.CharacterCreation;

public sealed class CharacterCreation
: ICharacterCreation
{
    public ValueTask<ICharacterCreation.LoadCharacterSheetResponse> LoadCharacterSheetAsync(ICharacterCreation.LoadCharacterSheetRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ChooseAttributeSetResponse> ChooseAttributeSetAsync(ChooseAttributeSetRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ChooseAbilitySetResponse> ChooseAbilitiesSetAsync(ChooseAbilitySetRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ChooseClanResponse> ChooseClanAsync(ChooseClanRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ICharacterCreation.DistributeBackgroundDotResponse> DistributeBackgroundDotAsync(ICharacterCreation.DistributeBackgroundDotRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
