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
    public class UyeninMuzikAletleriMap : EntityTypeConfiguration<UyeninMuzikAletleri>
    {
        public UyeninMuzikAletleriMap()
        {
            this.ToTable("tblUyeninMuzikAletleri");
            this.Property(p => p.UyeninMuzikAletleriId).HasColumnType("int");
            this.Property(p => p.UyeninMuzikAletleriId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.MuzikAleti).WithMany(p => p.UyeninMuzikAletleris).HasForeignKey(x => x.MuzikAletiId); ;
            this.HasRequired(p => p.Uye).WithMany(p => p.UyeninMuzikAletleris).HasForeignKey(x => x.UyeId); ;
 
        }
    }
}
