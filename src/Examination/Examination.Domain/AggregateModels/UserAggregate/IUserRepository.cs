using System.Threading.Tasks;
using Examination.Domain.SeedWorks;

namespace Examination.Domain.AggregateModels.UserAggregate;

public interface IUserRepository : IRepositoryBase<User>
{
    Task<User> GetUserByIdAsync(string externalId);
}