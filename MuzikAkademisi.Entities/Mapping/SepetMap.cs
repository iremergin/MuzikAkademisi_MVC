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
   public class SepetMap : EntityTypeConfiguration<Sepet>
    {
        public SepetMap()
        {
            this.ToTable("tblSepet");
            this.Property(p => p.SepetId).HasColumnType("int");
            this.Property(p => p.SepetId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.Kurs).WithMany(p => p.Sepets).HasForeignKey(x => x.KursId);
            this.HasRequired(p => p.MuzikAleti).WithMany(p => p.Sepets).HasForeignKey(x => x.MuzikAletiId);

        }
    }
}
