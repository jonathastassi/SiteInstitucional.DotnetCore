using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteInstitucional.Domain;

namespace SiteInstitucional.Infra
{
    public class DatabaseContext : DbContext, IUnitOfWork
    {
        public DbSet<Portfolio> Portfolios { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
