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
    public class SiparisController : ControllerBase
    {
        private readonly FirmaYonetimServisiContext _context;

        public SiparisController(FirmaYonetimServisiContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Sipariş Oluşturma
        /// </summary>
        /// <param name="siparis"></param>
        /// <returns></returns>
        // POST: api/Siparis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Siparis>> PostSiparis(Siparis siparis)
        {
            _context.Siparis.Add(siparis);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSiparis", new { id = siparis.Id }, siparis);
        }
    }
}
