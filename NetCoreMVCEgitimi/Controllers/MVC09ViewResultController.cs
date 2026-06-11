using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC09ViewResultController : Controller
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
            // bir action icerisinde farkli bir sayfaya yonlendirme yapabilriiz
            //return Redirect("/Home");
            return Redirect("https://www.google.com/");
        }
        public IActionResult ActionaYonlendir()
        {
            // bir action icerisinde farkli bir sayfaya yonlendirme yapabilriiz
            //return Redirect("/Home");
            //return RedirectToAction("Index");
            //return RedirectToAction("FarkliViewDondur");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult RouteYonlendir()
        {
            // bir action icerisinde bbir rout a yondelndime yapabiliriz
            return RedirectToRoute("Default", new {controller = "Home", action = "Index" , Id = 18});
        }
        public IActionResult KategorileriGetirPartial()
        {
            return PartialView("_PartialMenu");
        }
        public IActionResult PartialdaModelKullanimi()
        {
            var kullanicilar = db.Uyeler.ToList();
            return PartialView("_PartialdaModelKullanimi" , kullanicilar); // 2.parametrede model datasi
        }

        public IActionResult JsonResult()
        {
            var kullanicilar = db.Uyeler.ToList();
            return Json(kullanicilar);
        }
    }
}
