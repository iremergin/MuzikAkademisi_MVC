using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class MuzikAletiSiparisleri
    {
        public int MuzikAletiSiparisleriId { get; set; }
        public int MuzikAletiId { get; set; }
        public virtual MuzikAleti MuzikAleti { get; set; }
        public int SiparisId { get; set; }
        public virtual Siparis Siparis { get; set; }
    
    }
}
