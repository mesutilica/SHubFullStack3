namespace Konu03Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu03 Operatorler");
            Console.WriteLine("1-Aritmetik Operatörler");
            double sayi1 = 3;
            double sayi2 = 4;
            double sayi3 = 5;
            Console.WriteLine();
            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}"); // string tırnağının önüne $ işareti koyarak string interpolasyonu yapıyoruz.
            Console.WriteLine("1234" + sayi3); // string ile int arasında + işlemi yapıldığında toplama yerine birleştirme işlemi yapılır.
            Console.WriteLine();
            Console.WriteLine("Hesaplama İşlemleri:");
            Console.WriteLine("sayi1 + sayi2 : " + (sayi1 + sayi2));
            Console.WriteLine("sayi1 - sayi2 : " + (sayi1 - sayi2));
            Console.WriteLine("sayi1 * sayi2 : " + (sayi1 * sayi2));
            Console.WriteLine("sayi1 / sayi2 : " + (sayi1 / sayi2));
            Console.WriteLine("sayi1 % sayi2 : " + (sayi1 % sayi2));

            Console.WriteLine();

            Console.WriteLine("Artırım ve Azaltım Operatörleri");
            sayi2++; // değişkenin değerini 1 artır
            Console.WriteLine("sayi2: " + sayi2);
            sayi2--; // değeri 1 azalt
            Console.WriteLine("sayi2: " + sayi2);

            Console.WriteLine();

            Console.WriteLine("Atama Operatörleri");
            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
            Console.WriteLine("sayi1 += sayi2 : " + (sayi1 += sayi2));
            Console.WriteLine("sayi1 -= sayi2 : " + (sayi1 -= sayi2));
            Console.WriteLine("sayi1 *= sayi2 : " + (sayi1 *= sayi2));
            Console.WriteLine("sayi1 /= sayi2 : " + (sayi1 /= sayi2));
            Console.WriteLine("sayi1 %= sayi2 : " + (sayi1 %= sayi2));

            Console.WriteLine();

            Console.WriteLine("İlişkisel Operatörler"); // birden fazla değeri karşılaştırıp aralarındaki durumu öğrenmek için kullanırız.
            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
            Console.WriteLine("sayi1 == sayi2 : " + (sayi1 == sayi2));
            Console.WriteLine("sayi1 != sayi2 : " + (sayi1 != sayi2));
            Console.WriteLine("sayi1 > sayi2 : " + (sayi1 > sayi2));
            Console.WriteLine("sayi1 < sayi2 : " + (sayi1 < sayi2));
            Console.WriteLine("sayi1 <= sayi2 : " + (sayi1 <= sayi2));
            Console.WriteLine("sayi1 >= sayi2 : " + (sayi1 >= sayi2));

            Console.WriteLine();

            Console.WriteLine("Ternary Operatörü"); // eğer karşılaştırma için 2 değer kullanacaksak karşılaştırmanın kısayolu olarak kullanırız.
            Console.WriteLine("Ternary: ");
            Console.WriteLine((sayi1 < sayi2) ? "sayılar eşit" : "sayılar eşit değil");

            Console.WriteLine();

            Console.WriteLine("Mantıksal Operatörler");
            Console.WriteLine("And & Operatörü");
            Console.WriteLine("& Operatörü her iki şartın da sağlanmasını ister");

            Console.WriteLine();

            string email = "admin@site.co", sifre = "adm123";
            Console.WriteLine("Email giriniz:");
            var girilenMail = Console.ReadLine();
            Console.WriteLine("Şifre giriniz:");
            var girilenSifre = Console.ReadLine();

            Console.WriteLine();

            // Console.WriteLine(girilenMail == email && girilenSifre == sifre ? "Giriş Başarılı!" : "Giriş Başarısız!");

            Console.WriteLine();

            Console.WriteLine("Veya | Operatörü");
            Console.WriteLine("| Operatörü her iki şarttan birinin sağlanmasını ister");

            Console.WriteLine();

            Console.WriteLine(girilenMail == email | girilenSifre == sifre ? "Giriş Başarılı!" : "Giriş Başarısız!");
        }
    }
}
