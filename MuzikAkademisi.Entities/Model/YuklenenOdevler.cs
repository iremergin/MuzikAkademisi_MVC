using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Model
{
   public class YuklenenOdevler
    {
        public int YuklenenOdevlerId { get; set; }
        public int OdevId { get; set; }
        public virtual Odev Odev { get; set; }
        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }
        public string DosyaYolu { get; set; }
    }
}
