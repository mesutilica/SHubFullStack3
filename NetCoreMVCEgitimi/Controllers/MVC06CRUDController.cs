using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC06CRUDController : Controller
    {
        private UyeContext db = new UyeContext();
        // GET: MVC06CRUDController
        public ActionResult Index()
        {
            return View(db.Uyeler.ToList());
        }

        // GET: MVC06CRUDController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.Uyeler.Find(id));
        }

        // GET: MVC06CRUDController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MVC06CRUDController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Uye uye)
        {
            try
            {
                db.Uyeler.Add(uye); // ekrandan gelen nesneyi veritabanına ekle
                db.SaveChanges(); // veritabanına yapılan değişiklikleri kaydet
                return RedirectToAction(nameof(Index)); // işlemi tamamladıktan sonra Index sayfasına yönlendir
            }
            catch
            {
                ModelState.AddModelError("", "Üye ekleme işlemi sırasında bir hata oluştu!"); // hata durumunda kullanıcıya bilgi ver
            }
            return View(uye);
        }

        // GET: MVC06CRUDController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.Uyeler.Find(id)); // id'ye göre veritabanından ilgili üyeyi bul ve düzenleme sayfasına gönder
        }

        // POST: MVC06CRUDController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Uye uye)
        {
            try
            {
                db.Uyeler.Update(uye); // ekrandan gelen nesneyi güncelle
                db.SaveChanges(); // veritabanına yapılan değişiklikleri kaydet
                return RedirectToAction(nameof(Index)); // işlemi tamamladıktan sonra Index sayfasına yönlendir
            }
            catch
            {
                ModelState.AddModelError("", "Üye güncelleme işlemi sırasında bir hata oluştu!"); // hata durumunda kullanıcıya bilgi ver
            }
            return View(uye);
        }

        // GET: MVC06CRUDController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.Uyeler.Find(id));
        }

        // POST: MVC06CRUDController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Uye uye)
        {
            try
            {
                db.Uyeler.Remove(uye); // ekrandan gelen nesneyi sil
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(uye);
            }
        }
    }
}
