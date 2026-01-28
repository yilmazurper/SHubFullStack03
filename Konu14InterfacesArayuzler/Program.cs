namespace Konu14InterfacesArayuzler
{
    public interface OrnekArayuz   //class yerine interface kelimeisni kullanarak tanimliyouruz
    {
        public int Id {  get; set; }
    }
    interface IDemo
    {
        void Goster(); // metot imzasi
    }
    interface icerebilecekleri : IDemo // interface'ler baska interfacelerden miras alabilir
    {
        //bu interface 'i kullanacak olan classlar asagidaki varliklari kullanmak zorundadir
        public int sayi {  get; set; }
        public static int sayi2 {  get; set; }
        // interface'lerde metotlar degil sadece imzalari yer alir
        void Topla(); // geri dondurmeyen metot imzasi
        int ToplamaYap(); // geri int deger dondurmesi gereken metot imzasi
    }
    class ArayuzKullanimi : icerebilecekleri //bu sekilde miras aldigimizda interface'lrr icerisindeki varliklar class'ta kullanmak zorundadir
    {
        public int sayi { get; set; }
        public int Id { get; set; } //class icerisinde interface deolmayan ama class ta olmasi 


        public void Goster() //interface'de imzasi bulunan metot class icinde kullanilmak zorundadir 
        {
            Console.WriteLine("void goster metodu");
        }

        public void Topla()
        {
            Console.WriteLine("void topla metodu");
        }

        public int ToplamaYap()
        {
            return sayi + 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 14 Interfaces-Arayuzler");
            ArayuzKullanimi arayuz = new ArayuzKullanimi();
            arayuz.ToplamaYap();
            arayuz.sayi = 1;
            arayuz.Topla();
            arayuz.Goster();
            Console.WriteLine("toplama sonucu :" + arayuz.ToplamaYap());
        }
    }
}
