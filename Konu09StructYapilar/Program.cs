namespace Konu09StructYapilar
{
    public struct Yapi
    {
        // public struct ad = "ali"; // struct kullanımında class dan farklı olarak öğelere başlangıç değeri atanamaz
        public int sayi;
        public string metin;
        public int MyProperty { get; set; }
        public void Metot()
        {
            Console.WriteLine("yapı içindeki metot çalıştı");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu09StructYapilar");
            Yapi yapi = new Yapi();
            yapi.metin = "yapı metni";
            yapi.sayi = 1;
            yapi.Metot();
            Console.WriteLine(yapi.metin);
        }
    }
}
