namespace CVeator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeinkeyinExpTab : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Experiences", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropIndex("dbo.Experiences", new[] { "PersonalInfo_ID" });
            AlterColumn("dbo.Experiences", "PersonalInfo_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Experiences", "PersonalInfo_ID");
            AddForeignKey("dbo.Experiences", "PersonalInfo_ID", "dbo.PersonalInfoes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Experiences", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropIndex("dbo.Experiences", new[] { "PersonalInfo_ID" });
            AlterColumn("dbo.Experiences", "PersonalInfo_ID", c => c.Int());
            CreateIndex("dbo.Experiences", "PersonalInfo_ID");
            AddForeignKey("dbo.Experiences", "PersonalInfo_ID", "dbo.PersonalInfoes", "ID");
        }
    }
}
