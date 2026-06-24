using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCEgitimi.Areas.ApiKullanimi.Controllers
{
    [Area("ApiKullanimi")]
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
