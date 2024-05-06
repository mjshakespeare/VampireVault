using System.Collections.Immutable;

namespace Domain.Infrastructure.Abstractions.Models.AttributeSet;

public record struct AttributeSet(
    ImmutableArray<Attribute> Attributes)
{
    public ImmutableArray<Attribute> Attributes { get; init; }
        = [
            ..Attributes
                .OrderBy(
                    x =>
                        x.Name)
        ];
}