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
    public class MisionesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MisionesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Misiones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mision>>> GetMisiones()
        {
            return await _context.Misiones.ToListAsync();
        }

        // GET: api/Misiones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mision>> GetMision(string id)
        {
            var mision = await _context.Misiones.FindAsync(id);

            if (mision == null)
            {
                return NotFound();
            }

            return mision;
        }

        // PUT: api/Misiones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMision(string id, Mision mision)
        {
            if (id != mision.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(mision).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MisionExists(id))
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

        // POST: api/Misiones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mision>> PostMision(MisionDTO mision)
        {
            Mision misionAux = new Mision() { Codigo = mision.Codigo, Descripcion = mision.Descripcion, 
                Estado = mision.Estado, NombreOperativo = mision.NombreOperativo};
            _context.Misiones.Add(misionAux);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMision", new { id = mision.Codigo }, mision);
        }

        // DELETE: api/Misiones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMision(string id)
        {
            var mision = await _context.Misiones.FindAsync(id);
            if (mision == null)
            {
                return NotFound();
            }

            _context.Misiones.Remove(mision);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MisionExists(string id)
        {
            return _context.Misiones.Any(e => e.Codigo == id);
        }
    }
}
