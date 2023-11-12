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
            modelBuilder.Entity<Ticket>().HasIndex(t => t.Id).IsUnique();
        }


        public DbSet<Ticket> Tickets { get; set; }
    }
}

