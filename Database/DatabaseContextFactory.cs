using Microsoft.EntityFrameworkCore;

namespace PharmacyHome.Database
{
    public class DatabaseContextFactory : IDbContextFactory<DatabaseContext>
    {
        private readonly string connectionString;
        public DatabaseContextFactory(IConfiguration configuration)
        {
            connectionString = configuration["DatabaseConnectionString"];
        }
        public DatabaseContext CreateDbContext()
        {
            return new DatabaseContext(BuildOptions(connectionString));
        }
        private DbContextOptions<DatabaseContext> BuildOptions(string connection)
        {
            var builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseNpgsql(connection);
            return builder.Options;
        }
    }
}
