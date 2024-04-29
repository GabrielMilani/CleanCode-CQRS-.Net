using CleanCode.Domain.Entities;
using CleanCode.Domain.Interfaces;
using CleanCode.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanCode.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }
}