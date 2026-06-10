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
            if (ModelState.IsValid) // eger modeldeki kurallara uyulmusa
            {
                // kayit ekle
            }
            else

            {
                ModelState.AddModelError(" ", "zorunlu Alanlari Doldurunuz!"); // modeldeki kullaraa uyulmssa hata mesaji ekle
            }
            return View(uye);
        }
    }
}
