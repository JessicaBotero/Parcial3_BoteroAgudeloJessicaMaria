﻿using System.ComponentModel.DataAnnotations;

namespace Parcial3_BoteroAgudeloJessicaMaria.DAL.Entities
{
    public class Tickets
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de Uso")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Boleta en uso")]
        public bool? IsUsed { get; set; }

        [Display(Name = "Porteria de entrada")]
        public List<EntranceGate>? EntranceGate { get; set; }
    }
}
