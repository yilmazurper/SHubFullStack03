using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize] // asagidaki islenleri sadece giris yapa yapabilsin
    public class UyelerController : Controller
    {
        private readonly UyeContext _context;

        public UyelerController(UyeContext context)
        {
            _context = context;
        }

        // GET: UyelerController
        public ActionResult Index()
        {
            return View(_context.Uyeler);
        }

        // GET: UyelerController/Details/5
        public ActionResult Details(int id)
        {
            return View(_context.Uyeler.Find(id));
        }

        // GET: UyelerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UyelerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Uye collection)
        {
            if (ModelState.IsValid)
            {
                // senkron ekleme
                _context.Uyeler.Add(collection);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return View(collection);
        }

        // GET: UyelerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UyelerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Uye collection)
        {
            if (ModelState.IsValid)
            {


                try
                {
                    _context.Uyeler.Add(collection);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Olustu");
                }

            }
           

            return View(collection) ;
        }

        // GET: UyelerController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _context.Uyeler.Find(id);
            return View(model);
        }

        // POST: UyelerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Uye collection)
        {
            try
            {
                _context.Uyeler.Remove(collection);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
