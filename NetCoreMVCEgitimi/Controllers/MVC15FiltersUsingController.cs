using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreMVCEgitimi.Filters;
using NetCoreMVCEgitimi.Models;
using System.Security.Claims;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC15FiltersUsingController : Controller
    {
        UyeContext db = new UyeContext();
        public IActionResult Index()
        {
            return View();
        }
        [UserControl] // Bu filtreyi sadece bu action için kullanmak istiyorsak bu şekilde kullanabiliriz.
        public IActionResult UyelikBilgilerim()
        {
            var id = HttpContext.Session.GetInt32("kullaniciId");
            var kullanici = db.Uyeler.FirstOrDefault(u => u.Id == id);
            return View(kullanici);
        }
        [UserControl]
        [Authorize] // .net ile aşağıdaki methodu korumaya alıyoruz. Bu methoda sadece login olan kullanıcılar erişebilir.
        public IActionResult UyeGuncelle()
        {
            var id = HttpContext.Session.GetInt32("kullaniciId");
            var kullanici = db.Uyeler.FirstOrDefault(u => u.Id == id);
            return View(kullanici);
        }
        [HttpPost]
        [UserControl]
        [Authorize] // .net ile aşağıdaki methodu korumaya alıyoruz. Bu methoda sadece login olan kullanıcılar erişebilir.
        public IActionResult UyeGuncelle(Uye uye)
        {
            var id = HttpContext.Session.GetInt32("kullaniciId");
            var kullanici = db.Uyeler.FirstOrDefault(u => u.Id == id);
            if (ModelState.IsValid)
            {
                kullanici.Ad = uye.Ad;
                kullanici.Soyad = uye.Soyad;
                kullanici.Email = uye.Email;
                kullanici.Telefon = uye.Telefon;
                kullanici.TcKimlikNo = uye.TcKimlikNo;
                kullanici.DogumTarihi = uye.DogumTarihi;
                kullanici.KullaniciAdi = uye.KullaniciAdi;
                kullanici.Sifre = uye.Sifre;
                kullanici.SifreTekrar = uye.SifreTekrar;

                db.Entry(kullanici).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("UyeGuncelle");
            }
            return View(kullanici);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Uye uye)
        {
            var kullanici = db.Uyeler.FirstOrDefault(u => u.Email == uye.Email && u.Sifre == uye.Sifre);
            if (kullanici != null)
            {
                HttpContext.Session.SetInt32("kullaniciId", kullanici.Id);
                var haklar = new List<Claim>() // kullanıcı hakları tanımladık
                    {
                        new(ClaimTypes.Email, kullanici.Email), // claim = hak(kullanıcıya tanımlalan haklar)
                        new(ClaimTypes.Role, "Admin")
                    };
                var kullaniciKimligi = new ClaimsIdentity(haklar, "Login"); // kullanıcı kimliği oluşturduk
                ClaimsPrincipal claimsPrincipal = new(kullaniciKimligi);
                HttpContext.SignInAsync(claimsPrincipal); // yukardaki yetkilerle sisteme giriş yaptık
                if (!string.IsNullOrEmpty(Request.Query["ReturnUrl"])) // eğer adres çubuğunda ReturnUrl diye bir değer varsa
                {
                    return Redirect(Request.Query["ReturnUrl"]); // oturum açıldıktan sonra kullanıcıyı kaldığı yere dönürmek için returnurl deki adrese yönlendir
                }
                return RedirectToAction("Index"); // ReturnUrl boşsa anasayfaya yönlendir
            }
            return View(uye);
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
