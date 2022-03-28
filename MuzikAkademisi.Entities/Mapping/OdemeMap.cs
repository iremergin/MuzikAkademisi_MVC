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
    public class OdemeMap : EntityTypeConfiguration<Odeme>
    {
        public OdemeMap()
        {
            this.ToTable("tblOdeme");
            this.Property(p => p.OdemeId).HasColumnType("int");
            this.Property(p => p.OdemeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.OdemeSecenegi).HasColumnType("char").HasMaxLength(1);
            this.Property(p => p.KargoSecenegi).HasColumnType("char").HasMaxLength(1);
            this.Property(p => p.OdemeTarihi).HasColumnType("date");
        }

    }
}
