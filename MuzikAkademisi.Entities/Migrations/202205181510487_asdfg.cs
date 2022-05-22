namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdfg : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblKursunProgramCizelgesi", "KursId", "dbo.tblKurs");
            DropForeignKey("dbo.tblKursunProgramCizelgesi", "ProgramCizelgesiId", "dbo.tblProgramCizelgesi");
            DropIndex("dbo.tblKursunProgramCizelgesi", new[] { "ProgramCizelgesiId" });
            DropIndex("dbo.tblKursunProgramCizelgesi", new[] { "KursId" });
            CreateIndex("dbo.tblProgramCizelgesi", "KursId");
            AddForeignKey("dbo.tblProgramCizelgesi", "KursId", "dbo.tblKurs", "KursId", cascadeDelete: true);
            DropTable("dbo.tblKursunProgramCizelgesi");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tblKursunProgramCizelgesi",
                c => new
                    {
                        KursunProgramCizelgesiId = c.Int(nullable: false, identity: true),
                        ProgramCizelgesiId = c.Int(nullable: false),
                        KursId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KursunProgramCizelgesiId);
            
            DropForeignKey("dbo.tblProgramCizelgesi", "KursId", "dbo.tblKurs");
            DropIndex("dbo.tblProgramCizelgesi", new[] { "KursId" });
            CreateIndex("dbo.tblKursunProgramCizelgesi", "KursId");
            CreateIndex("dbo.tblKursunProgramCizelgesi", "ProgramCizelgesiId");
            AddForeignKey("dbo.tblKursunProgramCizelgesi", "ProgramCizelgesiId", "dbo.tblProgramCizelgesi", "ProgramCizelgesiId", cascadeDelete: true);
            AddForeignKey("dbo.tblKursunProgramCizelgesi", "KursId", "dbo.tblKurs", "KursId", cascadeDelete: true);
        }
    }
}
