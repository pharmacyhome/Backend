using Microsoft.EntityFrameworkCore;

using PharmacyHome.Types;

namespace PharmacyHome.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserDB> Users { get; set; }
        public DbSet<MedicineDB> Medicines { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserDB>()
                .HasKey(u => u.Id);
            builder.Entity<UserDB>()
                .Property(typeof(string), nameof(UserDB.FirstName))
                .IsRequired(false);
            builder.Entity<UserDB>()
                .Property(typeof(string), nameof(UserDB.LastName))
                .IsRequired(false);


            builder.Entity<MedicineDB>()
                .HasKey(m => m.Id);

            var userDBCol = new UserDB[]
            {
                new UserDB()
                {
                    Id = Guid.NewGuid(),
                    Login = "Administrator",
                    PasswordHash = "Administrator",
                    AccessLevel = AccessLevel.Administrator
                },
                new UserDB()
                {
                    Id = Guid.NewGuid(),
                    Login = "SuperAdmin",
                    PasswordHash = "SuperAdmin",
                    AccessLevel = AccessLevel.SuperAdmin
                }
            };

            builder.Entity<UserDB>()
                .HasData(userDBCol);
        }
    }
}
