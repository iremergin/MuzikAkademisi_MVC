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
    public class SiparisMap : EntityTypeConfiguration<Siparis>
    {
        public SiparisMap()
        {
            this.ToTable("tblSiparis");
            this.Property(p => p.SiparisId).HasColumnType("int");
            this.Property(p => p.SiparisId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SiparisAdi).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
