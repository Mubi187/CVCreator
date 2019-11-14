namespace CVeator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonalInfos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonalInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirsrName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Country = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PersonalInfoes");
        }
    }
}
