namespace Domain.Infrastructure.Abstractions.Models;

public record struct Dicipline(
    string Description,
    Guid Id,
    string Name);