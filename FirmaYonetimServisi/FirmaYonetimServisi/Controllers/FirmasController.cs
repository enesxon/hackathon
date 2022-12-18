using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirmaYonetimServisi.Data;
using FirmaYonetimServisi.Models;

namespace FirmaYonetimServisi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmasController : ControllerBase
    {
        private readonly FirmaYonetimServisiContext _context;

        public FirmasController(FirmaYonetimServisiContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Firma Listeleme
        /// </summary>
        /// <returns></returns>
        // GET: api/Firmas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Firma>>> GetFirma()
        {
            return await _context.Firma.ToListAsync();
        }

        /// <summary>
        /// Firma Güncelleme
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firma"></param>
        /// <returns></returns>
        // PUT: api/Firmas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFirma(int id, Firma firma)
        {
            if (id != firma.Id)
            {
                return BadRequest();
            }

            _context.Entry(firma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FirmaExists(id))
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

        /// <summary>
        /// Firma Ekleme
        /// </summary>
        /// <param name="firma"></param>
        /// <returns></returns>
        // POST: api/Firmas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Firma>> PostFirma(Firma firma)
        {
            _context.Firma.Add(firma);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFirma", new { id = firma.Id }, firma);
        }

        private bool FirmaExists(int id)
        {
            return _context.Firma.Any(e => e.Id == id);
        }
    }
}
