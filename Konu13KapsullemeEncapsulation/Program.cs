using System.Runtime.CompilerServices;

namespace Konu13KapsullemeEncapsulation
{
    internal class Bolum
    {
        private string BolumAdi; // disaridan erisime kapali degiskenimiz;
        public string GetBolumAdi() // disariya string veri gonderen metot
        {
            return BolumAdi; //getbolumadi cagilinca bolumadi degisken degerini yolla 
        }
        public void SetBolumAdi(string istenenEgitim)
        {
            if (istenenEgitim == "Yazilim Egitimi")
            {
                BolumAdi = istenenEgitim; //mutator (setter)secilen egitime izin verildi
            }
            else
            {
                Console.WriteLine("kurumumuzda bu egitim verilmemektedir");
            }
        }
    }

    internal class Program 
    {
        static void Main(string[] argys)
        {
            Console.WriteLine("Konu13 Kapsulleme Encapsulation");
            Console.WriteLine("metot ile kapsulleme");
            Console.WriteLine("Hangi Alanda egitim almka istersin");

            Bolum bolum =new Bolum(); // bolum classindan bolum adinda bir nesne uret
            var bolumAdi = Console.ReadLine();// ekrandan girilicek degeri oku
            bolum.SetBolumAdi(bolumAdi); // girilen degeri bolum nesnesindeki set metotuna gonder
            Console.WriteLine("bolum : " + bolum.GetBolumAdi()); //bolum nesnesindeki metotla privite degiskenin degerini oku

            Console.WriteLine();

            //property ile kapsulleme
            Console.WriteLine("property ile kapsulleme");
            Fakulte fakulteNesnesi =new Fakulte (); // burda nesneyi olusturuyoruz
            fakulteNesnesi.Bolum = bolumAdi; //veri atama: set blogunu calistirir
            Console.WriteLine("bolum : " + fakulteNesnesi.Bolum); //veri okuma :get blogunu calistirir
        }
    }

    public class Fakulte
    {
        private string bolum;
        public string Bolum
        { 
            get { return bolum; }
            set
            {
                if (value == "yazilim egitimi") //eer gonderilen deger yazilim egiitmi ise 
                {
                    bolum = value; // property e deger atamsina izin ver
                }
                else
                {
                    Console.WriteLine("kurumumuzda bu egiitm verilmemektedir");
                }
            }
        }
          
    }
}
