namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu04 Karar Yapilari !");

            /*Console.WriteLine("bir sayi giriniz:");

            var sayi = Convert.ToDecimal(Console.ReadLine());

            if (sayi > 0) // eger girilen sayi sifirdn buyukse 
            {
                Console.WriteLine("girilen sayi pozitif");
            }
            else if (sayi < 0) // yukaridaki sart degilse eger 
            {
                Console.WriteLine("girilen sayi negatif");
            }
            else
            {
                Console.WriteLine("girilen sayi sifirdir");
            }
            
            */

            Console.WriteLine();

            /*
            Console.WriteLine("kullanici adiniz");
            var kullaniciadi =Console.ReadLine();
            Console.WriteLine("siferniz");
            var sifre = Console.ReadLine();

            if (kullaniciadi == "admin" && sifre == "1234")
            {
                Console.WriteLine("giris basarili");
                Console.WriteLine("hosgeldin ABiM benim");
            }
            else
            {
                Console.WriteLine("kullanici adi veya sifre hatali");
            }


            */


            int saat = DateTime.Now.Hour;

            if (saat < 18)
            {
                Console.WriteLine("iyi gunler efendim: " + saat);
            }
            else
            {
                Console.WriteLine("iyi aksamlar efendim:" + saat);

            }

            Console.WriteLine("switch case yapisi ile akis kontrolu");
            int ay = DateTime.Now.Month;
            Console.WriteLine("bulundugumuz ay :" + ay);
            switch (ay)
            { 
            case 12:
            case 1:
            case 2:
                    Console.WriteLine("kis mevsimindeyiz");
            break;

        case 3:
        case 4:
        case 5:
            Console.WriteLine("ilkbahar mevsimindeyiz");
            break;

        case 6:
        case 7:
        case 8:
            Console.WriteLine("yaz mevsimindeyiz");

            break;

        case 9:
        case 10:
        case 11:

            Console.WriteLine("sonbahar mevsimindeyiz");
            break;
            default:
                Console.WriteLine("gecersiz ay degeri");
            break;

        }





















        }
    }
}
