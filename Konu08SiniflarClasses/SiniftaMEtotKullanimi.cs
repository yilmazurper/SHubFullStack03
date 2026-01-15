using System;
using System.Collections.Generic;
using System.Text;

namespace Konu08SiniflarClasses
{
    internal class SiniftaMEtotKullanimi
    {
        string kurucuMetot;
        public SiniftaMEtotKullanimi() // ctor yazip tab'a basarak kurucu method-consructor olusturuyoruz
        {
            Console.WriteLine();
            kurucuMetot = " siniflarda consructor ( kurucu methot) ozelligi vardir ve bu methotlar siniftan bir nesne olusturuldunda otomatik olrak calisir ve icreisindeki kodalari clistirir";
            Console.WriteLine(kurucuMetot);
            Console.WriteLine();
        }
        public bool LoginKontrol(string kullaniciAdi , string sifre)
        {
            if(kullaniciAdi=="admin" && sifre == "adm123")
            {
                return true;
            }
            return false;
        }
        public int ToplamaYap (int sayi1, int sayi2)
        {
            return sayi1 + sayi2; 
        }

    }
}
