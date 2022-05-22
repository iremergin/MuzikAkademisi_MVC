using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Mapping
{
   public class OdemeKursMuzikAletiMap : EntityTypeConfiguration<OdemeKursMuzikAleti>
    {
        public OdemeKursMuzikAletiMap()
        {
            this.ToTable("tblOdemeKursMuzikAleti");
            this.Property(p => p.OdemeKursMuzikAletiId).HasColumnType("int");
            this.Property(p => p.OdemeKursMuzikAletiId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.Odeme).WithMany(p => p.OdemeKursMuzikAletis).HasForeignKey(x => x.OdemeId);
            this.HasRequired(p => p.Kurs).WithMany(p => p.OdemeKursMuzikAletis).HasForeignKey(x => x.KursId);
            this.HasRequired(p => p.MuzikAleti).WithMany(p => p.OdemeKursMuzikAletis).HasForeignKey(x => x.MuzikAletiId);
        }
    }
}
