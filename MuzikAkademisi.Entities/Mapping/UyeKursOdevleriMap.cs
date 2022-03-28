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
    public class UyeKursOdevleriMap : EntityTypeConfiguration<UyeKursOdevleri>
    {
        public UyeKursOdevleriMap()
        {
            this.ToTable("tblUyeKursOdevleri");
            this.Property(p => p.UyeKursOdevleriId).HasColumnType("int");
            this.Property(p => p.UyeKursOdevleriId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.Uye).WithMany(p => p.UyeKursOdevleris).HasForeignKey(x => x.UyeId);
            this.HasRequired(p => p.Odev).WithMany(p => p.UyeKursOdevleris).HasForeignKey(x => x.OdevId);
            this.HasRequired(p => p.Kurs).WithMany(p => p.UyeKursOdevleris).HasForeignKey(x => x.KursId);
        }
    }
}
