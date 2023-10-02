namespace BrotaAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository UserRepository;
        public UserService(IUserRepository userRepository)
            => (UserRepository) = (userRepository);
        public async Task<User> CreateUser(User user)
        {
            return await UserRepository.CreateUser(user);
        }

        public async Task<bool> DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserById(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> ListUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
