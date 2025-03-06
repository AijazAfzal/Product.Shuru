using Domain.Entity;

namespace Domain.IRepository
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
        Task AddUserAync(User user);
    }
}
