namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iremssss : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblProgramCizelgesi", "Saat", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblProgramCizelgesi", "Saat", c => c.DateTime(nullable: false));
        }
    }
}
