using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC05ModelValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid)// eğer modeldeki kurallara uyulmuşsa
            {
                // kayıt ekle
            }
            else
            {
                ModelState.AddModelError("", "Zorunlu Alanları Doldurunuz!"); // modeldeki kurallara uyulmazsa hata mesajı ekle
            }
            return View(uye);
        }
    }
}
