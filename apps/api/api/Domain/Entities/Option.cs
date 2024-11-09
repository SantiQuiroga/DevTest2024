namespace api.Domain.Entities;

public class Option : IEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string VoterEmail { get; init; }
    public required Guid PollId { get; init; }
}
