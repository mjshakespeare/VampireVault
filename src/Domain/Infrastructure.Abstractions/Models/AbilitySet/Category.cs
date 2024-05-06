using System.ComponentModel.DataAnnotations;

namespace Domain.Infrastructure.Abstractions.Models.AbilitySet;

public enum Category
    : byte
{
    [Display(Name = "Talents")]
    Talents = 0,
    [Display(Name = "Skills")]
    Skills = 1,
    [Display(Name = "Knowledges")]
    Knowledges = 2,
}