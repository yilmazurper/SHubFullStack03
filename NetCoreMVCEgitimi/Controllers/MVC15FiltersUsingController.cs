using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;
using NetCoreMVCEgitimi.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;



namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC15FiltersUsingController : Controller
    {
        UyeContext db = new UyeContext();
        public IActionResult Index()
        {
            return View();
        }
        [UserControl] // bu filtreyi adce bu action icin kullnamk istiyotisak bu sekilde kulaniriz
        public IActionResult UyelikBilgileri()
        {
            var id = HttpContext.Session.GetInt32("kullaniciId");
            var kullanici = db.Uyeler.FirstOrDefault(u => u.Id == id);

            return View(kullanici);
        }
       
        [UserControl]
        //[Authorize] // .net ile asaidaki methodu korumaya aliyoruz . bu methoda sadece login olan kullanicliar erisebilir.
        public IActionResult UyeGuncelle()
        {
            var id = HttpContext.Session.GetInt32("kullaniciId");
            var kullanici = db.Uyeler.FirstOrDefault(u => u.Id == id);

            return View(kullanici);
        }
        [HttpPost]
        [UserControl]
        //[Authorize] // .net ile asaidaki methodu korumaya aliyoruz . bu methoda sadece login olan kullanicliar erisebilir.
        public IActionResult UyeGuncelle(Uye uye)
        {
            var id = HttpContext.Session.GetInt32("kullaniciId");
            var kullanici = db.Uyeler.FirstOrDefault(u => u.Id == id);
            if (ModelState.IsValid)
            {
                kullanici.Ad = uye.Ad;
                kullanici.Soyad = uye.Soyad;
                kullanici.Email = uye.Email;
                kullanici.Telefon = uye.Telefon;
                kullanici.TcKimlikNo = uye.TcKimlikNo;
                kullanici.DogumTarihi = uye.DogumTarihi;
                kullanici.KullaniciAdi = uye.KullaniciAdi;
                kullanici.Sifre = uye.Sifre;
                kullanici.SifreTekrar = uye.SifreTekrar;

                db.Entry(kullanici).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("UyeGuncelle");


            }

            return View(kullanici);
        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(Uye uye)
        {
            var kullanici = db.Uyeler.FirstOrDefault(u => u.Email ==  uye.Email && u.Sifre == uye.Sifre);
            if (kullanici != null)
            {
                HttpContext.Session.SetInt32("kullanciId", kullanici.Id);

                var haklar = new List<Claim>
                {
                    new Claim(ClaimTypes.Role, "Admin")
                };

                var kullanciKimligi = new ClaimsIdentity(haklar, "Login"); //kullanici kimligi olusturduk
                ClaimsPrincipal claimsPrincipal = new(kullanciKimligi);
                HttpContext.SignInAsync(claimsPrincipal); // yukaridaki yetkilerle sisteme giris yaptik
                if (!string.IsNullOrEmpty(Request.Query["Returnurl"])); // eger adres cubugunda returnurl diye bir deger varsa 

                {
                    return Redirect(Request.Query["returnurl"]); // oturum acildiktan sonra kullaniciyi kaldigi yere dondurmek icin returnurl deki adree yolednir

                }
                return RedirectToAction("Index"); // retunrnurl bossa anasayfaya yondelndir

            }

            return View(uye);
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }


    }
}
