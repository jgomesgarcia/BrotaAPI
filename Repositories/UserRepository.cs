namespace BrotaAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BrotaDataContext BrotaContext;
        public UserRepository(BrotaDataContext context)
            => (BrotaContext) = (context);

        public async Task<User> CreateUser(User user)
        {
            try
            {
                BrotaContext.AddAsync(user);
                BrotaContext.SaveChanges();

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível cadastra a o usuário ");
            }
        }
    }
}
