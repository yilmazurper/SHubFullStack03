using System.ComponentModel.DataAnnotations;

namespace konu03operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("konu03 Operatorler");
            Console.WriteLine("1-Aritmetik Operatorler");
            double sayi1 = 3;
            double sayi2 = 4;
            double sayi3 = 5;
            Console.WriteLine();
            Console.WriteLine($"sayilar sayi1: {sayi1},sayi2:{sayi2},sayi3:{sayi3}"); //string tirnaginin onune $ isareti koyarak string interpolasyonu yapiyoruz
            Console.WriteLine("1234" +sayi3);  // sring ile int arasinda + islemi yapildiginda toplama yerine birlestirme islemi yapilir
            Console.WriteLine();

            Console.WriteLine("hesaplama islemleri:");
            Console.WriteLine("sayi1+sayi2:" + (sayi1 + sayi2));
            Console.WriteLine("sayi1-sayi2:" + (sayi1 - sayi2));
            Console.WriteLine("sayi1*sayi2:" + (sayi1 * sayi2));
            Console.WriteLine("sayi1/sayi2:" + (sayi1 / sayi2));
            Console.WriteLine("sayi1%sayi2:" + (sayi1 % sayi2));

            Console.WriteLine();

            Console.WriteLine("artirim ve azaltim operatorleri:");
            sayi2++; // degisknin degerini  1 artirir.
            Console.WriteLine("sayi2:" +sayi2);

            sayi2--; // degisknin degerini 1 azaltir
            Console.WriteLine("sayi2:"+sayi2);

            Console.WriteLine();

            Console.WriteLine("atama operatorleri:");
            Console.WriteLine($"sayilar sayi1: {sayi1},sayi2:{sayi2},sayi3:{sayi3}");
            Console.WriteLine("sayi1+=sayi2:" + (sayi1 += sayi2));
            Console.WriteLine("sayi1-=sayi2:" + (sayi1 -= sayi2));
            Console.WriteLine("sayi1*=sayi2:" + (sayi1 *= sayi2));
            Console.WriteLine("sayi1/=sayi2:" + (sayi1 /= sayi2));
            Console.WriteLine("sayi1%=sayi2:" + (sayi1 %= sayi2));


            Console.WriteLine("iliskisel operatorler");//birden fazla degeri karsilastirip aralarindaki durumu ogrenemk icin kullaniriz

            Console.WriteLine($"sayilar sayi1: {sayi1},sayi2:{sayi2},sayi3:{sayi3}");
            Console.WriteLine("sayi1==sayi2:" + (sayi1 == sayi2));
            Console.WriteLine("sayi1!=sayi2:" + (sayi1 != sayi2));
            Console.WriteLine("sayi1>sayi2:" + (sayi1 > sayi2));
            Console.WriteLine("sayi1<sayi2:" + (sayi1 < sayi2));
            Console.WriteLine("sayi1>=sayi2:" + (sayi1 >= sayi2));
            Console.WriteLine("sayi1<=sayi2:" + (sayi1 <= sayi2));

            Console.WriteLine();

            Console.WriteLine("ternary operatoru"); // eger karsilastirma icin 2 deger kullanacaksak karsilastirmanin kisayolu olarak kullaniriz 
            Console.WriteLine("ternary:");
            Console.WriteLine((sayi1 < sayi2) ? "sayilar esit" : "sayilar esit degil");



            Console.WriteLine();


            Console.WriteLine("mantiksal operatorler");
            Console.WriteLine("and & operatoru");
            Console.WriteLine("% operatoru her ikin sartinda saglanmasini ister");

            Console.WriteLine();

            string email ="admin.com" , sifre = "adm123";
            Console.WriteLine("email giriniz");
            var girilenmail = Console.ReadLine();
            Console.WriteLine("sifre giriniz");
            var girilensifre = Console.ReadLine();
            Console.WriteLine(girilenmail==email && girilensifre==sifre ? "giris basarili" : "giris basarisiz");

            Console.WriteLine();

            Console.WriteLine("veya | ooperator");
            Console.WriteLine("|operatoruher iki sarttan birinin saglanmasini ister");

            Console.WriteLine();

            Console.WriteLine(girilenmail==email | girilensifre==sifre ? "giris basarili" : "giris basarisiz");





























        }
    }
}
