using System;
using System.Collections.Generic;
using System.Text;

namespace Konu14InterfacesArayuzler
{
    internal class Urun : ISinifGereksinimlari
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } 
        public DateTime UpdateDate { get; set; } 
        public bool IsActive { get; set; } 
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public int Stock {  get; set; }
    }

}
