using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class Yorum
    {
        public int YorumId { get; set; }
        public virtual ICollection<MuzikAletiKursYorumlari> MuzikAletiKursYorumlaris { get; set; }
        public string YorumIcerigi { get; set; }
        public decimal Puanlama { get; set; }
        public char YorumDurumu { get; set; }
        public int ParentId { get; set; }
    }
}
