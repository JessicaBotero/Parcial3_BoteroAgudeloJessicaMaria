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
            base.OnModelCreating(modelBuilder);;
        }


        public DbSet<Ticket> Tickets { get; set; }
    }
}

