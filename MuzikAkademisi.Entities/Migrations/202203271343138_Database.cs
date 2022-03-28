namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAdres",
                c => new
                    {
                        AdresId = c.Int(nullable: false, identity: true),
                        AdresAdi = c.String(maxLength: 200, unicode: false),
                        AdresAitligi = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.AdresId);
            
            CreateTable(
                "dbo.tblKartinOdemeleri",
                c => new
                    {
                        KartinOdemeleriId = c.Int(nullable: false, identity: true),
                        OdemeId = c.Int(nullable: false),
                        KartId = c.Int(nullable: false),
                        AdresId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KartinOdemeleriId)
                .ForeignKey("dbo.tblAdres", t => t.AdresId, cascadeDelete: true)
                .ForeignKey("dbo.tblKart", t => t.KartId, cascadeDelete: true)
                .ForeignKey("dbo.tblOdeme", t => t.OdemeId, cascadeDelete: true)
                .Index(t => t.OdemeId)
                .Index(t => t.KartId)
                .Index(t => t.AdresId);
            
            CreateTable(
                "dbo.tblKart",
                c => new
                    {
                        KartId = c.Int(nullable: false, identity: true),
                        KartAdi = c.String(maxLength: 100, unicode: false),
                        KartNumarasi = c.String(maxLength: 16, fixedLength: true, unicode: false),
                        KartTarihi = c.DateTime(nullable: false, storeType: "date"),
                        Cvc = c.String(maxLength: 3, fixedLength: true, unicode: false),
                        UyeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KartId)
                .ForeignKey("dbo.tblUye", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.tblUye",
                c => new
                    {
                        UyeId = c.Int(nullable: false, identity: true),
                        UyeAdi = c.String(maxLength: 100, unicode: false),
                        UyeSoyadi = c.String(maxLength: 100, unicode: false),
                        UyeKullaniciAdi = c.String(maxLength: 50, unicode: false),
                        UyeCinsiyet = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        UyeDogumTarihi = c.DateTime(nullable: false, storeType: "date"),
                        UyeDogumYeri = c.String(maxLength: 50, unicode: false),
                        UyeMail = c.String(maxLength: 100, unicode: false),
                        UyeTelefon = c.String(maxLength: 15, fixedLength: true, unicode: false),
                        UyeSifre = c.String(maxLength: 15, unicode: false),
                        UyeFotograf = c.String(maxLength: 200, unicode: false),
                        UyeKodu = c.String(maxLength: 6, unicode: false),
                        UyeTuru = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        UyeDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UyeId);
            
            CreateTable(
                "dbo.tblUyeKursOdevleri",
                c => new
                    {
                        UyeKursOdevleriId = c.Int(nullable: false, identity: true),
                        OdevId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        KursId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UyeKursOdevleriId)
                .ForeignKey("dbo.tblKurs", t => t.KursId, cascadeDelete: true)
                .ForeignKey("dbo.tblOdev", t => t.OdevId, cascadeDelete: true)
                .ForeignKey("dbo.tblUye", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.OdevId)
                .Index(t => t.UyeId)
                .Index(t => t.KursId);
            
            CreateTable(
                "dbo.tblKurs",
                c => new
                    {
                        KursId = c.Int(nullable: false, identity: true),
                        KursAdi = c.String(maxLength: 100, unicode: false),
                        KursAciklama = c.String(maxLength: 100, unicode: false),
                        KursFiyat = c.Decimal(nullable: false, precision: 11, scale: 3),
                        KursFotograf = c.String(maxLength: 200, unicode: false),
                        KursBaslamaTarihi = c.DateTime(nullable: false, storeType: "date"),
                        KursBitisTarihi = c.DateTime(nullable: false, storeType: "date"),
                        OgrenciAktifKurslar = c.String(maxLength: 50, unicode: false),
                        OgrenciTamamlananKurslar = c.String(maxLength: 50, unicode: false),
                        EgitmenKursAlanlari = c.String(maxLength: 50, unicode: false),
                        EgitmenDahaOnceVerilmisKurslar = c.String(maxLength: 50, unicode: false),
                        OgrenciIlerlemeSeviyesi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KursKatilimciSayisi = c.Int(nullable: false),
                        KursDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KursId);
            
            CreateTable(
                "dbo.tblDuyuru",
                c => new
                    {
                        DuyuruId = c.Int(nullable: false, identity: true),
                        DuyuruAdi = c.String(maxLength: 50, unicode: false),
                        DuyuruAciklama = c.String(maxLength: 8000, unicode: false),
                        DuyuruTarihi = c.DateTime(nullable: false, storeType: "date"),
                        KursId = c.Int(nullable: false),
                        MuzikAletiId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DuyuruId)
                .ForeignKey("dbo.tblKurs", t => t.KursId, cascadeDelete: true)
                .ForeignKey("dbo.tblMuzikAleti", t => t.MuzikAletiId, cascadeDelete: true)
                .Index(t => t.KursId)
                .Index(t => t.MuzikAletiId);
            
            CreateTable(
                "dbo.tblMuzikAleti",
                c => new
                    {
                        MuzikAletiId = c.Int(nullable: false, identity: true),
                        MuzikAletiAdi = c.String(maxLength: 50, unicode: false),
                        MuzikAletiAciklama = c.String(maxLength: 100, unicode: false),
                        MuzikAletiFotograf = c.String(maxLength: 200, unicode: false),
                        MuzikAletiFiyat = c.Decimal(nullable: false, precision: 11, scale: 3),
                        MuzikAletiAdedi = c.Int(nullable: false),
                        MuzikAletiTuru = c.String(maxLength: 50, unicode: false),
                        MuzikAletiDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MuzikAletiId);
            
            CreateTable(
                "dbo.tblMuzikAletiKursYorumlari",
                c => new
                    {
                        MuzikAletiKursYorumlariId = c.Int(nullable: false, identity: true),
                        YorumId = c.Int(nullable: false),
                        KursId = c.Int(nullable: false),
                        MuzikAletiId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MuzikAletiKursYorumlariId)
                .ForeignKey("dbo.tblKurs", t => t.KursId, cascadeDelete: true)
                .ForeignKey("dbo.tblMuzikAleti", t => t.MuzikAletiId, cascadeDelete: true)
                .ForeignKey("dbo.tblYorum", t => t.YorumId, cascadeDelete: true)
                .Index(t => t.YorumId)
                .Index(t => t.KursId)
                .Index(t => t.MuzikAletiId);
            
            CreateTable(
                "dbo.tblYorum",
                c => new
                    {
                        YorumId = c.Int(nullable: false, identity: true),
                        YorumIcerigi = c.String(maxLength: 300, unicode: false),
                        Puanlama = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.YorumId);
            
            CreateTable(
                "dbo.tblMuzikAletiSiparisleri",
                c => new
                    {
                        MuzikAletiSiparisleriId = c.Int(nullable: false, identity: true),
                        MuzikAletiId = c.Int(nullable: false),
                        SiparisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MuzikAletiSiparisleriId)
                .ForeignKey("dbo.tblMuzikAleti", t => t.MuzikAletiId, cascadeDelete: true)
                .ForeignKey("dbo.tblSiparis", t => t.SiparisId, cascadeDelete: true)
                .Index(t => t.MuzikAletiId)
                .Index(t => t.SiparisId);
            
            CreateTable(
                "dbo.tblSiparis",
                c => new
                    {
                        SiparisId = c.Int(nullable: false, identity: true),
                        SiparisAdi = c.String(maxLength: 100, unicode: false),
                        SiparisTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SiparisId);
            
            CreateTable(
                "dbo.tblUyeninMuzikAletleri",
                c => new
                    {
                        UyeninMuzikAletleriId = c.Int(nullable: false, identity: true),
                        MuzikAletiId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        Duyuru_DuyuruId = c.Int(),
                    })
                .PrimaryKey(t => t.UyeninMuzikAletleriId)
                .ForeignKey("dbo.tblDuyuru", t => t.Duyuru_DuyuruId)
                .ForeignKey("dbo.tblMuzikAleti", t => t.MuzikAletiId, cascadeDelete: true)
                .ForeignKey("dbo.tblUye", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.MuzikAletiId)
                .Index(t => t.UyeId)
                .Index(t => t.Duyuru_DuyuruId);
            
            CreateTable(
                "dbo.tblKursunProgramCizelgesi",
                c => new
                    {
                        KursunProgramCizelgesiId = c.Int(nullable: false, identity: true),
                        ProgramCizelgesiId = c.Int(nullable: false),
                        KursId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KursunProgramCizelgesiId)
                .ForeignKey("dbo.tblKurs", t => t.KursId, cascadeDelete: true)
                .ForeignKey("dbo.tblProgramCizelgesi", t => t.ProgramCizelgesiId, cascadeDelete: true)
                .Index(t => t.ProgramCizelgesiId)
                .Index(t => t.KursId);
            
            CreateTable(
                "dbo.tblProgramCizelgesi",
                c => new
                    {
                        ProgramCizelgesiId = c.Int(nullable: false, identity: true),
                        Gun = c.DateTime(nullable: false, storeType: "date"),
                        Ay = c.DateTime(nullable: false, storeType: "date"),
                        Yil = c.DateTime(nullable: false, storeType: "date"),
                        Saat = c.DateTime(nullable: false),
                        KursId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProgramCizelgesiId);
            
            CreateTable(
                "dbo.tblUyeninKurslari",
                c => new
                    {
                        UyeninKurslariId = c.Int(nullable: false, identity: true),
                        KursId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UyeninKurslariId)
                .ForeignKey("dbo.tblKurs", t => t.KursId, cascadeDelete: true)
                .ForeignKey("dbo.tblUye", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.KursId)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.tblOdev",
                c => new
                    {
                        OdevId = c.Int(nullable: false, identity: true),
                        OdevAdi = c.String(maxLength: 100, unicode: false),
                        OdevAciklama = c.String(maxLength: 100, unicode: false),
                        OdevFotograf = c.String(maxLength: 200, unicode: false),
                        OdevVerilmeTarihi = c.DateTime(nullable: false, storeType: "date"),
                        OdevTeslimTarihi = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.OdevId);
            
            CreateTable(
                "dbo.tblUyeninAdresleri",
                c => new
                    {
                        UyeninAdresleriId = c.Int(nullable: false, identity: true),
                        AdresId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UyeninAdresleriId)
                .ForeignKey("dbo.tblAdres", t => t.AdresId, cascadeDelete: true)
                .ForeignKey("dbo.tblUye", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.AdresId)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.tblOdeme",
                c => new
                    {
                        OdemeId = c.Int(nullable: false, identity: true),
                        OdemeSecenegi = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        KargoSecenegi = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        OdemeTarihi = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.OdemeId);
            
            CreateTable(
                "dbo.tblMail",
                c => new
                    {
                        MailId = c.Int(nullable: false, identity: true),
                        AliciMailAdresi = c.String(maxLength: 100, unicode: false),
                        GondericiMailAdresi = c.String(maxLength: 100, unicode: false),
                        MailBaslik = c.String(maxLength: 200, unicode: false),
                        MailAciklama = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.MailId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblKartinOdemeleri", "OdemeId", "dbo.tblOdeme");
            DropForeignKey("dbo.tblKartinOdemeleri", "KartId", "dbo.tblKart");
            DropForeignKey("dbo.tblKart", "UyeId", "dbo.tblUye");
            DropForeignKey("dbo.tblUyeninAdresleri", "UyeId", "dbo.tblUye");
            DropForeignKey("dbo.tblUyeninAdresleri", "AdresId", "dbo.tblAdres");
            DropForeignKey("dbo.tblUyeKursOdevleri", "UyeId", "dbo.tblUye");
            DropForeignKey("dbo.tblUyeKursOdevleri", "OdevId", "dbo.tblOdev");
            DropForeignKey("dbo.tblUyeKursOdevleri", "KursId", "dbo.tblKurs");
            DropForeignKey("dbo.tblUyeninKurslari", "UyeId", "dbo.tblUye");
            DropForeignKey("dbo.tblUyeninKurslari", "KursId", "dbo.tblKurs");
            DropForeignKey("dbo.tblKursunProgramCizelgesi", "ProgramCizelgesiId", "dbo.tblProgramCizelgesi");
            DropForeignKey("dbo.tblKursunProgramCizelgesi", "KursId", "dbo.tblKurs");
            DropForeignKey("dbo.tblDuyuru", "MuzikAletiId", "dbo.tblMuzikAleti");
            DropForeignKey("dbo.tblUyeninMuzikAletleri", "UyeId", "dbo.tblUye");
            DropForeignKey("dbo.tblUyeninMuzikAletleri", "MuzikAletiId", "dbo.tblMuzikAleti");
            DropForeignKey("dbo.tblUyeninMuzikAletleri", "Duyuru_DuyuruId", "dbo.tblDuyuru");
            DropForeignKey("dbo.tblMuzikAletiSiparisleri", "SiparisId", "dbo.tblSiparis");
            DropForeignKey("dbo.tblMuzikAletiSiparisleri", "MuzikAletiId", "dbo.tblMuzikAleti");
            DropForeignKey("dbo.tblMuzikAletiKursYorumlari", "YorumId", "dbo.tblYorum");
            DropForeignKey("dbo.tblMuzikAletiKursYorumlari", "MuzikAletiId", "dbo.tblMuzikAleti");
            DropForeignKey("dbo.tblMuzikAletiKursYorumlari", "KursId", "dbo.tblKurs");
            DropForeignKey("dbo.tblDuyuru", "KursId", "dbo.tblKurs");
            DropForeignKey("dbo.tblKartinOdemeleri", "AdresId", "dbo.tblAdres");
            DropIndex("dbo.tblUyeninAdresleri", new[] { "UyeId" });
            DropIndex("dbo.tblUyeninAdresleri", new[] { "AdresId" });
            DropIndex("dbo.tblUyeninKurslari", new[] { "UyeId" });
            DropIndex("dbo.tblUyeninKurslari", new[] { "KursId" });
            DropIndex("dbo.tblKursunProgramCizelgesi", new[] { "KursId" });
            DropIndex("dbo.tblKursunProgramCizelgesi", new[] { "ProgramCizelgesiId" });
            DropIndex("dbo.tblUyeninMuzikAletleri", new[] { "Duyuru_DuyuruId" });
            DropIndex("dbo.tblUyeninMuzikAletleri", new[] { "UyeId" });
            DropIndex("dbo.tblUyeninMuzikAletleri", new[] { "MuzikAletiId" });
            DropIndex("dbo.tblMuzikAletiSiparisleri", new[] { "SiparisId" });
            DropIndex("dbo.tblMuzikAletiSiparisleri", new[] { "MuzikAletiId" });
            DropIndex("dbo.tblMuzikAletiKursYorumlari", new[] { "MuzikAletiId" });
            DropIndex("dbo.tblMuzikAletiKursYorumlari", new[] { "KursId" });
            DropIndex("dbo.tblMuzikAletiKursYorumlari", new[] { "YorumId" });
            DropIndex("dbo.tblDuyuru", new[] { "MuzikAletiId" });
            DropIndex("dbo.tblDuyuru", new[] { "KursId" });
            DropIndex("dbo.tblUyeKursOdevleri", new[] { "KursId" });
            DropIndex("dbo.tblUyeKursOdevleri", new[] { "UyeId" });
            DropIndex("dbo.tblUyeKursOdevleri", new[] { "OdevId" });
            DropIndex("dbo.tblKart", new[] { "UyeId" });
            DropIndex("dbo.tblKartinOdemeleri", new[] { "AdresId" });
            DropIndex("dbo.tblKartinOdemeleri", new[] { "KartId" });
            DropIndex("dbo.tblKartinOdemeleri", new[] { "OdemeId" });
            DropTable("dbo.tblMail");
            DropTable("dbo.tblOdeme");
            DropTable("dbo.tblUyeninAdresleri");
            DropTable("dbo.tblOdev");
            DropTable("dbo.tblUyeninKurslari");
            DropTable("dbo.tblProgramCizelgesi");
            DropTable("dbo.tblKursunProgramCizelgesi");
            DropTable("dbo.tblUyeninMuzikAletleri");
            DropTable("dbo.tblSiparis");
            DropTable("dbo.tblMuzikAletiSiparisleri");
            DropTable("dbo.tblYorum");
            DropTable("dbo.tblMuzikAletiKursYorumlari");
            DropTable("dbo.tblMuzikAleti");
            DropTable("dbo.tblDuyuru");
            DropTable("dbo.tblKurs");
            DropTable("dbo.tblUyeKursOdevleri");
            DropTable("dbo.tblUye");
            DropTable("dbo.tblKart");
            DropTable("dbo.tblKartinOdemeleri");
            DropTable("dbo.tblAdres");
        }
    }
}
