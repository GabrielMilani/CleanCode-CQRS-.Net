namespace CleanCode.Domain.Interfaces;

public interface IUnitOfWork
{
    Task<bool> Commit(CancellationToken cancellationToken);
}