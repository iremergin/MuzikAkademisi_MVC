using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class Odeme
    {
        public int OdemeId { get; set; }
        public virtual ICollection<KartinOdemeleri> KartinOdemeleris { get; set; }
        public string OdemeSecenegi { get; set; }
        public string KargoSecenegi { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public char OdemeDurumu { get; set; }
    }
}
