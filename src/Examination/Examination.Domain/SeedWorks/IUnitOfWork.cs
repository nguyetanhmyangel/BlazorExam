namespace Examination.Domain.SeedWorks;

public interface IUnitOfWork : IDisposable
{
    Task SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
}