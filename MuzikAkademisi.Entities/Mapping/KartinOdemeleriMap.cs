using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuzikAkademisi.Entities.Mapping
{
    public class KartinOdemeleriMap : EntityTypeConfiguration<KartinOdemeleri>
    {
        public KartinOdemeleriMap()
        {
            this.ToTable("tblKartinOdemeleri");
            this.Property(p => p.KartinOdemeleriId).HasColumnType("int");
            this.Property(p => p.KartinOdemeleriId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.Odeme).WithMany(p => p.KartinOdemeleris).HasForeignKey(x => x.OdemeId); 
            this.HasRequired(p => p.Kart).WithMany(p => p.KartinOdemeleris).HasForeignKey(x => x.KartId);
            this.HasRequired(p => p.Adres).WithMany(p => p.KartinOdemeleris).HasForeignKey(x => x.AdresId);
        }
    }
}
