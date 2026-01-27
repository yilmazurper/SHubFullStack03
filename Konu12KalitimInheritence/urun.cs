

namespace Konu12KalitimInheritence
{
    internal class Urun : Ortakozellikler
    {
        public decimal fiyat { get; set; }
        public int stok {  get; set; }
        public int kdv {  get; set; }
        public int iskanto {  get; set; }
        public string? TeknikOzellikler { get; set; } // urun eklerken teknik ozellikler bos gecilebilsin diye 


    }
}
