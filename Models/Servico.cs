using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Servico
    {
        [Key]
        public int ServicoId { get; set; }
        [Required(ErrorMessage = "Descreva um serviço!")]
        [Column(TypeName = "nvarchar(100)")]
        public string Descricao { get; set; }
        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Valor { get; set; }
        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Duracao { get; set; }
    }
}
