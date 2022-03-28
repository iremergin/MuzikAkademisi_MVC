using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Model
{
   public class KursunProgramCizelgesi
    {
        public int KursunProgramCizelgesiId { get; set; }
        public int ProgramCizelgesiId { get; set; }
        public virtual ProgramCizelgesi ProgramCizelgesi { get; set; }
        public int KursId { get; set; }
        public virtual Kurs Kurs { get; set; }
    }
}
