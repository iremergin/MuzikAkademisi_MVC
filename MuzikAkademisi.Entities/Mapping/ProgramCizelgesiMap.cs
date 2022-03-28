﻿using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuzikAkademisi.Entities.Mapping
{
    public class ProgramCizelgesiMap : EntityTypeConfiguration<ProgramCizelgesi>
    {
        public ProgramCizelgesiMap()
        {
            this.ToTable("tblProgramCizelgesi");
            this.Property(p => p.ProgramCizelgesiId).HasColumnType("int");
            this.Property(p => p.ProgramCizelgesiId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Gun).HasColumnType("date");
            this.Property(p => p.Ay).HasColumnType("date");
            this.Property(p => p.Yil).HasColumnType("date");
            this.Property(p => p.Saat).HasColumnType("datetime");
        }
    }
}
