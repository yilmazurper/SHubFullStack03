namespace Konu11Enumlar
{
    internal class Program
    {
        //Enum(numarator)'ler nesneleri numaralandirmak icin kullaniyoruz
        /*
         * enum tipler uzerindeki kisitlar
         * 1-enum blogunda metot kullanilmaz
         * 2-arayuz(interface) kullanmaslar
         * 3-enum blogunda property kullanilmaz
         * */
        enum aylar:byte
        {
            ocak=1 ,subat,mart,nisan,mayis,haziran,temmuz,agustos,eylul,ekim,kasim,aralik
        }
        enum siparisdurumu
        {
            hazirlaniyor ,hazirlandi,kargobekleniyor,kargolandi,iadeedildi
        }
        enum meyveler:int
        {
            elma=3,armut=7,cilek=1
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 11 Enumlar!");

            byte a = (byte)meyveler.armut;
            byte b = (byte)meyveler.elma;
            byte c = (byte)meyveler.cilek;
            Console.WriteLine($"{meyveler.armut}={a} ,{meyveler.elma}={b}  , {meyveler.cilek}={c}");
            ornek(siparisdurum: 1);
            ornek(3);

        }

        static void ornek(int siparisdurum)
        {
            if (siparisdurum==(int)siparisdurumu.hazirlaniyor)
            {
                Console.WriteLine("siparisiniz hazirlaniyor");
            }
            if (siparisdurum == (int)siparisdurumu.hazirlandi)
            {
                Console.WriteLine("siparisiniz hazirlandi");
            }
            if(siparisdurum == (int)siparisdurumu.kargobekleniyor)
            {
                Console.WriteLine("siparisiniz kargobekleniyor");
            }
            if(siparisdurum == (int)siparisdurumu.kargolandi)
            {
                Console.WriteLine("siparisiniz kargolandi");
            }
            if(siparisdurum == (int)siparisdurumu.iadeedildi)
            {
                Console.WriteLine("siparisiniz iadeedildi");
            }
        }

    }
}
