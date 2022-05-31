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
    public class OdevMap : EntityTypeConfiguration<Odev>
    {
        public OdevMap()
        {
            this.ToTable("tblOdev");
            this.Property(p => p.OdevId).HasColumnType("int");
            this.Property(p => p.OdevId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.OdevAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.OdevAciklama).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.OdevFotograf).HasColumnType("varchar").HasMaxLength(200);
            this.Property(p => p.OdevVerilmeTarihi).HasColumnType("datetime");
            this.Property(p => p.OdevTeslimTarihi).HasColumnType("datetime");

           
        }
    }
}
