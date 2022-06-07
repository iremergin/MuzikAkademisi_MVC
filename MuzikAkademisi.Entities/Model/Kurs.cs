using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class Kurs
    {
        

        public int KursId { get; set; }
        public virtual ICollection<UyeninKurslari> UyeninKurslaris { get; set; }
        public virtual ICollection<UyeKursOdevleri> UyeKursOdevleris { get; set; }
        public virtual ICollection<MuzikAletiKursYorumlari> MuzikAletiKursYorumlaris { get; set; }
       
        public virtual ICollection<UyeMuzikAletiKurs> UyeMuzikAletiKurs { get; set; }
        public virtual ICollection<OdemeKursMuzikAleti> OdemeKursMuzikAletis { get; set; }

        public string KursAdi { get; set; }
        public string KursAciklama { get; set; }
        public decimal KursFiyat { get; set; }
        public string KursFotograf { get; set; }
        public DateTime KursBaslamaTarihi { get; set; }
        public DateTime KursBitisTarihi { get; set; }
        public string OgrenciAktifKurslar { get; set; }
        public string OgrenciTamamlananKurslar { get; set; }
        public string EgitmenKursAlanlari { get; set; }
        public string EgitmenDahaOnceVerilmisKurslar { get; set; }
        public decimal OgrenciIlerlemeSeviyesi { get; set; }
        public int KursKatilimciSayisi { get; set; }
        public bool KursDurumu { get; set; }

        //TODO: Kullanıcıyı eğitmen ve öğrenci olarak ayır.
        //public int EgitmenId { get; set; }
        //public Uye Egitmen { get; set; }

     
        public virtual ICollection<Sepet> Sepets { get; set; }
        public virtual ICollection<ProgramCizelgesi> ProgramCizelgesis { get; set; }
        public virtual ICollection<Video> Videos { get; set; }



    }
}
