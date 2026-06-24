using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCEgitimi.Areas.ApiKullanimi.Controllers
{
    [Area("ApiKullanimi")]
    public class UyelerController : Controller
    {
        // GET: UyelerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UyelerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UyelerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UyelerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UyelerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UyelerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UyelerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UyelerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
