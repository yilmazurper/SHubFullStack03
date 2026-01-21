using System.Collections.Concurrent;

namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 10 String Sinifi!");
            string degisken;
            char karakter = 'a';
            string metinlericin = "yanyana karakterlerden olusan metin";
            //ornek1();
            //stringmetotlari();
            splitmetodu();
        }
        static void ornek1()

        { 
            string birmetin = "Ankara Baskenttir";
            string birsayi = "123456789";
            System.String birtarih = "21.01.2026";
            string kod = "//5456dfgd\n"; // buradaki \n kodu enter gotrevi gorur ve kendinden sonra gelecek olan metni bir alt satira kaydirir
            Console.WriteLine(birmetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birtarih.GetType());
            Console.WriteLine(kod);

            string s = "Yilmaz Guney";
            Console.WriteLine(s);
            Console.WriteLine("for dongusu");
            for (int i = 0; i < s.Length; i++) //s degiskenin uzunlugu kadar don 
            {
                Console.WriteLine(s[i]); // s degiskenin i indexinde degeri kadar yazdirir
            }

            Console.WriteLine();
            Console.WriteLine("foreach dongusu");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            
            
        }


        static void stringmetotlari()
        {
            string metin = "stringin bir cok metotdu vardir";
            Console.WriteLine(metin);
            Console.WriteLine("metin'in karakter sayisi:metin.lenght " + metin.Length);
            Console.WriteLine();

            var klon = metin.Clone(); // clone metotdu metin degiskeninnin klonlayip klon degiskenine atar
            Console.WriteLine("metin klonu:" + klon);
            Console.WriteLine();

            metin = "my name is YILMAZ";
            Console.WriteLine(metin + " Endswith i: " + metin.EndsWith("i"));
            Console.WriteLine(metin + " Endswith r: " + metin.EndsWith("r"));

            Console.WriteLine();

            Console.WriteLine(metin + " startswith s: " + metin.StartsWith("s"));
            Console.WriteLine(metin + " startswith m: " + metin.StartsWith("m"));
            Console.WriteLine(metin + " startswith M: " + metin.StartsWith("M"));

            Console.WriteLine();

            Console.WriteLine(metin + " indexof name: " + metin.IndexOf("name"));
            Console.WriteLine(metin + " IndexOf Name: " + metin.IndexOf("Name"));
            Console.WriteLine(metin + " LastIndexOf i: " + metin.LastIndexOf("i"));

            Console.WriteLine();

            Console.WriteLine(metin + " Insert Merhaba: " + metin.Insert(0 , " Merhaba "));
            Console.WriteLine(metin);

            Console.WriteLine();

            Console.WriteLine("substring 2:" + metin.Substring(2));
            Console.WriteLine("substring 2 , 5 :" + metin.Substring(2 , 5 )); // 2. indexten baslayarak 5 karakter

            Console.WriteLine();

            Console.WriteLine("metin.tolower: " + metin.ToLower());
            Console.WriteLine("metin.toupper: " + metin.ToUpper());
            Console.WriteLine("metin.tolower replace: " + metin.ToLower().Replace(" ", "-")); // metni kucuk harfe cevir ve icindeki bosluklari - iledegisitr
            Console.WriteLine("metin.remove2: " + metin.Remove(2));
            Console.WriteLine("metin.remove2: " + metin.Remove(2 , 5));

        }
        static void splitmetodu()
        {
            string sehirler = "istanbul, ankara, izmir , sirnak , sivas";
            Console.WriteLine(sehirler);
           
            string [] sehirlerArray = sehirler.Split(','); //split verilen karaktere gore metni parcalar
            Console.WriteLine("4. Sehir: " + sehirlerArray[3]);
            foreach (var item in sehirlerArray)
            {
                Console.WriteLine("sehir: " + item);
            }



        }

    }
}
