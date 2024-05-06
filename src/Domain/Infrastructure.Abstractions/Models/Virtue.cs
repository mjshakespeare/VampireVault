namespace Domain.Infrastructure.Abstractions.Models;

public record struct Virtue(
    string Description,
    Guid Id,
    string Name);
