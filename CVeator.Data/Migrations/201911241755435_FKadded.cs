namespace CVeator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKadded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Educations", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.Skills", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.Summeries", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropIndex("dbo.Educations", new[] { "PersonalInfo_ID" });
            DropIndex("dbo.Skills", new[] { "PersonalInfo_ID" });
            DropIndex("dbo.Summeries", new[] { "PersonalInfo_ID" });
            AlterColumn("dbo.Educations", "PersonalInfo_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Skills", "PersonalInfo_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Summeries", "PersonalInfo_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Educations", "PersonalInfo_ID");
            CreateIndex("dbo.Skills", "PersonalInfo_ID");
            CreateIndex("dbo.Summeries", "PersonalInfo_ID");
            AddForeignKey("dbo.Educations", "PersonalInfo_ID", "dbo.PersonalInfoes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Skills", "PersonalInfo_ID", "dbo.PersonalInfoes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Summeries", "PersonalInfo_ID", "dbo.PersonalInfoes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Summeries", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.Skills", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.Educations", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropIndex("dbo.Summeries", new[] { "PersonalInfo_ID" });
            DropIndex("dbo.Skills", new[] { "PersonalInfo_ID" });
            DropIndex("dbo.Educations", new[] { "PersonalInfo_ID" });
            AlterColumn("dbo.Summeries", "PersonalInfo_ID", c => c.Int());
            AlterColumn("dbo.Skills", "PersonalInfo_ID", c => c.Int());
            AlterColumn("dbo.Educations", "PersonalInfo_ID", c => c.Int());
            CreateIndex("dbo.Summeries", "PersonalInfo_ID");
            CreateIndex("dbo.Skills", "PersonalInfo_ID");
            CreateIndex("dbo.Educations", "PersonalInfo_ID");
            AddForeignKey("dbo.Summeries", "PersonalInfo_ID", "dbo.PersonalInfoes", "ID");
            AddForeignKey("dbo.Skills", "PersonalInfo_ID", "dbo.PersonalInfoes", "ID");
            AddForeignKey("dbo.Educations", "PersonalInfo_ID", "dbo.PersonalInfoes", "ID");
        }
    }
}
