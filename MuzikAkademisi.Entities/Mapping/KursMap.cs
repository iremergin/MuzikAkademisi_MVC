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
    public class KursMap : EntityTypeConfiguration<Kurs>
    {
        public KursMap()
        {
            this.ToTable("tblKurs");
            this.Property(p => p.KursId).HasColumnType("int");
            this.Property(p => p.KursId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KursAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.KursAciklama).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.KursFiyat).HasPrecision(11, 3);
            this.Property(p => p.KursFotograf).HasColumnType("varchar").HasMaxLength(200);
            this.Property(p => p.KursBaslamaTarihi).HasColumnType("date");
            this.Property(p => p.KursBitisTarihi).HasColumnType("date");
            this.Property(p => p.OgrenciAktifKurslar).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.OgrenciTamamlananKurslar).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.EgitmenKursAlanlari).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.EgitmenDahaOnceVerilmisKurslar).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.OgrenciIlerlemeSeviyesi).HasColumnType("decimal");
            this.Property(p => p.KursKatilimciSayisi).HasColumnType("int");

            //this.HasRequired(p => p.EgitmenId).WithMany(p => p.Egitmens).HasForeignKey();
          

        }
    }
}
