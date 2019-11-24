namespace CVeator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignkeyinExpTabReverse : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Experiences", new[] { "PersonalInfo_ID1" });
            DropColumn("dbo.Experiences", "PersonalInfo_ID");
            RenameColumn(table: "dbo.Experiences", name: "PersonalInfo_ID1", newName: "PersonalInfo_ID");
            AlterColumn("dbo.Experiences", "PersonalInfo_ID", c => c.Int());
            CreateIndex("dbo.Experiences", "PersonalInfo_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Experiences", new[] { "PersonalInfo_ID" });
            AlterColumn("dbo.Experiences", "PersonalInfo_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Experiences", name: "PersonalInfo_ID", newName: "PersonalInfo_ID1");
            AddColumn("dbo.Experiences", "PersonalInfo_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Experiences", "PersonalInfo_ID1");
        }
    }
}
