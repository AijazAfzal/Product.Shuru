using Domain.Entity;
using Domain.IRepository;
using Infrastructure.Clients;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddUserAync(User user)
        {
            await _appDbContext.Users.AddAsync(user);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _appDbContext.Users.ToListAsync();
        }
    }
}
