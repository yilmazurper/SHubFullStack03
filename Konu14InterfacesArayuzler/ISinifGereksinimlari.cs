using System;
using System.Collections.Generic;
using System.Text;

namespace Konu14InterfacesArayuzler
{
    internal interface ISinifGereksinimlari // bu interface her class ta bulunmasi gereken zorunlu  ozellikler iceriyor
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } // nesneninolusma zamanini tutacak ozellik
        public DateTime UpdateDate { get; set; } // nesnenin son guncelleme zamanini tutacak ozellik
        public bool IsActive {  get; set; } // nesnenin aktiflik durumunu tutacak olan ozellik
    }
}
