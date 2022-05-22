using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Model
{
   public class UyeMuzikAletiKurs
    {
        public int UyeMuzikAletiKursId { get; set; }
        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }
        public int MuzikAletiId { get; set; }
        public virtual MuzikAleti MuzikAleti { get; set; }
        public int KursId { get; set; }
        public virtual Kurs Kurs { get; set; }

    }
}
