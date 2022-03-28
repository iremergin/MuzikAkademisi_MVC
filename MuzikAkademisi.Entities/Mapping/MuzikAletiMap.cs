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
    public class MuzikAletiMap : EntityTypeConfiguration<MuzikAleti>
    {
        public MuzikAletiMap()
        {
            this.ToTable("tblMuzikAleti");
            this.Property(p => p.MuzikAletiId).HasColumnType("int");
            this.Property(p => p.MuzikAletiId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MuzikAletiAdi).HasColumnType("varchar").HasMaxLength(50);       
            this.Property(p => p.MuzikAletiAciklama).HasColumnType("varchar").HasMaxLength(100);       
            this.Property(p => p.MuzikAletiFotograf).HasColumnType("varchar").HasMaxLength(200);       
            this.Property(p => p.MuzikAletiFiyat).HasPrecision(11,3);       
            this.Property(p => p.MuzikAletiAdedi).HasColumnType("int");       
            this.Property(p => p.MuzikAletiTuru).HasColumnType("varchar").HasMaxLength(50);       
        }
    }
}
