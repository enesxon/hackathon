namespace FirmaYonetimServisi.Models
{
    public class Urunler
    {
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public String? UrunAdi { get; set; }
        public int Stok { get; set; }
        public double Fiyat { get; set; }
    }
}
