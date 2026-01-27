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
                BolumAdi = istenenEgitim;
            }
            else
            {
                Console.WriteLine("kurumumuzda bu egitim verilmemektedir");
            }
        }
    }

    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13 Kapsulleme Encapsulation");
            Console.WriteLine("metot ile kapsulleme");
            Bolum bolum =new Bolum();
            Console.WriteLine("Hangi Alanda egitim almka istersin");
            var bolumAdi = Console.ReadLine();
            bolum.SetBolumAdi(bolumAdi);
            Console.WriteLine("bolum : " + bolum.GetBolumAdi());

        }
    }
}
