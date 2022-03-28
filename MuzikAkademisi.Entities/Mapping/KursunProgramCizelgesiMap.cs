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
    public class KursunProgramCizelgesiMap : EntityTypeConfiguration<KursunProgramCizelgesi>
    {
        public KursunProgramCizelgesiMap()
        {
            this.ToTable("tblKursunProgramCizelgesi");
            this.Property(p => p.KursunProgramCizelgesiId).HasColumnType("int");
            this.Property(p => p.KursunProgramCizelgesiId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.Kurs).WithMany(p => p.KursunProgramCizelgesis).HasForeignKey(x => x.KursId);
            this.HasRequired(p => p.ProgramCizelgesi).WithMany(p => p.KursunProgramCizelgesis).HasForeignKey(x => x.ProgramCizelgesiId);
        }
    }
}
