using api.Domain.Entities;

namespace api.Application.Repositories;

public interface IOptionRepository : IRepository<Option>
{
    public Task<string> Create(Option entity)
    {
        throw new NotImplementedException();
    }
}
