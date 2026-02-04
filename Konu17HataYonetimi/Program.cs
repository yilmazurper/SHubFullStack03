namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 17 Hata Yonetimi");
            Console.WriteLine();
            Console.WriteLine("Kdv hesaplamak icin Fiyat Giriniz");
            var fiyat = Console.ReadLine();
            //KdvHesapla(double.Parse(fiyat));
            try // try yazip tab tab yaparak try catch blogu olusturuyoruz 
            {
                // try bogu kodumuzu deneyecegimiz alandir
                KdvHesapla(double.Parse(fiyat));
            }
            catch (Exception hata) // eger try blogunda hata olusursa o zaman catch blogu calisir
            { // exception a bir isim vererel hatayiyakalayabiliriz
                Console.WriteLine("Hata olustu ! Lutfen sadece sayisal deger giriniz!");
                throw; // throw yine hata firlatmasini saglar
                Console.WriteLine(hata.Message); // hata nesnesi icinde hata detaylari yer alir 
                // ayrica uygulamalrda hata olusurse olusan hatalar veri tabani vey fiziksel bir dosyaya kayit edilir , bu isleme loglama denir
            }
            finally // istege bagli son blok
            {
                Console.WriteLine(" try catch blogundan sonra her seferinde calismasini istedgimiz bir islem varsa bu blokta calaistarabiliriz . kullnaimi zorunlu degilldir");
                Console.WriteLine("kdv hesaplamak icin fiyat giriniz");
                var fiyat2 =Console.ReadLine();
                KdvHesapla(double.Parse(fiyat2));
            }

        }
        static void KdvHesapla(double fiyat)
        {
            Console.WriteLine("Fiyat:" + fiyat);
            Console.WriteLine("Kdv:"+ (fiyat*0.20));
            Console.WriteLine("Kdv Dahil Toplam Tutar : " + (fiyat + (fiyat*0.20)));
        }
    }
}
