using System.Security.Cryptography;

namespace Konu08SiniflarClasses
{
    internal class Ev // sinif tanimlama
    {
        internal string sokakAdi;
        internal int kapiNo;

    }
    /*
         Erisim belirtecleri 4 ana sinifa ayrilir
    public    : Erisim siniri yoktur, her yerden erisilebilir
    protected : Ait oldugu siniftan ve o siniftan turetilen siniflardan erisebilir
    internal  : Etkin projeye ait siniflardan erisebilir, onlarin disinda erisilemez
    private   : Yalniz bulundugu siniftan erisilebilir , distaki siniflardan erisilemez
     */

    public class deneme
    {
        public string urunAdi = "public ogeye herkes ulasabilir";

        protected class test
        {
            string urunAdi;
        }


    }


    internal class Program
    {


        static void Main(string[] args)
        {


            Console.WriteLine("Konu 08 siniflar Classes !");
            #region ornek1
            Ev ilkEv = new Ev(); // soyut bit yapi olan ev sinifindean somut bir nesne olusturduk, ilkev adinda somut bir nesne olusturduk
            ilkEv.sokakAdi = "pinar sok";
            ilkEv.kapiNo = 10;

            Console.WriteLine("ilkEvSokakAdi : " + ilkEv.sokakAdi);
            Console.WriteLine("ilkEv Kapino:");

            Console.WriteLine();

            Ev yazlikEv = new();
            yazlikEv.sokakAdi = "deniz sok";
            yazlikEv.kapiNo = 10;

            Console.WriteLine("yazlikEv sokakAdi : " + yazlikEv.sokakAdi);


            Console.WriteLine("yazlikEv kapiNo : " + yazlikEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new()
            {
                kapiNo = 25,
                sokakAdi = "aho aga sokak",

            };

            Console.WriteLine("koyEvi sokakAdi : " + koyEvi.sokakAdi);
            Console.WriteLine("koyEvi kapino:" + koyEvi.kapiNo);

            Console.WriteLine();

            #endregion
            #region ornek2
            {
                kullanici kullanici = new()
                {
                    Adi = "murat",
                    Soyadi = "Yilmaz",
                    KullaniciAdi = "murt",
                    sifre = "m123",
                    Id = 1

                };
                
                Console.WriteLine("KullaniciAdiniz");
                var kullaniciAdi = Console.ReadLine();
                Console.WriteLine("sifeniz");
                var sifre = Console.ReadLine();

                if (kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.sifre)
                {
                    //isteme giris yap
                    Console.WriteLine($"hosgeldin {kullaniciAdi} {kullanici.Soyadi}");
                }
                else
                {
                    Console.WriteLine("giris basarisiz");
                }
            #endregion
                #region ornek3
                Araba araba = new()
                {
                    Id = 1,
                    Marka = "volvo",
                    KasaTipi = "suv",
                    Model = "xc90",
                    Renk = "kirmizi",
                    ModelYili = 2025
                };


                Araba araba2 = new()
                {
                    Id = 2,
                    Marka = "audi",
                    KasaTipi = "sedan",
                    Model = "A5quadro",
                    Renk = "mavi",
                    ModelYili = 2023
                };
                #endregion

                #region Ornek 4
                Kategori kategori = new()
                {
                    Id = 3, KategoriAdi = "Elektronik"
                };
                Kategori kategori2 = new()
                {
                    Id = 4, KategoriAdi = "Bilgisayar"
                };
                Kategori Kategori3 = new Kategori()
                {
                    Id = 5, KategoriAdi = "telefon"
                };
                Console.WriteLine();

                Console.WriteLine($"Anasayfa Hakkimizda {kategori.KategoriAdi}{kategori2.KategoriAdi}{Kategori3.KategoriAdi} iletisim");

                #endregion

            }
        }

        class kullanici
        {
            internal int Id;
            internal string KullaniciAdi;
            internal string sifre;
            internal string Email;
            internal string Adi;
            internal string Soyadi;
        }
        class Araba
        {
            internal int Id;
            internal string Marka;
            internal string Model;
            internal string KasaTipi;
            internal string yakitTip;
            internal string VitesTipi;
            internal string Renk;
            internal int ModelYili;

        }

    }
}
