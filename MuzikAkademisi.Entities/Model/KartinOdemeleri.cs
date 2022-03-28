using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class KartinOdemeleri
    {
        public int KartinOdemeleriId { get; set; }
        public int OdemeId { get; set; }
        public virtual Odeme Odeme { get; set; }
        public int KartId { get; set; }
        public virtual Kart Kart { get; set; }
        public int AdresId { get; set; }
        public virtual Adres Adres { get; set; }


     
    }
}
