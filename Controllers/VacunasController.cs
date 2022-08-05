using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registro_Efectos_Adversos.Models;

namespace Registro_Efectos_Adversos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacunasController : ControllerBase
    {
        private readonly registro_efectos_adversosContext _context;

        public VacunasController(registro_efectos_adversosContext context)
        {
            _context = context;
        }

        // GET: api/Vacunas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vacuna>>> GetVacunas()
        {
          if (_context.Vacunas == null)
          {
              return NotFound();
          }
            return await _context.Vacunas.ToListAsync();
        }

        // GET: api/Vacunas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vacuna>> GetVacuna(int id)
        {
          if (_context.Vacunas == null)
          {
              return NotFound();
          }
            var vacuna = await _context.Vacunas.FindAsync(id);

            if (vacuna == null)
            {
                return NotFound();
            }

            return vacuna;
        }

        // PUT: api/Vacunas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVacuna(int id, Vacuna vacuna)
        {
            if (id != vacuna.Id)
            {
                return BadRequest();
            }

            _context.Entry(vacuna).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VacunaExists(id))
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

        // POST: api/Vacunas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vacuna>> PostVacuna(Vacuna vacuna)
        {
          if (_context.Vacunas == null)
          {
              return Problem("Entity set 'registro_efectos_adversosContext.Vacunas'  is null.");
          }
            _context.Vacunas.Add(vacuna);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVacuna", new { id = vacuna.Id }, vacuna);
        }

        // DELETE: api/Vacunas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVacuna(int id)
        {
            if (_context.Vacunas == null)
            {
                return NotFound();
            }
            var vacuna = await _context.Vacunas.FindAsync(id);
            if (vacuna == null)
            {
                return NotFound();
            }

            _context.Vacunas.Remove(vacuna);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VacunaExists(int id)
        {
            return (_context.Vacunas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
