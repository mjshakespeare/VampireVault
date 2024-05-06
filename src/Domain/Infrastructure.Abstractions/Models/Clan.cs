namespace Domain.Infrastructure.Abstractions.Models;

public record struct Clan(
    string Description,
    Guid Id,
    string Name);