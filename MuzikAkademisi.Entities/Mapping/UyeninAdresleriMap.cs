using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using MuzikAkademisi.Entities.Model;

namespace MuzikAkademisi.Entities.Mapping
{
    public class UyeninAdresleriMap : EntityTypeConfiguration<UyeninAdresleri>
    {
        public UyeninAdresleriMap()
        {
            this.ToTable("tblUyeninAdresleri");
            this.Property(p => p.UyeninAdresleriId).HasColumnType("int");
            this.Property(p => p.UyeninAdresleriId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.Adres).WithMany(p => p.UyeninAdresleris).HasForeignKey(x => x.AdresId);
            this.HasRequired(p => p.Uye).WithMany(p => p.UyeninAdresleris).HasForeignKey(x => x.UyeId);

        }

    }
}
