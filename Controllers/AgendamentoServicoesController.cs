using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Models;

namespace PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoServicoesController : ControllerBase
    {
        private readonly PetShopContext _context;

        public AgendamentoServicoesController(PetShopContext context)
        {
            _context = context;
        }

        // GET: api/AgendamentoServicoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgendamentoServico>>> GetAgendamentoServico()
        {
            return await _context.AgendamentoServico.ToListAsync();
        }

        // GET: api/AgendamentoServicoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AgendamentoServico>> GetAgendamentoServico(int id)
        {
            var agendamentoServico = await _context.AgendamentoServico.FindAsync(id);

            if (agendamentoServico == null)
            {
                return NotFound();
            }

            return agendamentoServico;
        }

        // PUT: api/AgendamentoServicoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgendamentoServico(int id, AgendamentoServico agendamentoServico)
        {
            if (id != agendamentoServico.AgendamentoServicoId)
            {
                return BadRequest();
            }

            _context.Entry(agendamentoServico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendamentoServicoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AgendamentoServicoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AgendamentoServico>> PostAgendamentoServico(AgendamentoServico agendamentoServico)
        {
            _context.AgendamentoServico.Add(agendamentoServico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgendamentoServico", new { id = agendamentoServico.AgendamentoServicoId }, agendamentoServico);
        }

        // DELETE: api/AgendamentoServicoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgendamentoServico(int id)
        {
            var agendamentoServico = await _context.AgendamentoServico.FindAsync(id);
            if (agendamentoServico == null)
            {
                return NotFound();
            }

            _context.AgendamentoServico.Remove(agendamentoServico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AgendamentoServicoExists(int id)
        {
            return _context.AgendamentoServico.Any(e => e.AgendamentoServicoId == id);
        }
    }
}
