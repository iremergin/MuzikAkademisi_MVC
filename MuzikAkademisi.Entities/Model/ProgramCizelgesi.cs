using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class ProgramCizelgesi
    {
        public int ProgramCizelgesiId { get; set; }
        public string Gun { get; set; }
        public DateTime Ay { get; set; }
        public DateTime Yil { get; set; }
        public DateTime Saat { get; set; }
        public int KursId { get; set; }
        public virtual Kurs Kurs { get; set; }

        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }




    }
}
 