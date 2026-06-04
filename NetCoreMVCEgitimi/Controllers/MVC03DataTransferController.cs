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
        public IActionResult Search(string txtAra)
        {
            ViewBag.GetVerisi = txtAra; // querystringteki txtara yapisnin degerini getir
            return View();
        }

        [HttpPost] // asagidaki method view dan gelecek post isteginde calisir , get de calismaz !
        public IActionResult index(string txtUrunAdi , string ddlKategori , string rbOnay , bool cbOnay, IFormCollection formCollection)
           
        {
            var urunlistesi = new List<Urun>
                {
                new Urun() { Adi = "oyun BIlgisayari", Fiyati =49999, Stok = 5},
                new Urun() { Adi = "Laptop", Fiyati =29999, Stok = 7},
                new Urun() { Adi = "is istasyonu", Fiyati =99999, Stok = 3}

            };
            ViewData["Urunler"]=urunlistesi;

            ViewBag.Baslik1 = "1. yontem parametreyle veri yakalama";
            ViewBag.Mesaj1 = "textbox degeri : " + txtUrunAdi;
            ViewBag.Mesaj2 = "DropDowndegeri :" + ddlKategori;
            ViewBag.Mesaj3 = "cbonay degeri : " + cbOnay;
            ViewBag.Mesaj3 = "- rbonay degeri : " + rbOnay;

            ////




            ViewBag.Baslik2 = "2. yontem FormCollection ile yakalama";
            ViewBag.Mesaj4 = "Textbox degeri : " + formCollection["txtUrunAdi"];
            ViewBag.Mesaj5 = "DropDowndegeri :" + formCollection["ddlKategori"];
            ViewBag.Mesaj6 = "cbonay degeri : " + formCollection["cbOnay"][0];
            ViewBag.Mesaj6 = "- rbonay degeri : " + formCollection["rbOnay"][0];

            /////

            ViewBag.Baslik3 = "3. yontem Request form ile yakalama";
            ViewBag.Mesaj7 = "textbox degeri : " + Request.Form["txtUrunAdi" ];
            ViewBag.Mesaj8 = "DropDowndegeri :" + Request.Form["ddlKategori"];
            ViewBag.Mesaj9 = "cbonay degeri : " + Request.Form["cbOnay"][0];
            ViewBag.Mesaj9 = "- rbonay degeri : " + Request.Form["rbOnay"][0];



            return View();
        }
    }
}
