namespace Konu08SiniflarClasses
{
    internal class urun
    {
        //clas icinde degisken -field kullanimi
        internal int id;
        internal string name;
        internal decimal fiyati;
        //class icinde property kullanimi
        public string urunaciklamasi {  get; set; }
        public string umarkasi {  get; set; }
        public bool durum {  get; set; }
        public int kategoriId {  get; set; } //uurn hangi kategoriye ait oldugu bilgisini tutar
        public Kategori? Kategori { get; set; } // navigation property urun ve kategoru arasinda iliski kurar


    }
}
