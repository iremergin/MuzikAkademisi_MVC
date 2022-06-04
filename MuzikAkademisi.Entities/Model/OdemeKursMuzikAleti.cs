using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Model
{
   public class OdemeKursMuzikAleti
    {
        public int OdemeKursMuzikAletiId { get; set; }
        public int? KursId { get; set; }
        public virtual Kurs Kurs { get; set; }
        public int? MuzikAletiId { get; set; }
        public virtual MuzikAleti MuzikAleti { get; set; }
        public int? OdemeId { get; set; }
        public virtual Odeme Odeme { get; set; }
    }
}
