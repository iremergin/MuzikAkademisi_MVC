using System;
using System.Collections.Generic;

namespace MuzikAkademisi.Entities.Model
{
    public class Duyuru
    {
      public int DuyuruId { get; set; }
      public string DuyuruAdi{ get; set; }
      public string DuyuruAciklama{ get; set; }
      public DateTime DuyuruTarihi{ get; set; }
      public bool DuyuruDurumu { get; set; }


   

    }
}
