using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MuzikAkademisi.Entities.Model
{
    public class Odev
    {
        [Key]
        public int OdevId { get; set; }
        public virtual ICollection<UyeKursOdevleri> UyeKursOdevleris { get; set; }
        public virtual ICollection<YuklenenOdevler> YuklenenOdevler { get; set; }
        public string OdevAdi{ get; set; }
        public string OdevAciklama{ get; set; }
        public string OdevFotograf{ get; set; }
        public DateTime OdevVerilmeTarihi { get; set; }
        public DateTime OdevTeslimTarihi { get; set; }
        public bool OdevDurumu{ get; set; }
    }
}
