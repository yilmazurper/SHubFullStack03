namespace Konu09StructYapilar
{
    public struct Yapi
    {
        // public struct ad = "ali" ; // struct kullaniminda class dan farkli olrak ogelere baslangic degeri atanmaz
        public int sayi;
        public string metin;
        public int MyProperty { get; set; }
        public void Metot()
        {
            Console.WriteLine("yapi icindeki metot calisti");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 09 Struct Yapilar");
            Yapi yapi = new Yapi();
            yapi.metin = "yapi metin";
            yapi.sayi = 1;
            yapi.Metot();
            Console.WriteLine(yapi.metin);
                
        }
    }
}
