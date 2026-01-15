// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine();
Console.WriteLine("Merhaba, Dünya!");

Console.Write("Console");
Console.Write("Write");
Console.WriteLine("Selam");
Console.WriteLine("Merhaba");

// Console.Read(); // Enter tuşuna basılmasını bekler 1 karakter için
// Console.ReadLine(); // Enter tuşuna basılmasını bekler tüm satır için

// Değişkenler
// Tam sayı veri tipleri
byte plaka_kodu; // 0-255 arası değer alır, 1 byte yer kaplar
plaka_kodu = 34; // değişkene değer atama.
Console.WriteLine(plaka_kodu); // değişkenin değerini ekrana yazdırma.

// Değişkenler tiplerine göre bellekte stack ve heap denilen 2 ayrı bölümde saklanır. Değer tipli değişkenler stack alanında saklanırken referans tipli değişkenler heap bölümünde saklanır.
// GC-çöp toplayıcı sistemi

byte birSayi, birSayiDaha; // bir tiple birden fazla değişken oluşturma
birSayi = 0;
birSayiDaha = 255;
Console.WriteLine(birSayi);
Console.WriteLine(birSayiDaha);

sbyte sbyteTuru = 127; // +127 ile -128 arası değer alabilir
short kisa = 32767; // +32767 ile -32768 arası değer alabilir
ushort birazUzun = 65535; // 0 - 65535
int tamsayi = 1234567890; // 32 bit 4 byte
uint uzuntamsayi = 4294967295; // 0 - 4294967295
long dahauzuntamsayi = 123456789000000;
ulong enuzuntamsayi = 12345678900000000000;

// Kesirli Sayı Değişken Tipleri
float kesirliSayi = 4.5f; // 4byte yer kaplar 6-7 basamak
double kesirlisayi  = 4.5; // 8byte yer kaplar 15-16 basamak

// Decimal Veri Tipi
decimal UrunFiyati = 9999; //12byte, duyarlı basamak 28 - 29

// Char Veri Tipi
char karakter = 'a'; // klavyeden girilen her bir karakter için kullanılabilir, sadece 1 tane değer alabilir.

// String Veri Tipi
string degisken; // klavyeden girilecek karakterlerden oluşan yapı
string degisken1, degisken2;
string metin = "string veri tipinde tüm karakterleri kullanabiliyoruz.";
Console.WriteLine(metin);

// Boolean Veri Tipi
bool islemSonuc = false; // Geriye true veya false dönen veri tipidir, 1byte lık yer kaplar
// işlem başarılıysa
islemSonuc = true;

byte? kilo = null; //eğer bir değişkene başlangıç değeri olarak null vermek istersek veri tipinin yanına ? koyarız
kilo = 66;

// Bir ürünün satışta olup olmadığı bilgisini tutacak değişken
bool? isSatistami = null;
// ürün satıştaysa eğer
isSatistami = true; // true ayarla

//var ile değişken oluşturma
var birdegisken = "18"; // var ile oluşturulan değişkenlerde değişkenin veri tipi c# tarafından değişkene atanan değere göre otomatik algılanır
var birsayi = 18;
var strmetin = "var kullanırsak değişkene değer atamak zorundayız!";
var sonuc = false;

Console.WriteLine(birdegisken); // ctrl + d ile satırı çoğaltıyoruz
Console.WriteLine(birdegisken.GetType());
Console.WriteLine(birsayi);
Console.WriteLine(birsayi.GetType());
Console.WriteLine(strmetin);
Console.WriteLine(strmetin.GetType());
Console.WriteLine(sonuc);
Console.WriteLine(sonuc.GetType());

sonuc = true;
// sonuc = 1; // var ile tanımlanan bir değişkenin türü sonradan değiştirilemez, ancak içindeki değer değiştirilebilir.

Console.WriteLine();
Console.WriteLine("Object Veri Tipi");
object nesne = "bu bir nesnedir"; // Bu değişken türüne her türden veri atanabilir.
Console.WriteLine(nesne);
Console.WriteLine(nesne.GetType());
nesne = 18; // object ile tanımlanan nesne değiştirilebilir
Console.WriteLine(nesne);
Console.WriteLine(nesne.GetType());

object a = 10; // tam sayı
object b = 'k'; // karakter
object c = "metin"; // string
object d = 12.9f; // float

Console.WriteLine();

// C# ta sabit tanımlama
Console.WriteLine("C# ta sabit tanımlama");
const int kdvOrani = 18; //sabitleri const olarak tanımlayıp program içerisinde kullanabiliriz, sabitlerin değeri tanımlandığı yerde verilir sonradan değişmez
// kdvOrani = 20;
const int iskonto = 25;
Console.WriteLine("kdv Orani:");
Console.WriteLine(kdvOrani);

// Ekrandan değer alma
Console.WriteLine("Ekrandan değer alma");
var deger = Console.ReadLine();
Console.WriteLine("Girdiğiniz değer:");
Console.WriteLine(deger);