namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu07Donguler!");
            Console.WriteLine("1-For dongusu");
            for (int i = 0; i < 5; i++) //i degiskeni olusturduk , i 0 dan baslar , i 5 e esit veya kucuk oldugu surece dongu devam eder , her dongude i degeri 1 artar
            {
                Console.WriteLine("i degiskenin degeri : {0} " , i);
            }
            Console.WriteLine();

            Console.WriteLine("2-While dongusu"); //kosul kontrolu dongusu
            int j = 0; //j degiskeni olusturduk , disarda bir degisken tanimliyorum
            while (j<5) //j 5'ten kucuk oldugu surece don 
            {
                Console.WriteLine("j degiskenin degeri : {0} " , j);
                j++; //j degerini 1 artiriyoruz
            }
            Console.WriteLine();

            Console.WriteLine( "3-Do While dongusu");

            int toplam = 5;
            do
            {
                Console.WriteLine("toplam'in degeri: "+ toplam); //once kod calisir
                toplam++; //toplam degerini 1 artiriyoruzg
            }
            while (toplam < 5 ); //sonra sarta bakar , sarta uymasa bile kod en az 1 kere calisir

            Console.WriteLine();

            Console.WriteLine("4-Foreach dongusu");
            string[] kategoriler = { "elektronik", "bilgisayar", "telefon ", "beyaz esya", "kitap" };
            Console.WriteLine("kotegoriler");
            foreach (var item in kategoriler) //kategoriler dizisindeki her bir elemani tek tek kategori degiskenine atar ve donguyu dondurur
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Ic Ice dongu kullanimi");
            string[] urunler = { "urun 1", "urun 2", "urun 3 " };// elimizdeki ornek urun listesi var
            foreach (var kategori in kategoriler)  // kategoruler isimli dizie donuyoruz
            {
                Console.WriteLine(kategori); //kategoriler dizisindeki her kategoriyi yazdiriyoruz
                foreach (string item in urunler) //ekrana kategori adini yazdiktan sonra urunler isimli dizide don 
                {
                    Console.WriteLine("\t" + item); //ve listedeki her urunu tek tek ekrana yazdir

                }   
            }

            Console.WriteLine();

            Console.WriteLine("ic ice for dongusu");
            for (int i = 0; i < 5; i++) //kategoriler dizisinin uzunlugu kadar dis dongu
            {
                Console.WriteLine("1. dongudeki i nin degeri :" +i); //kategoriler dizisindeki her kategoriyi yazdiriyoruz
                for (int k = 0; k < 3; k++) //urunler dizisinin uzunlugu kadar ic dongu
                {
                    Console.WriteLine("\t 2. dongudeki k nin degeri :" + k); //urunler dizisindeki her urunu yazdiriyoruz
                }
            }



        }
    }
}
