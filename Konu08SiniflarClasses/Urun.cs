namespace Konu08SiniflarClasses
{
    internal class Urun
    {
        // class içinde değişken-field kullanımı
        internal int Id;
        internal string Adi;
        internal decimal Fiyati;
        // class içinde property kullanımı
        public string UrunAciklamasi { get; set; }
        public string Markasi { get; set; }
        public bool Durum { get; set; }
        public int KategoriId { get; set; } // ürünün hangi kategoriye ait olduğu bilgisini tutar
        public Kategori? Kategori { get; set; } // navigation property ürün ve kategori arasında ilişki kurar.
    }
}
