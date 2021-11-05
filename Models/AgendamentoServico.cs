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
    public class AgendamentoServico
    {
        [Key]
        public int AgendamentoServicoId { get; set; }
        [ForeignKey("AgendamentoId")]
        public int AgendamentoId { get; set; }
        public virtual Agendamento Agendamento { get; set; }
        [ForeignKey("ServicoId")]
        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }
        public int QtdServico { get; set; }
        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal ValorTotal { get; set; }
    }
}
