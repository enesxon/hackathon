using System.Collections.Generic;
using System.Globalization;

namespace FirmaYonetimServisi.Models
{
    public class Firma
    {
        public int Id { get; set; }
        public string? FirmaAdi { get; set; }
        public bool OnayDurumu { get; set; }
        public DateTime SiparisIzinBaslangicSaati { get; set; }
        public DateTime SiparisIzinBitisSaati { get; set; }
    }
}
