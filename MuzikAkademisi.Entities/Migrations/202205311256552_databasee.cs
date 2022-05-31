namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databasee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblOdev", "OdevVerilmeTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tblOdev", "OdevTeslimTarihi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblOdev", "OdevTeslimTarihi", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.tblOdev", "OdevVerilmeTarihi", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
