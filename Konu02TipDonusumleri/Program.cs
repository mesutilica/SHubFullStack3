namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 02 Tip Donusumleri!");
            // Implicit Casting - Otomatik dönüşüm
            // Explicit Casting - Manuel dönüşüm
            Console.WriteLine("Implicit Casting - Otomatik dönüşüm");
            Console.WriteLine("Implicit Casting de daha küçük boyutlu bir türü daha büyük bir boyut türüne geçirirken dönüşüm otomatik olarak yapılır");
            int sayi = 18;
            double kesirliSayi = sayi; // int türündeki değeri double taşıyabilir.
            Console.WriteLine("sayi değeri:");
            Console.WriteLine(sayi);
            Console.WriteLine("kesirliSayi değeri:");
            Console.WriteLine(kesirliSayi);

            Console.WriteLine();
            Console.WriteLine("Explicit Casting - Manuel dönüşüm");
            double kesirliSayi2 = 18;
            int tamsayi = (int)kesirliSayi2;
            Console.WriteLine("kesirliSayi2:");
            Console.WriteLine(kesirliSayi2);
            Console.WriteLine("tamsayi:");
            Console.WriteLine(tamsayi);
            Console.WriteLine();

            Console.WriteLine("Diğer Tür Dönüştürme Yöntemleri");
            int tamSayi2 = 10;
            double kesirliSayi3 = 5.25;
            bool islemSonuc = true;

            Console.WriteLine("Lütfen Bir Sayı Giriniz:");
            var girilenDeger = Console.ReadLine();
            Console.WriteLine("girilen Degerin veri tipi: ");
            Console.WriteLine(girilenDeger.GetType());

            var parsayi = int.Parse(girilenDeger); // int.Parse metodu kendisine verilen string değerin tırnaklarını kaldırarak int tipine çevirir
            Console.WriteLine(parsayi + tamsayi);
            Console.WriteLine(double.Parse(girilenDeger) + kesirliSayi3);
            Console.WriteLine(decimal.Parse(girilenDeger) + tamSayi2);
            Console.WriteLine();

            Console.WriteLine("Convert sınıfı metotlarıyla tip dönüştürme");
            Console.WriteLine(tamSayi2.GetType()); // tamSayi2 nin veri tipini yazdır
            Console.WriteLine(Convert.ToString(tamSayi2).GetType()); // tamSayi2 yi string e çevir ve tipini doğrulamak için ekrana yazdır.
            Console.WriteLine(Convert.ToDouble(tamSayi2).GetType());
            Console.WriteLine(Convert.ToInt32(kesirliSayi3).GetType());
            Console.WriteLine(Convert.ToString(islemSonuc).GetType());

            Console.WriteLine();

            object nesne = "123456";
            Console.WriteLine("nesne nin veri tipi: " + nesne.GetType());
            nesne = Convert.ToDecimal(nesne); // nesne decimal e çevrildi
            Console.WriteLine("nesne nin veri tipi: " + nesne.GetType());
            Console.WriteLine("nesne nin değeri: " + nesne);
        }
    }
}
