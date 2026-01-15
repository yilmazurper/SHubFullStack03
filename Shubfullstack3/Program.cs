Console.WriteLine("Hello, World!");
Console.WriteLine("this is demo ");
Console.WriteLine(2 * 2 + 2);

Console.Write("console");
Console.Write("write");
Console.WriteLine("selam");
Console.WriteLine("merhaba");


//Console.Read(); // tek karakterlik girdiyi bekler
//Console.ReadLine(); //enter tusuna basmayi bekler tum satir icin    

//degiskenler
//tam sayi veri tipleri
byte plaka_kodu; //0-255 arasi deger alir , 1 byte yer kaplar
plaka_kodu = 73; // degiskene deger atama
Console.WriteLine(plaka_kodu); // degiskenin degerini ekrana yazdirir

// degiskenler tiplerine gore bellekte stack ve heap iki ayri bolumde saklanir.deger tipli degiskenler stackte saklanir
// GC-cop toplayici sistemi 

byte birsayi, birsayidaha;
birsayi = 0;
birsayidaha = 255;
Console.WriteLine(birsayi);
Console.WriteLine(birsayidaha);

sbyte sbyteturu = 127; // -128 ile +127 arasinda deger alir
short kisa = 32767; // -32.768 ile +32.767 arasinda deger alir   
ushort birazuzun = 65535; //0 ile +65.535 arasinda deger alir 
int tam_sayi = -2147483648; // -2.147.483.648 ile +2.147.483.647 arasinda deger alir
uint uzuntamsayi = 4294967295; //0 ile +4.294.967.295 arasinda deger alir
long dahauzuntamsayi = -9223372036854775808; // -9.223.372.036.854.775.808 ile +9.223.372.036.854.775.807 arasinda deger alir
ulong enuzuntamsayi = 18446744073709551615; //0 ile +18.446.744.073.709.551.615 arasinda deger alir


//kesirli sayi degisken tipleri
float kesirlisayi = 4.5f; //4 byte yer kaplar
double kesirliSayi = 4.5; //8 byte yer kaplar

//decimal veri tipi
decimal urunfiyati = 9999; //16 byte yer kaplar

//char veri tipi
char karakter = 'A'; //2 byte yer kaplar , tek karakter saklar, sadece bir tane deger alir

//string veri tipi
string degisken; //metin saklar, birden fazla karakter saklayabilir
string degisken1, degisken2;
string metin = "string veri tipinde tum karaterleri kullanabilir";
Console.WriteLine(metin);


//boolean veri tipi
bool islemsonuc = false; //true veya false degerlerini alir

//islem basarili ise true , basarisiz ise false degerini alir
islemsonuc = true;

byte? kilo = null; //nullable degisken tanimlama eger bir degiskene baslangic degeri olarak null vermek istersek veri tipinin sonuna ? isareti koyariz
kilo = 85;

//bir urunun satista olup olmadigi bilgisini tutacak degisken
bool? issatistami = null;
//urun satista ise 
issatistami = true;  //true ayarla
// var iledegisken olusturma
var birdegisken="73"; //degiskenin tipini derleyici anlar ve o tipte olusturur var ile olusuturlan degiskenlerde degiskenin veri tipi
                       //c# tarafindan degiskene atatnan deegere gore otomatik algilanir
var birSayi = 73; //int tipinde degisken olusturur
var strmetin = "var kullanirsak degiskene bir deger atamak zorundayiz";
var sonuc = false ;
Console.WriteLine(birdegisken); // ctrl +d ile satiri cogaltma
Console.WriteLine(birdegisken.GetType());
Console.WriteLine(birSayi);
Console.WriteLine(birSayi.GetType());
Console.WriteLine(strmetin);
Console.WriteLine(strmetin.GetType());
Console.WriteLine(sonuc);
Console.WriteLine(sonuc.GetType());

sonuc = true;
//sonuc=1 ; // var ile tanimlnan bir degiskenin turu sonradan degistirlimez ancak icindeki deger degistirilebilir.
Console.WriteLine();
Console.WriteLine("objet veri tipi");
object nesne =" bu bir nesnedir"; //object veri tipi tum veri tiplerinin atandigi temel veri tipidir
Console.WriteLine(nesne);
Console.WriteLine(nesne.GetType());
nesne = 73;// nesne ile tanimlanan nesne degistirilebilir
Console.WriteLine(nesne);
Console.WriteLine(nesne.GetType());

object a = 10; //tam sayi degeri atandi
object b = 'k';//karakter degeri atandi
object c = "metin"; //string
object d = 12.9f; //float

Console.WriteLine();

//c# ta sabit tanimlama 
Console.WriteLine("c# ta sabit tanimlama");
const int kdvorani=18; //sabit tanimlama yapildi ve degeri atandi, sabitleri const ile tanimlayip program icerisinde kullaniblilirz
                       //sabitlerin degrei tanimlandigi yerde verilir ve sonradan degirtirlemez
                       //kdvorani=20; //sabitlerin degeri degistirilemez
const int iskonto=25;
Console.WriteLine("kdvorani:");
Console.WriteLine(kdvorani);

//ekrandan deger alma
Console.WriteLine("ekradan deger alma");
var deger =Console.ReadLine(); //ekrandan girilen degeri alir ve deger degiskenine atar 
Console.WriteLine("girdiginiz deger");
Console.WriteLine(deger);