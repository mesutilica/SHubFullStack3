using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC11CookieController : Controller
    {
        UyeContext context = new UyeContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CookieOlustur(string kullaniciAdi, string sifre)
        {
            var kullanici = context.Uyeler.FirstOrDefault(u => u.KullaniciAdi == kullaniciAdi && u.Sifre == sifre);
            if (kullanici != null)
            {
                Response.Cookies.Append("userguid", Guid.NewGuid().ToString());
                var cookieAyarlari = new CookieOptions()
                {
                    Expires = DateTime.Now.AddMinutes(1) // cookie ye 1 dk lık bitiş süresi tanımladık
                };
                HttpContext.Response.Cookies.Append("username", kullaniciAdi, cookieAyarlari); // .net de HttpContext ile oluşturuyoruz
                return RedirectToAction("CookieOku");
            }
            else
            {
                TempData["Mesaj"] = @"<div class='alert alert-danger'>Giriş Başarısız!</div>";
            }
            return View();
        }
    }
}
