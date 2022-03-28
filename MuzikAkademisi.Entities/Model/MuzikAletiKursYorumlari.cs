using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class MuzikAletiKursYorumlari
    {
        public int MuzikAletiKursYorumlariId { get; set; }
        public int YorumId { get; set; }
        public virtual Yorum Yorum { get; set; }
        public int KursId { get; set; }
        public virtual Kurs Kurs { get; set; }
        public int MuzikAletiId { get; set; }
        public virtual MuzikAleti MuzikAleti { get; set; }
    }
}
