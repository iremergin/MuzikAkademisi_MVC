using System;

namespace MuzikAkademisi.Entities.Model
{
    public class Duyuru
    {
      public int DuyuruId { get; set; }
      public string DuyuruAdi{ get; set; }
      public string DuyuruAciklama{ get; set; }
      public DateTime DuyuruTarihi{ get; set; }
      public char DuyuruDurumu { get; set; }


      public int KursId{ get; set; }
      public virtual Kurs Kurs { get; set; }

      public int MuzikAletiId{ get; set; }
      public virtual MuzikAleti MuzikAleti { get; set; }  
    }
}
