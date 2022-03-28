using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Model
{
    public class UyeninAdresleri
    {
        public int UyeninAdresleriId { get; set; }
        public int AdresId { get; set; }
        public virtual Adres Adres { get; set; }
        public int UyeId { get; set; }
        public virtual Uye Uye{ get; set; }
 
        
    }
}
