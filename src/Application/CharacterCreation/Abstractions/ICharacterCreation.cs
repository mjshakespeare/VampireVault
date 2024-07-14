using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace Application.CharacterCreation.Abstractions;

public interface ICharacterCreation
{
    ValueTask<LoadCharacterSheetResponse> LoadCharacterSheetAsync(
        LoadCharacterSheetRequest request,
        CancellationToken cancellationToken);

    public record struct LoadCharacterSheetRequest
    {
    }

    public record struct LoadCharacterSheetResponse
    {
    }

    ValueTask<ChooseAttributeSetResponse> ChooseAttributeSetAsync(
        ChooseAttributeSetRequest request,
        CancellationToken cancellationToken);

    ValueTask<ChooseAbilitySetResponse> ChooseAbilitiesSetAsync(
        ChooseAbilitySetRequest request,
        CancellationToken cancellationToken);

    ValueTask<ChooseClanResponse> ChooseClanAsync(
        ChooseClanRequest request,
        CancellationToken cancellationToken);

    ValueTask<DistributeBackgroundDotResponse> DistributeBackgroundDotAsync(
        DistributeBackgroundDotRequest request,
        CancellationToken cancellationToken);

    public record struct DistributeBackgroundDotRequest
    {
    }

    public record struct DistributeBackgroundDotResponse
    {
    }
}

public record struct ChooseClanRequest(
    Clan Clan);

public record struct ChooseClanResponse(
    ImmutableArray<Dicipline> Diciplines);

public enum Dicipline
{
    [Display(Name = "Abombwe", Description = "The Bonsam gift of predation")]
    Abomwe = 0,
    [Display(Name = "Abyss Mysticism", Description = "Rituals of darkness and shade")]
    AbyssMysticism = 1,
    [Display(Name = "Animalism", Description = "Mastery over beasts")]
    Animalism = 2,
    [Display(Name = "Auspex", Description = "Senses beyond sight")]
    Auspex = 3,
    [Display(Name = "Celerity", Description = "Unnatural speed and dexterity")]
    Celerity = 4,
    [Display(Name = "Bardo", Description = "The manipulation of humanity as practised by the Children of Osiris")]
    Bardo = 5,
    [Display(Name = "Chimerstry", Description = "Ravnos illusion and deception")]
    Chimerstry = 6,
    [Display(Name = "Daimonion", Description = "The Baali affinity for the fiendish")]
    Daimonion = 7,
    [Display(Name = "Dementation", Description = "A Malkavian's honed madness")]
    Dementation = 8,
    [Display(Name = "Dominate", Description = "Mastery of the mind")]
    Dominate = 9,
    [Display(Name = "Flight", Description = "A Gargoyle's ability to fly")]
    Flight = 10,
    [Display(Name = "Fortitude", Description = "Supernatural toughness")]
    Fortitude = 11,
    [Display(Name = "Koldunic Sorcery", Description = "Raw, elemental magic")]
    KoldunicSorcery = 12,
    [Display(Name = "Mytherceria", Description = "A Kiasyd's fae magic")]
    Mytherceria = 13,
    [Display(Name = "Necromancy", Description = "Varied death magics")]
    Necromancy = 14,
    [Display(Name = "Obfuscate", Description = "Moving unseen and unnoticed")]
    Obfuscate = 15,
    [Display(Name = "Obtenebration", Description = "Lasombra shadow play")]
    Obtenebration = 16,
    [Display(Name = "Ogham", Description = "Spiritual power over the earth")]
    Ogham = 17,  
    [Display(Name = "Potence", Description = "Unholy strength")]  
    Potence = 18,
    [Display(Name = "Presence", Description = "Uncanny charm and guile")]
    Presence = 19,
    [Display(Name = "Protean", Description = "Gangrel shapeshifting")]
    Portean = 20,
    [Display(Name = "Quietus", Description = "Secrets of Assamite judgment")]
    Quietus = 21,
    [Display(Name = "Spiritus", Description = "Ahrimane spirit manipulation")]
    Spiritus = 22,
    [Display(Name = "Temporis", Description = "True Brujah time manipulation")]
    Temporis = 23,
    [Display(Name = "Thaumaturgy", Description = "Ritual and hermetic sorcery")]
    Thaumaturgy = 24,
    [Display(Name = "Valeren", Description = "Salubri work of the soul")]
    Valeren = 25,
    [Display(Name = "Vicissitude", Description = "Tzimisce fleshcrafting")]
    Vicissitude = 26,
}

public enum Clan
{
    // TODO Character creation quick ref pg 156
    Ahrimanes = 0,
    Assamites = 1,
    Baali = 2,
    Bonsam = 3,
    Brujah = 4,
    Cappadocian = 5,
    ChildrenOfOsiris = 6,
    Danava = 7,
    FollowersOfSet = 8,
    Gangrel = 9,
    Giovani = 10,
    Impundulu = 11,
    Kiasyd = 12,
    Lamiae = 13,
    Lasombra = 14,
    Lhiannan = 15,
    Malkavians = 16,
    Nagarajah = 17,
    Niktuku = 18,
    Nosferatu = 19,
    Ramanga = 20,
    Ravnos = 21,
    Salubri = 22,
    Setites = 23,
    Toreador = 24,
    Tremere = 25,
    TrueBrujah = 26,
    Tzimisce = 27,
    Ventrue = 28,
}

public record struct ChooseAttributeSetRequest(
    AttributeSet Primary,
    AttributeSet Secondary,
    AttributeSet Tertiary);

public enum AttributeSet
    : byte
{
    Physical = 0,
    Social = 1,
    Mental = 2,
}

public record struct ChooseAttributeSetResponse(
    string? Message)
{
    private bool Failed
        => Message is not null;
}

public record struct ChooseAbilitySetRequest(
    AbilitySet Primary,
    AbilitySet Secondary,
    AbilitySet Tertiary);

public enum AbilitySet
    : byte
{
    Talents = 0,
    Skills = 1,
    Knowledges = 2,
}

public record struct ChooseAbilitySetResponse(
    string? Message)
{
    private bool Failed
        => Message is not null;
}

