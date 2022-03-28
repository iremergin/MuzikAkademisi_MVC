using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class UyeninMuzikAletleri
    {
        public int UyeninMuzikAletleriId { get; set; }
        public int MuzikAletiId { get; set; }
        public MuzikAleti MuzikAleti { get; set; }
        public int UyeId { get; set; }
        public virtual Uye Uye { get; set; }



        public virtual Duyuru Duyuru { get; set; }


        
    }
}
