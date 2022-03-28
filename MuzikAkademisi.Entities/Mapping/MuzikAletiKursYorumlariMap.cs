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
    public class MuzikAletiKursYorumlariMap : EntityTypeConfiguration<MuzikAletiKursYorumlari>
    {
        public MuzikAletiKursYorumlariMap()
        {
            this.ToTable("tblMuzikAletiKursYorumlari");
            this.Property(p => p.MuzikAletiKursYorumlariId).HasColumnType("int");
            this.Property(p => p.MuzikAletiKursYorumlariId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.Yorum).WithMany(p => p.MuzikAletiKursYorumlaris).HasForeignKey(x => x.YorumId);
            this.HasRequired(p => p.Kurs).WithMany(p => p.MuzikAletiKursYorumlaris).HasForeignKey(x => x.KursId);
            this.HasRequired(p => p.MuzikAleti).WithMany(p => p.MuzikAletiKursYorumlaris).HasForeignKey(x => x.MuzikAletiId);
        }
    }
}
