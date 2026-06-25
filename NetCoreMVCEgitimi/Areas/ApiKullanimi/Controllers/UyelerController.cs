using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Areas.ApiKullanimi.Controllers
{
    [Area("ApiKullanimi")]
    public class UyelerController : Controller
    {
        private readonly HttpClient _httpClient;
        string _url = "https://localhost:7296/api/uyeler/";

        public UyelerController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET: UyelerController
        public async Task<ActionResult> Index()
        {
            var model = await _httpClient.GetFromJsonAsync<List<Uye>>(_url); // api den çektiğin json üye listesini modele dönüştürüp ekrana yolla.
            return View(model);
        }

        // GET: UyelerController/Details/5
        public async Task<ActionResult> DetailsAsync(int id)
        {
            var model = await _httpClient.GetFromJsonAsync<Uye>(_url + id);
            return View(model);
        }

        // GET: UyelerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UyelerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Uye collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = await _httpClient.PostAsJsonAsync(_url, collection); // api ye post isteği göndermek için kullandığımız method.
                    if (response.IsSuccessStatusCode) // post metodu cevap olarak geriye değer döndürüyor.
                        return RedirectToAction(nameof(Index)); // eğer api den başarılı kodu dönmüşse
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }

            return View(collection);
        }

        // GET: UyelerController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            var model = await _httpClient.GetFromJsonAsync<Uye>(_url + id);
            return View(model);
        }

        // POST: UyelerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, Uye collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = await _httpClient.PutAsJsonAsync(_url + id, collection);
                    if (response.IsSuccessStatusCode) //  metod cevap olarak geriye değer döndürüyor.
                        return RedirectToAction(nameof(Index)); // eğer api den başarılı kodu dönmüşse
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }

            return View(collection);
        }

        // GET: UyelerController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model = await _httpClient.GetFromJsonAsync<Uye>(_url + id);
            return View(model);
        }

        // POST: UyelerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id, Uye collection)
        {
            try
            {
                var response = await _httpClient.DeleteAsync(_url + id);
                if (response.IsSuccessStatusCode)
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            return View(collection);
        }
    }
}
