using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models; //urun classini gormesi icin gerekli 
namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        public IActionResult Index()
        { //3 farkli yontmele controllerden view a basit veriler godnerebliriz 

            //1-viewBag : tek kullnaimlik omru vardir
            ViewBag.UrunKategorisi = "bilgisayar"; // burada viewbag ismi standart olarak yazilir sonrasinda " . " deyip diledigimiz degisken adini yazabiliriz 

            //2-ViewData : tek kullanimlik omru vardir
            var urunlistesi=new List<Urun>
                {
                new Urun() { Adi = "oyun BIlgisayari", Fiyati =49999, Stok = 5},
                new Urun() { Adi = "Laptop", Fiyati =29999, Stok = 7},
                new Urun() { Adi = "is istasyonu", Fiyati =99999, Stok = 3}

            };
            ViewData["Urunler"] = urunlistesi;

            //3-tempdata : 2 kullnaimlik omru vardir
            TempData["UrunBilgi"] = " Toplam "  +  urunlistesi.Count + " Urun Bulundu..";

            return View();
        }
        [HttpGet] // attribute : dikkat :! bir metodun uzerinde attribute yoksa varsayilan tur get dir
        public IActionResult Search()
        {
            return View();
        }
          
    }
}
