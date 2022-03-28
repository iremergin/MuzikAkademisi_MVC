using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class UyeKursOdevleri
    {
        public int UyeKursOdevleriId { get; set; }
        public int OdevId { get; set; }
        public virtual Odev Odev { get; set; }
        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }
        public int KursId { get; set; }
        public virtual Kurs Kurs { get; set; }


     
    }
}
