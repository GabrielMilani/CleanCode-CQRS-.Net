using CleanCode.Domain.Interfaces;
using CleanCode.Persistence.Context;

namespace CleanCode.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Commit(CancellationToken cancellationToken)
    {
        return (await _context.SaveChangesAsync(cancellationToken) > 0);
    }
}