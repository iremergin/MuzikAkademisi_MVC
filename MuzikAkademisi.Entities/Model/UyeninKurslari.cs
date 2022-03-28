using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class UyeninKurslari
    {
        public int UyeninKurslariId { get; set; }
        public int KursId { get; set; }
        public virtual Kurs Kurs { get; set; }
        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }


    }
}
