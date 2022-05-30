namespace MuzikAkademisi.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lutfenol : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblYuklenenOdevler", "DosyaYolu", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblYuklenenOdevler", "DosyaYolu", c => c.String());
        }
    }
}
