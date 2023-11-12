using System.ComponentModel.DataAnnotations;

namespace Parcial3_BoteroAgudeloJessicaMaria.DAL.Entities
{
    public class Ticket
    {
        [Display(Name = "Id Ticket")]
        public int Id { get; set; }

        [Display(Name = "Fecha de Uso")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Boleta en uso")]
        public bool? IsUsed { get; set; }

        [Display(Name = "Porteria de entrada")]
        public String? EntranceGate { get; set; }
    }
}
