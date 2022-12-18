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
    public class UrunlersController : ControllerBase
    {
        private readonly FirmaYonetimServisiContext _context;

        public UrunlersController(FirmaYonetimServisiContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Ürün Ekleme
        /// </summary>
        /// <param name="urunler"></param>
        /// <returns></returns>
        // POST: api/Urunlers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Urunler>> PostUrunler(Urunler urunler)
        {
            _context.Urunler.Add(urunler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUrunler", new { id = urunler.Id }, urunler);
        }
    }
}
