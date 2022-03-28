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
    public class MailMap : EntityTypeConfiguration<Mail>
    {
        public MailMap()
        {
            this.ToTable("tblMail");
            this.Property(p => p.MailId).HasColumnType("int");
            this.Property(p => p.MailId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AliciMailAdresi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.GondericiMailAdresi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.MailBaslik).HasColumnType("varchar").HasMaxLength(200);
            this.Property(p => p.MailAciklama).HasColumnType("varchar").IsMaxLength();
        }
    }
}
