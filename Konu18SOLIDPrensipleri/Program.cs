namespace Konu18SOLIDPrensipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 18 SOLID Prensipleri!");
            Console.WriteLine("Robet cecil Martin tarfindan one surulen gelistirilecek yazilimin esnek . yeniden kullanilabilir , surdurulebilir ve anlasilir olmasini hedefleyen , kod tekrarini onleyen prensibler butunudur ");
            Console.WriteLine();

            Console.WriteLine("S - Single Responsibility (tek sorumluluk Prensibi)");
            Console.WriteLine(" \t 1 sinif veya metodun sadece 1 sorumlulugunun olmasi gerekir");

            Console.WriteLine();

            Console.WriteLine("O - open -closed Principle");
            Console.WriteLine("\t bir sinif veya metot var olan ozelliklerini korumali degisiklige izin vermemelidir");

            Console.WriteLine();

            Console.WriteLine("l -Liskov Substitution");
            Console.WriteLine("kodlarimizda herhangi bir degisiklik yapmaya gerek duymadan alt siniflari turedikleri ust siinflrin yerine kullanabilmaliyiz");

            Console.WriteLine();

            Console.WriteLine("i - Interface Segregation");
            Console.WriteLine("sorumlulularin hepsini tek bir arayuzde toplamak yerine ozellestirilmis birden fazla arayuz kullanmaliyiz");

            Console.WriteLine();

            Console.WriteLine("d - dependency Inversion");
            Console.WriteLine("siniflar arasi bagimliklar olabildigince az olmalidir. ozellikle ust seviye siniflar alt seviye sinflara bagimli olmamalidir");
        }
    }
}
