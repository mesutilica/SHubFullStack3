namespace Konu12KalitimInheritance
{
    class Arac
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Kornaya Basıldı!");
        }
    }
    class Otomobil : Arac // iki nokta üstü üste araç dediğimizde araç sınıfındaki içerikler otomobil sınıfında kullanılabilir.
    {
        public string KasaTipi { get; set; }
        public string YakitTuru { get; set; }
    }
    class Test : Otomobil
    {
        public int MyProperty { get; set; }
    }
    class Tren : Arac
    {
        public int VagonSayisi { get; set; }
    }
    class Otobus : Arac
    {
        public int KoltukSayisi { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu12KalitimInheritance");
            Arac arac = new Arac();
            arac.AracTuru = "Otomobil";
            arac.KornaCal();

            Otomobil otomobil = new Otomobil();
            otomobil.Id = 1;
            otomobil.AracTuru = "Otomobil"; // bu değişken arac sınıfından geliyor
            otomobil.KornaCal(); // bu metot arac sınıfından geliyor
            otomobil.Marka = "Togg";
            otomobil.Model = "T10x";
            Console.WriteLine("otomobil.AracTuru: " + otomobil.AracTuru);
        }
    }
}
