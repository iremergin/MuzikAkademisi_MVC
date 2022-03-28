using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class Kart
    {
        public int KartId { get; set; }
        public virtual ICollection<KartinOdemeleri> KartinOdemeleris { get; set; }
        public string KartAdi { get; set; }
        public string KartNumarasi { get; set; }
        public DateTime KartTarihi { get; set; }
        public string Cvc { get; set; }
        public char KartDurumu { get; set; }


        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }
    }
}
