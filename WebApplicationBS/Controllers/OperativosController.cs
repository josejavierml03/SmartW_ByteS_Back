using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationBS.Context;
using WebApplicationBS.Models;

namespace WebApplicationBS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperativosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OperativosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Operativos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OperativoDTO>>> GetOperativos()
        {
            return await _context.Operativos.Include( Op => Op.Misiones).Select( Op => new OperativoDTO (Op)).ToListAsync();
        }

        // GET: api/Operativos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Operativo>> GetOperativo(string id)
        {
            var operativo = await _context.Operativos.FindAsync(id);

            if (operativo == null)
            {
                return NotFound();
            }

            return operativo;
        }

        // PUT: api/Operativos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOperativo(string id, Operativo operativo)
        {
            if (id != operativo.Nombre)
            {
                return BadRequest();
            }

            _context.Entry(operativo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperativoExists(id))
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

        // POST: api/Operativos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Operativo>> PostOperativo(Operativo operativo)
        {
            _context.Operativos.Add(operativo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOperativo", new { id = operativo.Nombre }, operativo);
        }

        // DELETE: api/Operativos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOperativo(string id)
        {
            var operativo = await _context.Operativos.FindAsync(id);
            if (operativo == null)
            {
                return NotFound();
            }

            _context.Operativos.Remove(operativo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OperativoExists(string id)
        {
            return _context.Operativos.Any(e => e.Nombre == id);
        }
    }
}
