namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseIrem : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblProgramCizelgesi", "Gun", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblProgramCizelgesi", "Gun", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
