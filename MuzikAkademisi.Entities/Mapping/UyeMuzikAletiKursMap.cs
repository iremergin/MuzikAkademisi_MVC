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
   public class UyeMuzikAletiKursMap : EntityTypeConfiguration<UyeMuzikAletiKurs>
    {
        public UyeMuzikAletiKursMap()
        {
            this.ToTable("tblUyeMuzikAletiKurs");
            this.Property(x => x.UyeMuzikAletiKursId).HasColumnType("int");
            this.Property(x => x.UyeMuzikAletiKursId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.HasRequired(p => p.Uye).WithMany(p => p.UyeMuzikAletiKurs).HasForeignKey(x => x.UyeId);
            this.HasRequired(p => p.MuzikAleti).WithMany(p => p.UyeMuzikAletiKurs).HasForeignKey(x => x.MuzikAletiId);
            this.HasRequired(p => p.Kurs).WithMany(p => p.UyeMuzikAletiKurs).HasForeignKey(x => x.KursId);
        }
    }
}
