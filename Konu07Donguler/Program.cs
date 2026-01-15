namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu07Donguler");

            Console.WriteLine("1-For Döngüsü");
            for (int i = 0; i < 5; i++) //i değişkeni oluştur ve 0 değerini ata; i 5 den küçük olduğu sürece dön; her dönüşte i yi 1 artır i++ ile
            {
                Console.WriteLine("i değişkeninin değeri: {0}", i);
            }
            Console.WriteLine();

            Console.WriteLine("2-While Döngüsü");
            int j = 0; // dışarıda bir değişken tanımlıyoruz
            while (j < 5) // j 5 ten küçük olduğu sürece dön
            {
                Console.WriteLine("j değişkeninin değeri: {0}", j);
                j++;
            }

            Console.WriteLine();

            Console.WriteLine("3-Do While Döngüsü");

            int toplam = 5;
            do
            {
                Console.WriteLine("toplam ın değeri: " + toplam); // önce kod çalışır
                toplam++;
            }
            while (toplam < 5); // sonra şarta bakar

            Console.WriteLine();

            Console.WriteLine("4-Foreach Döngüsü");

            string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon", "Beyaz Eşya", "Kitap" };

            Console.WriteLine("kategoriler: ");
            foreach (string item in kategoriler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("İç içe döngü kullanımı:");

            string[] urunler = { "Ürün 1", "Ürün 2", "Ürün 3" }; // elimizde örnek ürün listesi var

            foreach (var kategori in kategoriler) // kategoriler isimli dizide dönüyoruz
            {
                Console.WriteLine(kategori); // kategoriler dizisindeki her kategoriyi burada ekrana yaz
                foreach (string item in urunler) // ekrana kategori adını yazdıktan sonra urunler isimli dizide dön 
                {
                    Console.WriteLine("\t " + item); // ve listedeki ürünleri tek tek ekrana yazdır.
                }
            }

            Console.WriteLine();

            Console.WriteLine("İç içe for döngüsü:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("1. döngüdeki i nin değeri : " + i);
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine("\t 2. döngüdeki k nin değeri : " + k);
                }
            }

        }
    }
}
