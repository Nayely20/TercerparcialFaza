using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFaza.Data;
using ProyectoFaza.Models;

namespace ProyectoFaza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MueblesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MueblesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Muebles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Muebles>>> GetMuebles()
        {
            return await _context.Muebles.ToListAsync();
        }

        // GET: api/Muebles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Muebles>> GetMuebles(string id)
        {
            var muebles = await _context.Muebles.FindAsync(id);

            if (muebles == null)
            {
                return NotFound();
            }

            return muebles;
        }

        // PUT: api/Muebles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMuebles(string id, Muebles muebles)
        {
            if (id != muebles.Mueble)
            {
                return BadRequest();
            }

            _context.Entry(muebles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MueblesExists(id))
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

        // POST: api/Muebles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Muebles>> PostMuebles(Muebles muebles)
        {
            _context.Muebles.Add(muebles);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MueblesExists(muebles.Mueble))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMuebles", new { id = muebles.Mueble }, muebles);
        }

        // DELETE: api/Muebles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMuebles(string id)
        {
            var muebles = await _context.Muebles.FindAsync(id);
            if (muebles == null)
            {
                return NotFound();
            }

            _context.Muebles.Remove(muebles);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MueblesExists(string id)
        {
            return _context.Muebles.Any(e => e.Mueble == id);
        }
    }
}
