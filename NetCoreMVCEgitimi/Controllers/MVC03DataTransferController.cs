using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models; // Urun class ını görmesi için gerekli

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        public IActionResult Index()
        {// 3 Farklı Yöntemle Controllerdan View a Basit Veriler Gönderebiliriz

            // 1-ViewBag : Tek kullanımlık ömrü vardır.
            ViewBag.UrunKategorisi = "Bilgisayar"; // Burada ViewBag ismi standart olarak yazılır sonrasında . deyip dilediğimiz değişken adını yazabiliriz.

            // 2-ViewData : Tek kullanımlık ömrü vardır.
            var urunListesi = new List<Urun>
            {
                new Urun() { Adi = "Oyun Bilgisayarı", Fiyati = 49000, Stok = 5 },
                new Urun() { Adi = "Laptop", Fiyati = 29000, Stok = 7 },
                new Urun() { Adi = "İş İstasyonu", Fiyati = 99000, Stok = 3 }
            };
            ViewData["Urunler"] = urunListesi;

            // 3-TempData : 2 kullanımlık ömrü vardır.
            TempData["UrunBilgi"] = "Toplam " + urunListesi.Count + " Ürün Bulundu..";
            return View();
        }
        [HttpGet]// attribute : Dikkat! bir metodun üzerinde attribute yoksa varsayılan tür Get dir!
        public IActionResult Search()
        {
            return View();
        }
    }
}
