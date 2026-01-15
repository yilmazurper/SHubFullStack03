using System.Threading.Channels;

namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 02 Tip Donusumleri");
            //implicit Casting --otoamtik tip donusumu
            //explicit Casting -- manuel tip
            Console.WriteLine("implicit Casting --otoamtik tip donusumu");
            Console.WriteLine("implicit casting de daha kucuk bir boyutlu bir turu daha buyuk bir boyut turune geciriken donusum otomatik olarak yapilir.");
            int sayi = 73;
            double kesirlisayi = sayi;// int turundeki degeri double tasiyabilir
            Console.WriteLine("sayi degeri:");
            Console.WriteLine(sayi);
            Console.WriteLine("kesirlisayi degeri:");
            Console.WriteLine(kesirlisayi);

            Console.WriteLine();
            Console.WriteLine("explicit Casting -- manuel tip donusumu");
            double kesirlisayi2 = 73;
            int tamsayi = (int)kesirlisayi2;
            Console.WriteLine("kesirlisayi2:");
            Console.WriteLine(kesirlisayi2);

            Console.WriteLine("tamsayi:");
            Console.WriteLine(tamsayi);
            Console.WriteLine();

            Console.WriteLine("diger tur donusturme yontemleri");
            int tamsayi2 = 65;
            double kesirlisayi3 = 5.25;
            bool islemsonuc=true;

            Console.WriteLine("lutfen Bir Sayi Giriniz:");
            var girilendeger=Console.ReadLine();
            Console.WriteLine("girilen degerin veri tipi:");
            Console.WriteLine(girilendeger.GetType());

            var parsayi = int.Parse(girilendeger); //int.parse metodu string degerin tirnaklarini kaldirarak int tipine cevirir
            Console.WriteLine(parsayi+tamsayi);
            Console.WriteLine(double.Parse(girilendeger) + kesirlisayi3);
            Console.WriteLine(decimal.Parse(girilendeger) + tamsayi2);
            Console.WriteLine();


            Console.WriteLine("convert sinifi metotlariyla tip donusturme");
            Console.WriteLine(tamsayi2.GetType()); //tamsayi2 veri tipini yazdir
            Console.WriteLine(Convert.ToString(tamsayi2).GetType());//tamsayi2'yi string'e cevir ve tipini dogulmak icin ekrana yazdir
            Console.WriteLine(Convert.ToDouble(tamsayi2).GetType());
            Console.WriteLine(Convert.ToInt32(kesirlisayi3).GetType());
            Console.WriteLine(Convert.ToString(islemsonuc).GetType());

            Console.WriteLine();



            object nesne = "123456";
            Console.WriteLine("nesnenin veri tipi : " +nesne.GetType());
            nesne=Convert.ToDecimal(nesne); // nesne decimal tipine donustu
            Console.WriteLine("nesnenin veri tipi : " + nesne.GetType());
            Console.WriteLine("nesnenin veri tipi : " + nesne);

















        }
    }
}
