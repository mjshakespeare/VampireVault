using System.ComponentModel.DataAnnotations;

namespace Domain.Infrastructure.Abstractions.Models.AttributeSet;

public enum Category
    : byte
{
    [Display(Name = "Physical")]
    Physical = 0,
    [Display(Name = "Social")]
    Social = 1,
    [Display(Name = "Mental")]
    Mental = 2,
}