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
    public class YorumMap : EntityTypeConfiguration<Yorum>
    {
        public YorumMap()
        {
            this.ToTable("tblYorum");
            this.Property(p => p.YorumId).HasColumnType("int");
            this.Property(p => p.YorumId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.YorumIcerigi).HasColumnType("varchar").HasMaxLength(300);
            this.Property(p => p.Puanlama).HasColumnType("decimal");
            this.Property(p => p.ParentId).HasColumnType("int");


        }
    }
}
