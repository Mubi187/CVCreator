namespace CVeator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignkeyinExpTab : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Experiences", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropIndex("dbo.Experiences", new[] { "PersonalInfo_ID" });
            AddColumn("dbo.Experiences", "PersonalInfo_ID1", c => c.Int());
            AlterColumn("dbo.Experiences", "PersonalInfo_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Experiences", "PersonalInfo_ID1");
            AddForeignKey("dbo.Experiences", "PersonalInfo_ID1", "dbo.PersonalInfoes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Experiences", "PersonalInfo_ID1", "dbo.PersonalInfoes");
            DropIndex("dbo.Experiences", new[] { "PersonalInfo_ID1" });
            AlterColumn("dbo.Experiences", "PersonalInfo_ID", c => c.Int());
            DropColumn("dbo.Experiences", "PersonalInfo_ID1");
            CreateIndex("dbo.Experiences", "PersonalInfo_ID");
            AddForeignKey("dbo.Experiences", "PersonalInfo_ID", "dbo.PersonalInfoes", "ID");
        }
    }
}
