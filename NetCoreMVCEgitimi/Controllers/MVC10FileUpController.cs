using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC10FileUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile? dosya) // mvc de dosya yuklme IFormFile interface 'i ile yapiliyor. burada isminin ekrandaki file upload name 'i ile ayni olmasi gerekir yoksa dosya yuklenmez
        {
            if (dosya != null)
            {
                var uzanti = Path.GetExtension(dosya.FileName);
                var klasor = Directory.GetCurrentDirectory() + "/wwwroot/Images/"; //resmin yuklencegi klasor
                var klasorVarmi = Directory.Exists(klasor); //sunucunda bu klasor var mi?
                TempData["Message"] = "klasorVarmi :" + klasorVarmi;
                if (klasorVarmi ==false) // eger sunucuda bu konuda kalsor yoksa
                {
                    var sonuc = Directory.CreateDirectory(klasor);//ana dizine images klasaoru olustur
                    TempData["Message"] += " - Klasor Olusturuldu.." + sonuc;

                }
                if (uzanti==".jpg" || uzanti==".jpeg" || uzanti==".png" || uzanti==".gif") //sadece bu uzantulardaki dasyalari kabul et
                {
                    //1. yondetm Random(Rastgele) isimle dosya yukleme 
                    /*
                    var randomFilename = Path.GetRandomFileName(); //rasgele dosya ismi olusturma metodu
                    var fileName = Path.ChangeExtension(randomFilename, ".jpg"); // daosya adi ve uzantisini degistirip birlestirdik
                    var path = Path.Combine(klasor, fileName);//kalsor ve resim adini birlestirk

                    using var stream = new FileStream(path, FileMode.Create); //resmi farkli kaydet metoduyla sunucuya yukluyoruz

                    dosya.CopyTo(stream);//resmi sunucuya yukle
                    TempData["Resim"] = fileName;
                    */

                    /*
                    //2.yontem-resmi kendi adiyla Yukleme 
                    var dosyaAdi = Path.GetFileName(dosya.FileName);
                    var yol = Path.Combine(klasor, dosyaAdi);
                    using var stream = new FileStream(yol, FileMode.Create);
                    dosya.CopyTo(stream);  // resmi sunucuya yukle
                    TempData["Resim"] = dosyaAdi; //yuklenen dosya adi
                    */

                    //3.yontem , resmi direk sunucuya yollama
                    using var stream = new FileStream(klasor + dosya.FileName, FileMode.Create);
                    dosya.CopyTo(stream);
                    TempData["Resim"] = dosya.FileName;


                }
                else
                {
                    TempData["Message"] += "- sadece .jpg, .jpeg, .png, .gif uzantali dosyalar yuklenbilir";
                }

            }
            return View();
        }
        [HttpPost]
        public IActionResult ResimSil(string resimYolu)
        {
            if (System.IO.File.Exists(resimYolu))
            {
                System.IO.File.Delete(resimYolu);
                TempData["Message"] = "resim silindi!";
                return RedirectToAction("Index");
                
            }
            return View("Index");
        }
    }
}

