namespace CVeator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Namemistake : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonalInfoes", "FirstName", c => c.String());
            DropColumn("dbo.PersonalInfoes", "FirsrName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonalInfoes", "FirsrName", c => c.String());
            DropColumn("dbo.PersonalInfoes", "FirstName");
        }
    }
}
