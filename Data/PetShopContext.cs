using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Data
{
    public class PetShopContext : DbContext
    {
        public PetShopContext (DbContextOptions<PetShopContext> options)
            : base(options)
        {
        }

        public DbSet<PetShop.Models.Cliente> Clientes { get; set; }

        public DbSet<PetShop.Models.Raca> Racas { get; set; }

        public DbSet<PetShop.Models.Animal> Animal { get; set; }

        public DbSet<PetShop.Models.Agendamento> Agendamento { get; set; }

        public DbSet<PetShop.Models.Pagamento> Pagamento { get; set; }

        public DbSet<PetShop.Models.AgendamentoServico> AgendamentoServico { get; set; }

        public DbSet<PetShop.Models.Servico> Servico { get; set; }


        
    }
}
