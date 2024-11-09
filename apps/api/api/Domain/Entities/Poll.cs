namespace api.Domain.Entities;

public class Poll : IEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string Name { get; init; }
    public IList<Option> Options { get; set; } = [];
}