using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC04BindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KullaniciDetay()
        {
            var kullanici = new Kullanici()
            {
                Ad = "murat",
                Soyad = "Yilmaz",
                Email = "murat@yilmaz.co",
                KullaniciAdi = "murat",
                Sifre = "123",


            };

        }

            [HttpPost] // post olunca calis
        public IActionResult KullaniciDetay(Kullanici kullanici)
        {
           // burada ekrandan gelen kullici nesneisni db ye kaydedebilriiz 
          
            return View(kullanici); // kullanici nesnesini bu sekilde sayfaya model verisi olarak gonderiyoruz yoksa hata veriyor 
        }
        public ActionResult AdresDetay()
        {
            var model = new Adres() { Ilce = "kartal", Sehir = "istnabul", AcikAdres = "gul sk. no:18 Atalar" };
            return View(model);
        }
    }
}
