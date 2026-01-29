using System.Collections; // Koleksiyonları kullanabilmek için gerekli kütüphane
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Konu16CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu16CollectionsKoleksiyonlar");
            // Ornek1();
            // Ornek2();
            Ornek3();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new();
            arrayList.Add(1);
            arrayList.Add("iki");
            arrayList.Add(3.0);
            arrayList.Add(true);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList ilk eleman : " + arrayList[0]);// listede index ini verdiğimiz elemana ulaşma
        }
        static void Ornek2()
        {
            ArrayList arrayList = new();
            arrayList.Add("İstanbul");
            arrayList.Add("Ankara");
            arrayList.Add("İzmir");
            arrayList.Add("Sivas");
            arrayList.Add("Çankırı");
            arrayList.Add("Zonguldak");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("ArrayList de sıralama yapabiliriz");

            arrayList.Sort(); // a-z sıralama

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayList.Reverse(); // tersten sırala
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
        public static void Ornek3()
        {
            var strings = new StringCollection();
            strings.Add("İstanbul");
            strings.Add("Ankara");
            strings.Add("Bursa");
            // strings.Add(34); // StringCollection a sadece string veriler eklenebilir
            Console.WriteLine("StringCollection");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
