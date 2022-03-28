using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class Odev
    {
        public int OdevId { get; set; }
        public virtual ICollection<UyeKursOdevleri> UyeKursOdevleris { get; set; }
        public string OdevAdi{ get; set; }
        public string OdevAciklama{ get; set; }
        public string OdevFotograf{ get; set; }
        public DateTime OdevVerilmeTarihi { get; set; }
        public DateTime OdevTeslimTarihi { get; set; }
        public char OdevDurumu{ get; set; }
    }
}
