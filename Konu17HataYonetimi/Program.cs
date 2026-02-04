namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu17HataYonetimi");
            Console.WriteLine();
            Console.WriteLine("Kdv Hesaplamak İçin Fiyat Giriniz :");
            var fiyat = Console.ReadLine();
            // KdvHesapla(double.Parse(fiyat));
            try // try tab tab yaparak try catch bloğu oluşturuyoruz.
            {
                // try bloğu kodumuzu deneyeceğimiz alandır.
                KdvHesapla(double.Parse(fiyat)); // metodu çalıştırmayı dene
            }
            catch (Exception hata) // eğer try bloğunda hata oluşursa o zaman catch bloğu çalışır!
            { //Exception a bir isim vererek hatayı yakalayabilriz. 
                Console.WriteLine("Hata Oluştu! Lütfen sadece sayısal değer giriniz!");

                Console.WriteLine(hata.Message); // hata nesnesi içinde hata detayları yer alır.
                // ayrıca uygulamalarda hata oluşursa oluşan hatalar veritabanı veya fiziksel bir dosyaya kaydedilir, bu işleme loglama denir.
                throw; // throw yine hata fırlatılmasını sağlar
            }
            finally // isteğe bağlı son blok
            {
                Console.WriteLine("try catch bloğundan sonra her seferinde çalışmasını istediğimiz bir işlem varsa bu blokta çalıştırabiliriz. Kullanımı zorunlu değildir.");
                Console.WriteLine("Kdv Hesaplamak İçin Fiyat Giriniz :");
                var fiyat2 = Console.ReadLine();
                KdvHesapla(double.Parse(fiyat2));
            }
        }
        static void KdvHesapla(double fiyat)
        {
            Console.WriteLine("Fiyat: " + fiyat);
            Console.WriteLine("Kdv: " + (fiyat * 0.20));
            Console.WriteLine("Kdv Dahil Toplam Tutar: " + (fiyat + (fiyat * 0.20)));
        }
    }
}
