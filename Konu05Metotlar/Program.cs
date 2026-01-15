namespace Konu05Metotlar
{
    internal class Program
    {
        static void ToplamaYap() // metot tanımlama
        {
            // void olan metotlar geriye değer döndürmeyen metotlardır
            Console.WriteLine(10 + 8);
        }
        static void Main(string[] args)
        {
            ToplamaYap();
            Console.WriteLine("Konu05 Metotlar!");
            Console.WriteLine();
            ToplamaYap(10, 8);
            Console.WriteLine();
            Console.WriteLine("Geriye değer döndüren metot:");
            int sonuc = ToplamaYap(6, 6, 6);
            Console.WriteLine("Sayıların toplamı: " + sonuc);
            Console.WriteLine();
            Console.WriteLine("Email giriniz:");
            var email = Console.ReadLine();
            var mailGonderildimi = MailGonder(email);
            if (mailGonderildimi == true)
            {
                Console.WriteLine("Mail başarıyla gönderildi..");
            }
            else
                Console.WriteLine("Mail gönderilemedi!");
        }
        static void ToplamaYap(int sayi1, int sayi2) // parametreli metot tanımlama
        {
            Console.WriteLine(sayi1 + sayi2); // methoda gönderilen değerleri topla
        }
        static int ToplamaYap(int sayi1, int sayi2, int sayi3) // parametreli değer döndüren metot tanımlama
        {
            return sayi1 + sayi2 + sayi3; // methoda gönderilen değerleri topla
        }
        static bool MailGonder(string mailAdresi)
        {
            if (!string.IsNullOrEmpty(mailAdresi))
            {
                // burada mail gönderimi yapılabilir
                return true;
            }
            return false;
        }
    }
}