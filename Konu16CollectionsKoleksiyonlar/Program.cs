using System.Collections; // koleksiyonlari kullanabilmak icin gerekli kutuphane
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Channels;

namespace Konu16CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 16 Collections Koleksiyonlar");
            Ornek1();
            Ornek2();
            Ornek3();

        }
        static void Ornek1()
       
        {
            ArrayList arrayList = new();
            arrayList.Add(1);
            arrayList.Add("iki");
            arrayList.Add(3.0);
            arrayList.Add(true);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Arraylist ilk eleman :" + arrayList[0]); // listede index ini verdigimiz elemana ulasma

        }
        static void Ornek2()

        {
            ArrayList arrayList = new();
            arrayList.Add("istanbul");
            arrayList.Add("ankara");
            arrayList.Add("izmir");
            arrayList.Add("Sirnak");
            arrayList.Add("mardin");
            arrayList.Add("hakkari");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Arraylistte siralama yapabiliriz");
            arrayList.Sort(); //a-z siralama
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            arrayList.Reverse(); // tersten siralam
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

        }

        public static void Ornek3()
        {
            var strings = new StringCollection();
            strings.Add("Diyarbakir");
            strings.Add("Sirnak");
            strings.Add("Van");
            // string.Add(34); // stringcolections a sadce string veriler eklenebilir
            Console.WriteLine("stringcollection");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
