namespace Konu13KapsullemeEncapsulation
{
    internal class Bolum
    {
        private string BolumAdi; // dışarıdan erişime kapalı değişkenimiz.
        public string GetBolumAdi() // dışarıya string veri gönderen metot
        {
            return BolumAdi; // GetBolumAdi çağrılınca BolumAdi değişken değerini yolla
        }
        public void SetBolumAdi(string istenenEgitim)
        {
            if (istenenEgitim == "Yazılım Eğitimi")
            {
                BolumAdi = istenenEgitim; // Mutator (setter) seçilen eğitime izin verildi.
            }
            else
            {
                Console.WriteLine("Kurumumuzda bu eğitim verilmemektedir!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13 Kapsulleme Encapsulation");
            Console.WriteLine("Metot ile Kapsulleme");
            Bolum bolum = new Bolum();
            Console.WriteLine("Hangi alanda eğitim almak istersiniz?");
            var bolumAdi = Console.ReadLine();
            bolum.SetBolumAdi(bolumAdi);
            Console.WriteLine("Bölüm: " + bolum.GetBolumAdi());
        }
    }
}
