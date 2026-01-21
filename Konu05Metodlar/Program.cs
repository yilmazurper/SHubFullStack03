
using System.Net.Mail;

namespace KonuMetodlar
{
    internal class Program
    {

        static void toplamayap()
        {
            //void olan metotlar geriye deger dondurmeyen metotlardir.
            Console.WriteLine(10 + 8);
        }


        static void Main(string[] args)
        {
            toplamayap();
            Console.WriteLine("Konu 05 metodlar!");
            Console.WriteLine();
            toplamayap(10, 8);
            Console.WriteLine();
            Console.WriteLine("geriye deger donduren metod");
            int sonuc = toplamayap(6, 6, 6);
            Console.WriteLine("sayilarin toplami:" + sonuc);
            Console.WriteLine();
            Console.WriteLine("email giriniz");
            var email = Console.ReadLine();
            var mailgonderildimi  = mailgonder(email);
            if (mailgonderildimi == true)
            {
                Console.WriteLine("mail gonderme islemi basarili");
            }
            else
            {
                Console.WriteLine("mail gonderme islemi basarisiz");
            }
        }

        static void toplamayap(int sayi1, int sayi2)



        {
            //parametreli metotlar
            Console.WriteLine(sayi1 + sayi2); // parametreli ve geriye deger dondurmeyen metot

        }
        static int toplamayap(int sayi1, int sayi2, int sayi3) //parametreli ve geriye deger donduren metot
        {


            return sayi1 + sayi2 + sayi3; //methoda gonderilen dgerleri toplayip geri dondurur

        }


        static bool mailgonder(string mailadresi)

        {
            if (!string.IsNullOrEmpty(mailadresi))

            {
                //mail gonderme islemi yapildi
                return true; //mail gonderme islemi basarili ise true dondur
            }

            {
                return false; //mail gonderme islemi basarisiz ise false dondur
            }


        }

    }
}
