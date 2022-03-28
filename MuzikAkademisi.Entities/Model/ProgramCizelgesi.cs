using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class ProgramCizelgesi
    {
        public int ProgramCizelgesiId { get; set; }
        public virtual ICollection<KursunProgramCizelgesi> KursunProgramCizelgesis { get; set; }
        public DateTime Gun { get; set; }
        public DateTime Ay { get; set; }
        public DateTime Yil { get; set; }
        public DateTime Saat { get; set; }
        public int KursId { get; set; }
        
    }
}
