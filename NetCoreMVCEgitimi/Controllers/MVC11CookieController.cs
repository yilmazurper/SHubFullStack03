using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC11CookieController : Controller
    {
        UyeContext context = new UyeContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CookieOlustur(string kullaniciAdi, string sifre)
        {

            var kullanici = context.Uyeler.FirstOrDefault(u => u.KullaniciAdi == kullaniciAdi && u.Sifre == sifre);
            if (kullanici != null)
            { 
                Response.Cookies.Append("userguid" , Guid.NewGuid().ToString());
                var cookieAyarlari = new CookieOptions()
                {
                    Expires = DateTime.Now.AddMinutes(1) //cookie 'ye 1 dklik bitis suresi tanimlarik
                };

                HttpContext.Response.Cookies.Append("username", kullaniciAdi, cookieAyarlari); //.net de httpcontext ile olusturuyoruz
                return RedirectToAction("CookieOKu");

            
            }
            else
            {
                TempData["Mesaj"] = @"<div class='alert alert-danger'> Giris Basarisiz!</div>";
            }
            return View("Index");
        }
        public IActionResult CookieOKu()
        {
            if (HttpContext.Request.Cookies["username"] == null || HttpContext.Request.Cookies["userguid"] == null)
            {
                TempData["Mesaj"] = @"<div class='alert alert-danger'>Lutfen Giris Yapiniz!</div>";
                return RedirectToAction("Index");
            }

            TempData["kullaniciAdi"] = HttpContext.Request.Cookies["username"];
            TempData["kullaniciguid"] = HttpContext.Request.Cookies["userguid"];
            return View();
        }

        public IActionResult CookieSil()
        {
            if (HttpContext.Request.Cookies["username"] !=null)
            {
                HttpContext.Response.Cookies.Delete("username");
            }
            if (HttpContext.Request.Cookies["userguid"] !=null)
            {
                HttpContext.Response.Cookies.Delete("userguid");
            }
            return RedirectToAction("CookieOku");
        }
    }
}
