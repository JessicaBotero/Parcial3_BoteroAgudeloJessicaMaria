using Parcial3_BoteroAgudeloJessicaMaria.DAL.Entities;
using System.Diagnostics.Metrics;

namespace Parcial3_BoteroAgudeloJessicaMaria.DAL
{
    public class SeederDB
    {
        private readonly DataBaseContext _context;

        public SeederDB(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {

            await _context.Database.EnsureCreatedAsync();

            PopulateTicketsAsync();

            await _context.SaveChangesAsync();
        }


        private void PopulateTicketsAsync()
        {

            {
                if (!_context.Tickets.Any())
                {
                    for (int i = 1; i <= 1000; i++)
                    {
                        _context.Tickets.Add(new Entities.Ticket
                        {
                            Id = i,
                            UseDate = null,
                            IsUsed = false,
                            EntranceGate = null,
                            CreateDate = DateTime.Now,
                        }
                        );
                    }

                }
            }
        }
    }

}
