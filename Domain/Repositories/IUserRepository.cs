namespace BrotaAPI.Domain.Repositories
{
    public interface IUserRepository
    {
        public Task<User> CreateUser(User user);
    }
}
