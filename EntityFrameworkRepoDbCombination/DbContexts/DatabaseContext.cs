using EntityFrameworkRepoDbCombination.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkRepoDbCombination.DbContexts
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.LazyLoadingEnabled = true;
        }

        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=sakila;Integrated Security=SSPI;TrustServerCertificate=true;");
        }
    }
}
