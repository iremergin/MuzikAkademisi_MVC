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
    public class AdresMap : EntityTypeConfiguration<Adres>
    {
        public AdresMap()
        {
            this.ToTable("tblAdres");
            this.Property(p => p.AdresId).HasColumnType("int");
            this.Property(p => p.AdresId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AdresAdi).HasColumnType("varchar").HasMaxLength(200);
            this.Property(p => p.AdresAitligi).HasColumnType("varchar").HasMaxLength(100);

            
        }
    }
}
