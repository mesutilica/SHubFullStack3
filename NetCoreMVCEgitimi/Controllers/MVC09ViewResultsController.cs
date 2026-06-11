using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC09ViewResultsController : Controller
    {
        UyeContext db = new UyeContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FarkliViewDondur()
        {
            return View("Index");
        }
        public IActionResult Yonlendir()
        {
            // Bir action içerisinde farklı bir sayfaya yönlendirme yapabiliriz
            // return Redirect("/Home");
            return Redirect("https://www.google.com/");
        }
        public IActionResult ActionaYonlendir()
        {
            // Bir action içerisinde farklı bir Actiona yönlendirme yapabiliriz
            // return RedirectToAction("Index");
            // return RedirectToAction("FarkliViewDondur");
            return RedirectToAction("Index", "Home");
        }
        public RedirectToRouteResult RouteYonlendir()
        {
            // Bir action içerisinde bir Route a yönlendirme yapabiliriz
            return RedirectToRoute("Default", new { controller = "Home", action = "Index", id = 18 });
        }
        public PartialViewResult KategorileriGetirPartial()
        {
            return PartialView("_PartialMenu");
        }
        public PartialViewResult PartialdaModelKullanimi()
        {
            var kullanicilar = db.Uyeler.ToList();
            return PartialView("_PartialModelKullanimi", kullanicilar); // 2.parametre model datası
        }
        public IActionResult JsonResult()
        {
            var kullanicilar = db.Uyeler.ToList();
            return Json(kullanicilar);
        }
    }
}
