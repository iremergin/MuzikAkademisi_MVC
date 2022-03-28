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
   public class MuzikAletiSiparisleriMap : EntityTypeConfiguration<MuzikAletiSiparisleri>
    {
        public MuzikAletiSiparisleriMap()
        {
            this.ToTable("tblMuzikAletiSiparisleri");
            this.Property(p => p.MuzikAletiSiparisleriId).HasColumnType("int");
            this.Property(p => p.MuzikAletiSiparisleriId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.Siparis).WithMany(p => p.MuzikAletiSiparisleris).HasForeignKey(x => x.SiparisId);
            this.HasRequired(p => p.MuzikAleti).WithMany(p => p.MuzikAletiSiparisleris).HasForeignKey(x => x.MuzikAletiId);
        }
    }
}
