namespace Examination.Domain.SeedWorks;

public interface IRepositoryBase<T> where T : IAggregateRoot
{
    Task InsertAsync(T obj);

    Task UpdateAsync(T obj);

    Task DeleteAsync(string id);

    void StartTransaction();

    Task CommitTransactionAsync(T entity, CancellationToken cancellationToken = default);

    Task AbortTransactionAsync(CancellationToken cancellationToken = default);
}