using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Raca
    {
        [Key]
        public int RacaId { get; set; }
        [Required(ErrorMessage = "Uma Raça é obrigatório!")]
        [Column(TypeName = "nvarchar(50)")]
        public string NomeRaca { get; set; }
        public string PaisOrigem { get; set; }
    }
}
