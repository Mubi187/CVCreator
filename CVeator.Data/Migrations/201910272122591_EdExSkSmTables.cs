namespace CVeator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EdExSkSmTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Degree = c.String(),
                        FielOfStudy = c.String(),
                        GraduationDate = c.DateTime(nullable: false),
                        PersonalInfo_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfo_ID)
                .Index(t => t.PersonalInfo_ID);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Employer = c.String(),
                        JobTitle = c.String(),
                        City = c.String(),
                        State = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        PersonalInfo_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfo_ID)
                .Index(t => t.PersonalInfo_ID);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SkillName = c.String(),
                        level = c.String(),
                        PersonalInfo_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfo_ID)
                .Index(t => t.PersonalInfo_ID);
            
            CreateTable(
                "dbo.Summeries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProfessionalSummery = c.String(),
                        PersonalInfo_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfo_ID)
                .Index(t => t.PersonalInfo_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Summeries", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.Skills", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.Experiences", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.Educations", "PersonalInfo_ID", "dbo.PersonalInfoes");
            DropIndex("dbo.Summeries", new[] { "PersonalInfo_ID" });
            DropIndex("dbo.Skills", new[] { "PersonalInfo_ID" });
            DropIndex("dbo.Experiences", new[] { "PersonalInfo_ID" });
            DropIndex("dbo.Educations", new[] { "PersonalInfo_ID" });
            DropTable("dbo.Summeries");
            DropTable("dbo.Skills");
            DropTable("dbo.Experiences");
            DropTable("dbo.Educations");
        }
    }
}
