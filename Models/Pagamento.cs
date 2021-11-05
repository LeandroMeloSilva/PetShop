using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Models;

namespace PetShop.Models
{
    public class Pagamento
    {
        [Key]
        public int PagamentoId { get; set; }
        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal ValorTotal { get; set; }
        [ForeignKey("ClienteId")]
        public string ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
