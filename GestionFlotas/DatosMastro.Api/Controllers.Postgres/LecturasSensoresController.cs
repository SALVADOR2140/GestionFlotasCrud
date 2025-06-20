using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatosMastro.Api.Data;
using GestionFlotas;

namespace DatosMastro.Api.Controllers.Postgres
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturasSensoresController : ControllerBase
    {
        private readonly SensorDbContext _context;

        public LecturasSensoresController(SensorDbContext context)
        {
            _context = context;
        }

        // GET: api/LecturasSensores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LecturaSensor>>> GetLecturasSensores()
        {
            return await _context.LecturasSensores.ToListAsync();
        }

        // GET: api/LecturasSensores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LecturaSensor>> GetLecturaSensor(int id)
        {
            var lecturaSensor = await _context.LecturasSensores.FindAsync(id);

            if (lecturaSensor == null)
            {
                return NotFound();
            }

            return lecturaSensor;
        }

        // PUT: api/LecturasSensores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLecturaSensor(int id, LecturaSensor lecturaSensor)
        {
            if (id != lecturaSensor.LecturaSensorId)
            {
                return BadRequest();
            }

            _context.Entry(lecturaSensor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LecturaSensorExists(id))
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

        // POST: api/LecturasSensores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LecturaSensor>> PostLecturaSensor(LecturaSensor lecturaSensor)
        {
            _context.LecturasSensores.Add(lecturaSensor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLecturaSensor", new { id = lecturaSensor.LecturaSensorId }, lecturaSensor);
        }

        // DELETE: api/LecturasSensores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLecturaSensor(int id)
        {
            var lecturaSensor = await _context.LecturasSensores.FindAsync(id);
            if (lecturaSensor == null)
            {
                return NotFound();
            }

            _context.LecturasSensores.Remove(lecturaSensor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LecturaSensorExists(int id)
        {
            return _context.LecturasSensores.Any(e => e.LecturaSensorId == id);
        }
    }
}
