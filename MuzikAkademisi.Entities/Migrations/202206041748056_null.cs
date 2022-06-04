namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _null : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblSepet", "KursId", "dbo.tblKurs");
            DropForeignKey("dbo.tblSepet", "MuzikAletiId", "dbo.tblMuzikAleti");
            DropIndex("dbo.tblSepet", new[] { "KursId" });
            DropIndex("dbo.tblSepet", new[] { "MuzikAletiId" });
            AlterColumn("dbo.tblSepet", "KursId", c => c.Int());
            AlterColumn("dbo.tblSepet", "MuzikAletiId", c => c.Int());
            CreateIndex("dbo.tblSepet", "KursId");
            CreateIndex("dbo.tblSepet", "MuzikAletiId");
            AddForeignKey("dbo.tblSepet", "KursId", "dbo.tblKurs", "KursId");
            AddForeignKey("dbo.tblSepet", "MuzikAletiId", "dbo.tblMuzikAleti", "MuzikAletiId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblSepet", "MuzikAletiId", "dbo.tblMuzikAleti");
            DropForeignKey("dbo.tblSepet", "KursId", "dbo.tblKurs");
            DropIndex("dbo.tblSepet", new[] { "MuzikAletiId" });
            DropIndex("dbo.tblSepet", new[] { "KursId" });
            AlterColumn("dbo.tblSepet", "MuzikAletiId", c => c.Int(nullable: false));
            AlterColumn("dbo.tblSepet", "KursId", c => c.Int(nullable: false));
            CreateIndex("dbo.tblSepet", "MuzikAletiId");
            CreateIndex("dbo.tblSepet", "KursId");
            AddForeignKey("dbo.tblSepet", "MuzikAletiId", "dbo.tblMuzikAleti", "MuzikAletiId", cascadeDelete: true);
            AddForeignKey("dbo.tblSepet", "KursId", "dbo.tblKurs", "KursId", cascadeDelete: true);
        }
    }
}
