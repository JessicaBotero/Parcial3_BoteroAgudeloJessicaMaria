using Microsoft.EntityFrameworkCore;
using Parcial3_BoteroAgudeloJessicaMaria.DAL.Entities;
using System.Diagnostics.Metrics;

namespace Parcial3_BoteroAgudeloJessicaMaria.DAL
{
    public class DataBaseContext : DbContext
    {
        
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<EntranceGate>().HasIndex(c => c.Name).IsUnique();
        }

        
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<EntranceGate> EntranceGates { get; set; }
}
    }
}
}
