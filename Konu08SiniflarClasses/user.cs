using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Konu08SiniflarClasses
{
    internal class user
    {
        //class'larda property kullanimi
        //property'ler degisken metotlarin karisimi gibi calisirlar
        //degisken gigi deger tasimak icinde , metot gibi de kullanilabilirler
        //property olusturmek icin prop yazip tab tusuna basarak kisayol kullanabiliriz

        public int id { get; set; } //prop + tab
        public string name { get; set; } // user classindan olusturdugumuz nesne uzerinden buradaki propertylere deger atamasi yaparsak  
        //set blogu , deger okumasi yaparsak get blogu calisir 
        public string password { get; set; }

        public string email { get; set; }
        public string phone { get; set; }
        public string username { get; set; }
        public DateTime CreateDate { get; set; }
        public bool KullaniciGiris(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "admin" && sifre == "adm123")
            {
                return true;
            }
            return false;
        }
    }

}
