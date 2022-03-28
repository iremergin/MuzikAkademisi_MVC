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
    public class DuyuruMap : EntityTypeConfiguration<Duyuru>
    {
        public DuyuruMap()
        {
            this.ToTable("tblDuyuru");
            this.Property(p => p.DuyuruId).HasColumnType("int");
            this.Property(p => p.DuyuruId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.DuyuruAdi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.DuyuruAciklama).HasColumnType("varchar").IsMaxLength();
            this.Property(p => p.DuyuruTarihi).HasColumnType("date");
        }
    }
}
