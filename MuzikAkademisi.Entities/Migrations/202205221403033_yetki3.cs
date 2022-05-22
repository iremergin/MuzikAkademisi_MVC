namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yetki3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblProgramCizelgesi", "UyeId", c => c.Int(nullable: true));
            CreateIndex("dbo.tblProgramCizelgesi", "UyeId");
            AddForeignKey("dbo.tblProgramCizelgesi", "UyeId", "dbo.tblUye", "UyeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblProgramCizelgesi", "UyeId", "dbo.tblUye");
            DropIndex("dbo.tblProgramCizelgesi", new[] { "UyeId" });
            DropColumn("dbo.tblProgramCizelgesi", "UyeId");
        }
    }
}
