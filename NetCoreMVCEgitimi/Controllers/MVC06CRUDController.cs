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
                db.Uyeler.Add(uye); // ekranda gelen nesneyi veritanabinna ekle
                db.SaveChanges(); // veri tabani yapilan degiskiklikleri kaydet
                return RedirectToAction(nameof(Index)); // islemi tammaladiktan sonra index sayfasina yonlendir
            }
            catch
            {
                ModelState.AddModelError("", "uye ekleme eislemi sirasinda bir hata olustu "); //hata durumunda kulaniciya bilgi ver
            }
            return View();
        }

        // GET: MVC06CRUDController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.Uyeler.Find(id)); // id'ye gore veritabanindan ilgili uyeyi bul ve duzenleme sayfasina gonder
        }

        // POST: MVC06CRUDController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Uye uye)
        {
            try
            {
                db.Uyeler.Update(uye); // ekranda gelen nesneyi guncelle
                db.SaveChanges(); // veri tabani yapilan degiskiklikleri kaydet
                return RedirectToAction(nameof(Index)); // islemi tammaladiktan sonra index sayfasina yonlendir
            }
            catch
            {
                ModelState.AddModelError("", "uye ekleme eislemi sirasinda bir hata olustu "); //hata durumunda kulaniciya bilgi ver
            }
            return View();
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
                db.Uyeler.Remove(uye); // ekranda gelen nesneyi sil
                db.SaveChanges(); // veri tabani yapilan degiskiklikleri kaydet
                return RedirectToAction(nameof(Index)); // islemi tammaladiktan sonra index sayfasina yonlendir
            }
            catch
            {
                return View();
            }
        }
    }
}
