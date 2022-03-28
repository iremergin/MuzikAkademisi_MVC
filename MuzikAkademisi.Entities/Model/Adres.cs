using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class Adres
    {
        public int AdresId { get; set; }
        public virtual ICollection<UyeninAdresleri> UyeninAdresleris { get; set; }
        public virtual ICollection<KartinOdemeleri> KartinOdemeleris { get; set; }
        public string AdresAdi { get; set; }
        public string AdresAitligi { get; set; }
        public char AdresDurumu { get; set; }
    }
}
