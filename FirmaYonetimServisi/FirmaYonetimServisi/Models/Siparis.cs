namespace FirmaYonetimServisi.Models
{
    public class Siparis
    {
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public string? UrunAdi { get; set; }
        public string? SiparisVerenKisininAdi { get; set; }
        public DateTime SiparisTarihi { get; set; }
    }
}
