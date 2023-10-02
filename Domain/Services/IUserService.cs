namespace BrotaAPI.Domain.Services
{
    public interface IUserService
    {
        public Task<User> CreateUser(User user);
        public Task<User> UpdateUser(User user);
        public Task<IEnumerable<User>> ListUsers();
        public Task<User> GetUserById(string email);
        public Task<User> GetUserByEmail(string email);
        public Task<bool> DeleteUser(User user);

    }
}
