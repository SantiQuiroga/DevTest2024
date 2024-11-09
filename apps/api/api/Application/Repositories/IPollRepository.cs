using api.Domain.Entities;

namespace api.Application.Repositories;

public interface IPollRepository : IRepository<Poll>
{
    Task<IList<Poll>> GetAll();
}