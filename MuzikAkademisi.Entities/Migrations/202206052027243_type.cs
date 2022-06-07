namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class type : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblVideo", "VideoPath", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblVideo", "VideoPath", c => c.String(maxLength: 500, unicode: false));
        }
    }
}
