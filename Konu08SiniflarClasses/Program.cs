namespace Konu08SiniflarClasses
{
    internal class Ev // sınıf tanımlama
    {
        internal string sokakAdi;
        internal int kapiNo;
    }
    /*
            Erişim belirteçleri 4 ana sınıfa ayrılır
         public     : Erişim kısıtı yoktur, her yerden erişilebilir.
         protected  : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
         internal   : Etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez
         private    : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
     */
    public class deneme
    {
        public string UrunAdi = "public öğeye herkes ulaşabilir";
        protected class test
        {
            string UrunAdi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu08SiniflarClasses");
            #region Örnek1
            Ev ilkEv = new Ev(); // soyut bir yapı olan ev sınıfından ilkev adında somut bir nesne oluşturduk.
            ilkEv.sokakAdi = "Pınar sk.";
            ilkEv.kapiNo = 10;

            Console.WriteLine("ilkEv sokakAdi: " + ilkEv.sokakAdi);
            Console.WriteLine("ilkEv kapiNo: " + ilkEv.kapiNo);

            Console.WriteLine();

            Ev yazlikEv = new();

            yazlikEv.sokakAdi = "Deniz sk.";
            yazlikEv.kapiNo = 18;

            Console.WriteLine("yazlikEv sokakAdi: " + yazlikEv.sokakAdi);
            Console.WriteLine("yazlikEv kapiNo: " + yazlikEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new()
            {
                kapiNo = 25,
                sokakAdi = "Maho ağa sokak."
            };

            Console.WriteLine("koyEvi sokakAdi: " + koyEvi.sokakAdi);
            Console.WriteLine("koyEvi kapiNo: " + koyEvi.kapiNo);

            Console.WriteLine();
            #endregion

            #region Örnek 2
            Kullanici kullanici = new()
            {
                Adi = "Murat",
                Soyadi = "Yılmaz",
                KullaniciAdi = "murt",
                Sifre = "m123",
                Id = 1
            };

            Console.WriteLine("Kullanıcı adınız:");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz:");
            var sifre = Console.ReadLine();

            if (kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                // sisteme giriş yap
                Console.WriteLine($"Hoşgeldin {kullanici.Adi} {kullanici.Soyadi}");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!");
            }
            #endregion
        }
    }
    class Kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;
    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
        internal int ModelYili;
    }
}
