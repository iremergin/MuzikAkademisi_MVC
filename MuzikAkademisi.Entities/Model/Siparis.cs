using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class Siparis
    {
        public int SiparisId { get; set; }
        public virtual ICollection<MuzikAletiSiparisleri> MuzikAletiSiparisleris { get; set; }
        public string SiparisAdi { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public char SiparisTakipNo { get; set; }
        public char SiparisDurumu { get; set; }
     
    }
}
