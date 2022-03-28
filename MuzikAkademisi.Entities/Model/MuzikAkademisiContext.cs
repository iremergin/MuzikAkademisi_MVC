using MuzikAkademisi.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Model
{
    public class MuzikAkademisiContext:DbContext
    {
        public MuzikAkademisiContext():base("name=MuzikAkademisiEntities")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add((System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UyeninAdresleri>)new Mapping.UyeninAdresleriMap());
            modelBuilder.Configurations.Add(new AdresMap());
            modelBuilder.Configurations.Add(new DuyuruMap());
            modelBuilder.Configurations.Add(new KartMap());
            modelBuilder.Configurations.Add(new UyeninKurslariMap());
            modelBuilder.Configurations.Add(new KursMap());
            modelBuilder.Configurations.Add(new MailMap());
            modelBuilder.Configurations.Add(new UyeninMuzikAletleriMap());
            modelBuilder.Configurations.Add(new MuzikAletiMap());
            modelBuilder.Configurations.Add(new KartinOdemeleriMap());
            modelBuilder.Configurations.Add(new OdemeMap());
            modelBuilder.Configurations.Add(new UyeKursOdevleriMap());
            modelBuilder.Configurations.Add(new OdevMap());
            modelBuilder.Configurations.Add(new KursunProgramCizelgesiMap());
            modelBuilder.Configurations.Add(new ProgramCizelgesiMap());
            modelBuilder.Configurations.Add(new MuzikAletiSiparisleriMap());
            modelBuilder.Configurations.Add(new SiparisMap());
            modelBuilder.Configurations.Add(new UyeMap());
            modelBuilder.Configurations.Add(new MuzikAletiKursYorumlariMap());
            modelBuilder.Configurations.Add(new YorumMap());
        }


        public DbSet<Adres> Adres { get; set; }
        public DbSet<UyeninAdresleri> UyeninAdresleri { get; set; }
        public DbSet<Duyuru> Duyuru { get; set; }
        public DbSet<Kart> Kart { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
        public DbSet<UyeninKurslari> UyeninKurslari { get; set; }
        public DbSet<Mail> Mail { get; set; }
        public DbSet<MuzikAleti> MuzikAleti { get; set; }
        public DbSet<UyeninMuzikAletleri> UyeninMuzikAletleri { get; set; }
        public DbSet<Odeme> Odeme { get; set; }
        public DbSet<KartinOdemeleri> KartinOdemeleri { get; set; }
        public DbSet<Odev> Odev { get; set; }
        public DbSet<UyeKursOdevleri> UyeKursOdevleri{ get; set; }
        public DbSet<ProgramCizelgesi> ProgramCizelgesi{ get; set; }
        public DbSet<KursunProgramCizelgesi> KursunProgramCizelgesi{ get; set; }
        public DbSet<Siparis> Siparis{ get; set; }
        public DbSet<MuzikAletiSiparisleri> MuzikAletiSiparisleri{ get; set; }
        public DbSet<Uye> Uye{ get; set; }
        public DbSet<Yorum> Yorum{ get; set; }
        public DbSet<MuzikAletiKursYorumlari> MuzikAletiKursYorumlari{ get; set; }
    }
}
