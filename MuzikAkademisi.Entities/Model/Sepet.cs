using System;
using System.Collections.Generic;


namespace MuzikAkademisi.Entities.Model
{
    public class Sepet
    {
        public int SepetId { get; set; }
        public int? KursId { get; set; }
        public virtual Kurs Kurs { get; set; }
        public int? MuzikAletiId { get; set; }
        public virtual MuzikAleti MuzikAleti { get; set; }
        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }


    }
}
