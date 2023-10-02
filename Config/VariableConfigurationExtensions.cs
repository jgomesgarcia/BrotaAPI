namespace BrotaAPI.Persistance.Config
{
    public static class VariableConfigurationExtensions
    {
        public static string GetConnectionStringBrotaDB(this IConfiguration _)
        {
            try
            {
                var value = Environment.GetEnvironmentVariable("CONNECTION_STRING_BROTADB");

                return value is null
                    ? throw new NullReferenceException("Váriavel de ambiente \"CONNECTION_STRING_BROTADB\" está nula.")
                    : value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
