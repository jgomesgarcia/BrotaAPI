namespace BrotaAPI.Config
{
    public class BrotaDataContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<User> Users { get; set; }

        public BrotaDataContext(IConfiguration configuration) 
            => (_configuration) = (configuration);

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options
                .UseNpgsql(_configuration.GetConnectionString("BrotaDB")
                , assembly => assembly.MigrationsAssembly(typeof(BrotaDataContext).Assembly.FullName))
                .UseSnakeCaseNamingConvention();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
