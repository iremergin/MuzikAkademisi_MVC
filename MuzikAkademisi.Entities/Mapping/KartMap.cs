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
    public class KartMap : EntityTypeConfiguration<Kart>
    {
        public KartMap()
        {
            this.ToTable("tblKart");
            this.Property(p => p.KartId).HasColumnType("int");
            this.Property(p => p.KartId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KartAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.KartNumarasi).HasColumnType("char").HasMaxLength(16);
            this.Property(p => p.KartTarihi).HasColumnType("date");
            this.Property(p => p.Cvc).HasColumnType("char").HasMaxLength(3);

            this.HasRequired(p => p.Uye).WithMany(p => p.Karts).HasForeignKey(p => p.UyeId);
        }
    }
}
