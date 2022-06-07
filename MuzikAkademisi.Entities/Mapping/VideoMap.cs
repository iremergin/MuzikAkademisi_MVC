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
    public class VideoMap : EntityTypeConfiguration<Video>
    {
        public VideoMap()
        {
            this.ToTable("tblVideo");
            this.Property(p => p.VideoId).HasColumnType("int");
            this.Property(p => p.VideoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.VideoAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.VideoBolum).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.VideoKonu).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.VideoPath).HasColumnType("nvarchar").HasMaxLength(4000);

            this.HasRequired(p => p.Kurs).WithMany(p => p.Videos).HasForeignKey(p => p.KursId);
        }
    }
}
