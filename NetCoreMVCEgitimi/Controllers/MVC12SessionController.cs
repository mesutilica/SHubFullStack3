using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC12SessionController : Controller
    {
        UyeContext context = new UyeContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SessionOlustur(string kullaniciAdi, string sifre)
        {
            var kullanici = context.Uyeler.FirstOrDefault(u => u.KullaniciAdi == kullaniciAdi && u.Sifre == sifre);
            if (kullanici != null)
            {
                HttpContext.Session.SetString("deger", "Admin"); //mvc de sessiona veri atma
                HttpContext.Session.SetString("userguid", Guid.NewGuid().ToString());
                HttpContext.Session.SetString("username", kullanici.KullaniciAdi);
                HttpContext.Session.SetString("kullanici", kullaniciAdi); // session da string olarak key value şeklinde değer saklayabiliriz

                HttpContext.Session.SetInt32("kullaniciId", kullanici.Id);

                return RedirectToAction("SessionOku");
            }
            else
            {
                TempData["Mesaj"] = @"<div class='alert alert-danger'>Giriş Başarısız!</div>";
            }
            return View("Index");
        }
        public IActionResult SessionOku()
        {
            if (HttpContext.Session.GetString("username") == null || HttpContext.Session.GetString("userguid") == null)
            {
                TempData["Mesaj"] = @"<div class='alert alert-danger'>Lütfen Giriş Yapınız!</div>";
                return RedirectToAction("Index");
            }

            TempData["kullaniciAdi"] = HttpContext.Session.GetString("username");
            TempData["kullaniciguid"] = HttpContext.Session.GetString("userguid");
            return View();
        }
        public IActionResult SessionSil()
        {
            HttpContext.Session.Remove("deger"); // deger isimli sessionu süresini beklemeden sil
            HttpContext.Session.Clear(); // tüm sessionları sil
            return RedirectToAction("Index");
        }
    }
}
