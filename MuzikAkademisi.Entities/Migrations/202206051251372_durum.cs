namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class durum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "VideoDurumu", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "VideoDurumu");
        }
    }
}
