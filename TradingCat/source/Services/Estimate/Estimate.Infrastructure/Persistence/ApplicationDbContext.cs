using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Estimate.Application.Common.Interfaces;
using Estimate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estimate.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        // public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyType> CurrencyTypes { get; set; }
        // public DbSet<TradeHistory> TradeHistories { get; set; }
        // public DbSet<TradeType> TradeTypes { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedDate = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.DeletedDate = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}