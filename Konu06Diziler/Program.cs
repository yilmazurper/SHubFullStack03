namespace Konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KOnu 06 Diziler!");
            //dizi olusturma
            int[] sayi;
            int[] ogrenciler = new int[6]; //ogrencilernisminde int veri tipi tasiyan ve 6 elemandan olusan bir dizi olusturduk , dizi boyutu artmaz , azalmaz

            //dizilerde indis denilen yapi vardur , dizilerde indis 0 dan baslar
            ogrenciler[0] = 100;
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500;
            ogrenciler[5] = 500; // DIZI DEGERLERI AYNI OLABILIR 
            // dizideki degere ulasma 
            Console.WriteLine("ogrenciler[5]:" + ogrenciler[5]);
            ogrenciler[5] = 550;// dizideki elemaninn degeri degisebilir 
            Console.WriteLine("ogrenciler[5]" + ogrenciler[5]);
            //ogrenciler[6]=600; // dizinin boyutunu asamayiz , hata verir , 0 dahil oldugu icin sayi 5'de biter 
            Console.WriteLine();

            string[] isimler = new string[5];
            isimler[0] = "Alp";
            isimler[1] = "ahmet";
            isimler[2] = "murat ";
            isimler[3] = "yilmaz";
            Console.WriteLine("isimler[3]:" + isimler[3]);

            Console.WriteLine();

            int[] ogrenciler2 = { 100, 200, 300, 400, 500 };
            Console.WriteLine("ogrenciler2[3]:"+ ogrenciler[3]);
            ogrenciler2[3]=550;
            Console.WriteLine("ogrenciler2[3]: " + ogrenciler2[3]);

            Console.WriteLine();

            string[] kategoriler = { "elektronik", "bilgisayar", "telefon ", "beyaz esya", "kitap" };
            Console.WriteLine("kategoriler[1]:" + kategoriler[1]);
            kategoriler[1] = "mutfak esyalari";
            Console.WriteLine("kategoriler 1:" + kategoriler[1]);

            Console.WriteLine();
            string[] urunler = { "urun 1", "urun 2", "urun 3 " };
            Console.WriteLine("urun 1: " + urunler[0]);

            Console.Read();




        }
    }
}
