namespace Domain.Infrastructure.Abstractions.Models;

public record struct Background(
    string Description,
    Guid Id,
    string Name);