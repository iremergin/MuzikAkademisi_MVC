using System.Collections.Generic;
namespace MuzikAkademisi.Entities.Model
{
    public class MuzikAleti
    {
        public int MuzikAletiId { get; set; }
        public virtual ICollection<UyeninMuzikAletleri> UyeninMuzikAletleris { get; set; }
        public virtual ICollection<MuzikAletiSiparisleri> MuzikAletiSiparisleris { get; set; }
        public virtual ICollection<MuzikAletiKursYorumlari> MuzikAletiKursYorumlaris { get; set; }
        public string MuzikAletiAdi { get; set; }
        public string MuzikAletiAciklama{ get; set; }
        public string MuzikAletiFotograf{ get; set; }
        public decimal MuzikAletiFiyat{ get; set; }
        public short MuzikAletiAdedi{ get; set; }
        public string MuzikAletiTuru{ get; set; }
        public bool MuzikAletiDurumu{ get; set; }

        public virtual ICollection<Sepet> Sepets { get; set; }

    }
}
