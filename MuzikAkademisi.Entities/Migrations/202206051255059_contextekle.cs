namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contextekle : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Videos", newName: "tblVideo");
            AlterColumn("dbo.tblVideo", "VideoAdi", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.tblVideo", "VideoPath", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.tblVideo", "VideoBolum", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.tblVideo", "VideoKonu", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblVideo", "VideoKonu", c => c.String());
            AlterColumn("dbo.tblVideo", "VideoBolum", c => c.String());
            AlterColumn("dbo.tblVideo", "VideoPath", c => c.String());
            AlterColumn("dbo.tblVideo", "VideoAdi", c => c.String());
            RenameTable(name: "dbo.tblVideo", newName: "Videos");
        }
    }
}
