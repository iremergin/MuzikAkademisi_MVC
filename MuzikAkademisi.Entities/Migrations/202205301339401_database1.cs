namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YuklenenOdevlers",
                c => new
                    {
                        YuklenenOdevlerId = c.Int(nullable: false, identity: true),
                        OdevId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        DosyaYolu = c.String(),
                    })
                .PrimaryKey(t => t.YuklenenOdevlerId)
                .ForeignKey("dbo.tblOdev", t => t.OdevId, cascadeDelete: true)
                .ForeignKey("dbo.tblUye", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.OdevId)
                .Index(t => t.UyeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.YuklenenOdevlers", "UyeId", "dbo.tblUye");
            DropForeignKey("dbo.YuklenenOdevlers", "OdevId", "dbo.tblOdev");
            DropIndex("dbo.YuklenenOdevlers", new[] { "UyeId" });
            DropIndex("dbo.YuklenenOdevlers", new[] { "OdevId" });
            DropTable("dbo.YuklenenOdevlers");
        }
    }
}
