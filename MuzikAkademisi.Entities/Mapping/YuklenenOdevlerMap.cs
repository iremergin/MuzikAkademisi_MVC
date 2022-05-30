using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Mapping
{
   public class YuklenenOdevlerMap : EntityTypeConfiguration<YuklenenOdevler>
    {
       
            public YuklenenOdevlerMap()
            {
                this.ToTable("tblYuklenenOdevler");
                this.Property(p => p.YuklenenOdevlerId).HasColumnType("int");
                this.Property(p => p.YuklenenOdevlerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


                this.HasRequired(p => p.Uye).WithMany(p => p.YuklenenOdevler).HasForeignKey(p => p.UyeId);
                this.HasRequired(p => p.Odev).WithMany(p => p.YuklenenOdevler).HasForeignKey(p => p.OdevId);
            }
        
    }
}
