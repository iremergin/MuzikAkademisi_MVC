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
    public class UyeninKurslariMap : EntityTypeConfiguration<UyeninKurslari>
    {
        public UyeninKurslariMap()
        {
            this.ToTable("tblUyeninKurslari");
            this.Property(p => p.UyeninKurslariId).HasColumnType("int");
            this.Property(p => p.UyeninKurslariId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.Kurs).WithMany(p => p.UyeninKurslaris).HasForeignKey(x => x.KursId);
            this.HasRequired(p => p.Uye).WithMany(p => p.UyeninKurslaris).HasForeignKey(x => x.UyeId); 
        }
    }
}
