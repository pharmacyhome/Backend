using Microsoft.EntityFrameworkCore;
using PharmacyHome.Database;

namespace PharmacyHome.Services
{
    public class DatabaseService : IDatabase
    {
        private readonly IConfiguration _configuration;
        private readonly IDbContextFactory<DatabaseContext> _dbContext;
        public DatabaseService(
            IConfiguration configuration, 
            IDbContextFactory<DatabaseContext> dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;

            using (var ctx = _dbContext.CreateDbContext())
            {
                string databaseName = ctx.Database.GetDbConnection().Database;
                Console.WriteLine($"Database {databaseName} has been initialized");
            }
        }
    }
}
