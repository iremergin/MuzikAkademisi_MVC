namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class video : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        VideoId = c.Int(nullable: false, identity: true),
                        VideoAdi = c.String(),
                        VideoPath = c.String(),
                        VideoBolum = c.String(),
                        VideoKonu = c.String(),
                        KursId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VideoId)
                .ForeignKey("dbo.tblKurs", t => t.KursId, cascadeDelete: true)
                .Index(t => t.KursId);
            
            DropColumn("dbo.tblKurs", "EgitmenId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblKurs", "EgitmenId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Videos", "KursId", "dbo.tblKurs");
            DropIndex("dbo.Videos", new[] { "KursId" });
            DropTable("dbo.Videos");
        }
    }
}
