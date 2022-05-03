using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Model
{
    public class Uye
    {
        public int UyeId { get; set; }
        public virtual ICollection<UyeninAdresleri> UyeninAdresleris { get; set; }
        public virtual ICollection<UyeninKurslari> UyeninKurslaris { get; set; }
        public virtual ICollection<UyeninMuzikAletleri> UyeninMuzikAletleris { get; set; }
        public virtual ICollection<UyeKursOdevleri> UyeKursOdevleris { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string UyeKullaniciAdi { get; set; }
        public string UyeCinsiyet { get; set; }
        public DateTime UyeDogumTarihi { get; set; }
        public string UyeDogumYeri { get; set; }
        public string UyeMail { get; set; }
        public string UyeTelefon { get; set; }
        public string UyeSifre { get; set; }
        public string UyeFotograf{ get; set; }
        public string UyeKodu{ get; set; }
        public string UyeTuru{ get; set; }
        public bool UyeDurumu{ get; set; }

       // public virtual ICollection<Kurs> Egitmens { get; set; }

        public virtual ICollection<Kart> Karts { get; set; }
       


    }
}
