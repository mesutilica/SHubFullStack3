namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu04 Karar Yapilari!");
            /*
            Console.WriteLine("Bir Sayı Giriniz:");

            var sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0) // eğer girilen sayı 0 dan büyükse
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else if (sayi < 0) // yukardaki şart değilse eğer
            {
                Console.WriteLine("Sayı Negatif");
            }
            else
            {
                Console.WriteLine("Sayı sıfır");
            }
            
            Console.WriteLine("Kullanıcı adınız:");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz:");
            var sifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && sifre == "a123")
            {
                Console.WriteLine("Giriş Başarılı!");
                Console.WriteLine("Hoşgeldin Admin");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!");
            }
            */
            int saat = DateTime.Now.Hour;
            if (saat < 18)
            {
                Console.WriteLine("İyi Günler, saat: " + saat);
            }
            else
                Console.WriteLine("İyi Akşamlar, saat: " + saat);

            Console.WriteLine("switch case yapısı ile akış kontrolü");
            int ay = DateTime.Now.Month;
            Console.WriteLine("Bulunduğumuz ay: " + ay);
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış"); // Yukarıdaki şartlarla eşleşiyorsa
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar");
                    break;
                default:
                    Console.WriteLine("Bir sorun oluştu!");
                    break;
            }
        }
    }
}
