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
   public class UyeMap : EntityTypeConfiguration<Uye>
    {
        public UyeMap()
        {
            this.ToTable("tblUye");
            this.Property(p => p.UyeId).HasColumnType("int");
            this.Property(p => p.UyeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.UyeAdi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.UyeSoyadi).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.UyeKullaniciAdi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.UyeCinsiyet).HasColumnType("char").HasMaxLength(1);
            this.Property(p => p.UyeDogumTarihi).HasColumnType("Date");
            this.Property(p => p.UyeDogumYeri).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.UyeMail).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.UyeTelefon).HasColumnType("char").HasMaxLength(15);
            this.Property(p => p.UyeSifre).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.UyeFotograf).HasColumnType("varchar").HasMaxLength(200);
            this.Property(p => p.UyeKodu).HasColumnType("varchar").HasMaxLength(6);
            this.Property(p => p.UyeTuru).HasColumnType("char").HasMaxLength(1);

            

            
        }
    }
}
