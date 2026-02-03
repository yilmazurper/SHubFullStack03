using System.Collections; // koleksiyonlari kullanabilmak icin gerekli kutuphane
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Konu16CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 16 Collections Koleksiyonlar");
            //Ornek1();
            //Ornek2();
            //Ornek3();
           //Ornek4();
            //Ornek5();
            ListKullanimi();

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

        static void Ornek4()
        {
            var dictionary = new StringDictionary(); //key value seklinde saklayabilir
            dictionary.Add("18", "Cankiri");
            dictionary.Add("06", "Ankara");
            dictionary.Add("34", "istanbul");
            dictionary.Add("01", "Adana");
            dictionary.Add("58", "Sivas");
            Console.WriteLine();
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("dictionary.Keys:");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();
            Console.WriteLine("dictionary.Values:");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }

        }

        static void Ornek5()
        {

            Dictionary<string, string> dictionary = new(); //hangi veri tipinden olusacxagini bizim belirleyecegimiz liste istemi

            dictionary.Add("book", "kitap");
            dictionary.Add("18", "Cankiri");
            dictionary.Add("34", "istanbul");
            Console.WriteLine(dictionary["book"]);

            Console.WriteLine();

            Dictionary<int, string> dictionary2 = new();

            dictionary2.Add(1, "Adana");
            dictionary2.Add(18, "Cankiri");
            dictionary2.Add(34, "istanbul");

            Console.WriteLine();

            foreach (var item in dictionary2)
            {
                 Console.WriteLine(item.Value);

            }

            Console.WriteLine("dictionary2 Keys:");

            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key);
            }

        }
        static void ListKullanimi()
        {
            Console.WriteLine("list Kullanimi");
            List<string>sehirler = new(); // string veri tipi alabilen bir liste
            sehirler.Add("Ankara");
            sehirler.Add("Istanbul");
            sehirler.Add("Sirnak 73 ");
            sehirler.Add("Diyarbakir");
            sehirler.Add("Budapeste");
            //sehirler.add(18); // list,string >defidigimiz icin string disinda listeye ekleme yapamayiz 


            Console.WriteLine("sehirler:");
            foreach (var item in sehirler) //sehirler isimli lsitede don
            {
                Console.WriteLine(item); // listedeki her nesneyi ekrana yaz
            }

            Console.WriteLine();


            List<User> users = new();
            users.Add(new User
            {
                Id = 1, Name = "Yilmaz", Email = "ylmz", Password = "123"
            });
            users.Add(new User
            {
                Id = 2,
                Name = "Guney",
                Email = "gny",
                Password = "321"
            });
            Console.WriteLine("Kullanicilar");
            foreach (var item in users)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }
            Console.WriteLine();

            List<User> kullanicilar = new()
            {
                new User
                {
                     Id = 3,
                Name = "Ardil",
                Email = "ard",
                Password = "a123"

                },
                new User
                {
                     Id = 4,
                Name = "Arven",
                Email = "Solin",
                Password = "As321"
                }

            };
            Console.WriteLine("Kullanicilar 2");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }

            Console.WriteLine();
            var yeniKullanici = new User
            {
                Id = 5,
                Name = "zubeyde",
                Email = "zbyd",
                Password = "Zz123"
            };
            Console.WriteLine("kullanicilar listesinde yeniKulanici var mi : ?");
            var varmi = kullanicilar.Contains(yeniKullanici); //cantains metotdu ile bir listede arama yapabilriiz
            Console.WriteLine("varmi ?"+ varmi);
            kullanicilar.Add(yeniKullanici);
            Console.WriteLine("simdi varmi? " + kullanicilar.Contains(yeniKullanici));
            Console.WriteLine();
            Console.WriteLine("kullanicilar 3:");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }

            Console.WriteLine();
            kullanicilar.AddRange(users); // AddRange metodu listeye coklu kayit eklememizi saglar
            kullanicilar.Insert( 0 , yeniKullanici); // insert metodu listeye verdigimiz indexe ekleme yapmamizi saglar

            Console.WriteLine();
            Console.WriteLine("kullanicilar 4:");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }
            Console.WriteLine();
            Console.WriteLine("listedeki kayit sayisi : " + kullanicilar.Count); // count listedeki eleman sayisini getirir,
        }
	
    }
}
