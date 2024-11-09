using api.Domain.Entities;

namespace api.Application.Dtos;

public class CreatePollDto
{
    public required string Name { get; init; }
    public required List<Option> Options { get; init; }
}