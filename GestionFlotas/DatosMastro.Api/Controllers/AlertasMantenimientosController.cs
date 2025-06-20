using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestionFlotas;

namespace DatosMastro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertasMantenimientosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlertasMantenimientosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/AlertasMantenimientos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlertaMantenimiento>>> GetAlertasMantenimientos()
        {
            return await _context.AlertasMantenimientos.ToListAsync();
        }

        // GET: api/AlertasMantenimientos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlertaMantenimiento>> GetAlertaMantenimiento(int id)
        {
            var alertaMantenimiento = await _context.AlertasMantenimientos.FindAsync(id);

            if (alertaMantenimiento == null)
            {
                return NotFound();
            }

            return alertaMantenimiento;
        }

        // PUT: api/AlertasMantenimientos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlertaMantenimiento(int id, AlertaMantenimiento alertaMantenimiento)
        {
            if (id != alertaMantenimiento.AlertaMantenimientoId)
            {
                return BadRequest();
            }

            _context.Entry(alertaMantenimiento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlertaMantenimientoExists(id))
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

        // POST: api/AlertasMantenimientos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AlertaMantenimiento>> PostAlertaMantenimiento(AlertaMantenimiento alertaMantenimiento)
        {
            _context.AlertasMantenimientos.Add(alertaMantenimiento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlertaMantenimiento", new { id = alertaMantenimiento.AlertaMantenimientoId }, alertaMantenimiento);
        }

        // DELETE: api/AlertasMantenimientos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlertaMantenimiento(int id)
        {
            var alertaMantenimiento = await _context.AlertasMantenimientos.FindAsync(id);
            if (alertaMantenimiento == null)
            {
                return NotFound();
            }

            _context.AlertasMantenimientos.Remove(alertaMantenimiento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlertaMantenimientoExists(int id)
        {
            return _context.AlertasMantenimientos.Any(e => e.AlertaMantenimientoId == id);
        }
    }
}
