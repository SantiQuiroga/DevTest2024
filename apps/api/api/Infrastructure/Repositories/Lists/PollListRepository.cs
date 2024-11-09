using api.Application.Repositories;
using api.Domain.Entities;

namespace api.Infrastructure.Repositories.Lists;

public class PollListRepository : IPollRepository
{
    public Task<string> Create(Poll entity)
    {
        return Task.FromResult("Poll Created.");
    }

    public Task<IList<Poll>> GetAll()
    {
        IList<Poll> polls = [];

        return Task.FromResult(polls);
    }
}
