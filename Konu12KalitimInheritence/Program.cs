using System.Net.WebSockets;

namespace Konu12KalitimInheritence
{
    class Arac
    {
        public int id {  get; set; }
        public string aracturu;
        internal string marka;
        internal string model;
        public void kornacal()
        {
            Console.WriteLine("kornaya basildi");
        }

    }
    class otomobil : Arac //iki nokta ust uste arac dedigimide arac sinifindaki icerikler otomobil sinifinda kullanilabilir
    {
        internal string marka;

        internal string model;

        public string Kasatipi { get; set; }
        public string yakitturu { get; set; }
    }
    class test : otomobil
    {
        public int MyProperty { get; set; }
    }
    class Tren : Arac
    {
        public int vagonsayisi { get; set;  }
    }
    
    class otobus : Arac
    {
        public int koltuksayisi { get; set; }

    }
        
    internal class Program
    {
        private static object urun;

        static void Main(string[] args)
        {
            Console.WriteLine("Konu 12 Kalitim Inheritence");
            Arac arac = new Arac();
            arac.aracturu = "otomobil";
            arac.kornacal();

            otomobil otomobil=new otomobil();
            otomobil.id = 1;
            otomobil.aracturu = "otomobil"; // bu degisim arac sinifindan geliyor
            otomobil.kornacal();
            otomobil.marka = "BMW";
            otomobil.model = "320GT";
            Console.WriteLine("otomobil.aracturu:" + otomobil.aracturu);

            Console.WriteLine();

            Kategori kategori = new()
            {
                id = 1,
                name = "elektronik",
                ustmenudegoster = true,

            };
            if (kategori.ustmenudegoster == true)
            {
                Console.WriteLine("kategori Adi : "  + kategori.name);
            }

            Console.WriteLine();

            Urun urun = new()
            {
                id = 1,
                name = "klavye",
                fiyat=999,
                kdv=20,
            };

            Console.WriteLine("urun bilgileri: ");
            Console.WriteLine("urun adi: " + urun.name);
            Console.WriteLine("urun fiyati: " + urun.fiyat);
            Console.WriteLine("kdv: % " + urun.kdv);
            decimal kdvorani = 0.20m;
            decimal kdvtutari = urun.fiyat * kdvorani;
            decimal toplamfiyat = urun.fiyat + kdvtutari;
            Console.WriteLine("kdv tutari : "  + kdvtutari + "TL");
            Console.WriteLine("toplam tutar: " + toplamfiyat +"TL");

            Console.WriteLine();

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (var item in birCizici)
            {
                item.Ciz();
            }
        }
    }

    // Polimorfizm-cok bicimlilik
    public class Cizici
    {
        public virtual void Ciz() // virtual keyword ie bu metodu override - ezilebiler hale getiriyoruz
        {
            Console.WriteLine("cizici");
        }
    }
    public class DogruCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("duz cizgi");
        }
    }

    public class DaireCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Daire cizgi");
        }
    }
    public class KareCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("kare cizgi");
        }
    }
}
