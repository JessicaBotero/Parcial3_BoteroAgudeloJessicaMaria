using System.ComponentModel.DataAnnotations;

namespace Parcial3_BoteroAgudeloJessicaMaria.DAL.Entities
{
    public class Ticket : Entity
    {
        [Display(Name = "Id Ticket")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Id { get; set; }

        [Display(Name = "Fecha de Uso")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Boleta en uso")]
        public bool? IsUsed { get; set; }

        [Display(Name = "Porteria de entrada (Norte, Sur, Oriental, Occidental)")]
        public String? EntranceGate { get; set; }
    }
}
