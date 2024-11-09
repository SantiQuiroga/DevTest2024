using api.Application.Repositories;
using api.Domain.Entities;

namespace api.Infrastructure.Repositories.Lists;

public class OptionListRepository : IOptionRepository
{
    public Task<string> Create(Option entity)
    {
        return Task.FromResult("Option Created.");
    }
}
