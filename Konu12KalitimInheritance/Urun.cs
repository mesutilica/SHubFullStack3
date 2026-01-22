namespace Konu12KalitimInheritance
{
    public class Urun : OrtakOzellikler
    {
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public int Kdv { get; set; }
        public int Iskonto { get; set; }
        public string? TeknikOzellikler { get; set; } // ürün eklerken teknik özellikler boş geçilebilsin diye 
    }
}
