using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC04ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KullaniciDetay()
        {
            var kullanici = new Kullanici()
            {
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "murat@yilmaz.co",
                KullaniciAdi = "murat",
                Sifre = "123"
            };
            return View(kullanici);// kullanici nesnesini bu şekilde sayfaya model verisi olarak gönderiyoruz yoksa hata veriyor.
        }
        [HttpPost] // post olunca çalış
        public IActionResult KullaniciDetay(Kullanici kullanici)
        {
            // burada ekrandan gelen kullanici nesnesini db ye kaydedebiliriz.
            return View(kullanici);// kullanici nesnesini bu şekilde sayfaya model verisi olarak gönderiyoruz yoksa hata veriyor.
        }
        public ActionResult AdresDetay()
        {
            var model = new Adres() { Ilce = "Kartal", Sehir = "İstanbul", AcikAdres = "Gül sk. No: 18 Atalar" };
            return View(model);
        }
        [HttpPost] // post olunca çalış
        public ActionResult AdresDetay(Adres adres)
        {
            // işlemler yapılır
            return View(adres);
        }
        public IActionResult KullaniciAdresDetay()
        {
            var kullanici = new Kullanici()
            {
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "murat@yilmaz.co",
                KullaniciAdi = "murat",
                Sifre = "123"
            };

            var model = new UyeSayfasiViewModel
            {
                Kullanici = kullanici,
                Adres = new Adres() { Ilce = "Kartal", Sehir = "İstanbul", AcikAdres = "Gül sk. No: 18 Atalar" }
            };
            return View(model);
        }
    }
}
