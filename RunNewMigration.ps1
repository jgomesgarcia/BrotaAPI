$env:CONNECTION_STRING_BROTADB = 'User ID=postgres;Password=JOao2458;Host=localhost;Port=2458;Database=BROTA_DEV';

dotnet ef migrations add ConfigureMappers;

dotnet ef database update;