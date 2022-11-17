using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Framework.DataAccess.EF
{
    public class EFContext : DbContext, IDbContext
    {
        private readonly Assembly _mappingAssembly;

        public EFContext(DbContextOptions options, Assembly mappingAssembly) : base(options)
        {
            _mappingAssembly = mappingAssembly;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(_mappingAssembly);
        }

        public EFContext Instance => this;
    }
}
