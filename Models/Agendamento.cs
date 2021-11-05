using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Agendamento
    {
        [Key]
        public int AgendamentoId { get; set; }
        public DateTime DataHora { get; set; }
        public string Servicos { get; set; }
        [ForeignKey("AnimalId")]
        public string AnimalId { get; set; }
        public virtual Animal Animal { get; set; }
    }
}
