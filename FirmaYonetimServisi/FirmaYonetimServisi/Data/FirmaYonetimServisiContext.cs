using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirmaYonetimServisi.Models;

namespace FirmaYonetimServisi.Data
{
    public class FirmaYonetimServisiContext : DbContext
    {
        public FirmaYonetimServisiContext (DbContextOptions<FirmaYonetimServisiContext> options)
            : base(options)
        {
        }

        public DbSet<FirmaYonetimServisi.Models.Firma> Firma { get; set; } = default!;

        public DbSet<FirmaYonetimServisi.Models.Siparis> Siparis { get; set; }

        public DbSet<FirmaYonetimServisi.Models.Urunler> Urunler { get; set; }
    }
}
