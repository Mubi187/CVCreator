namespace CVeator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PictureAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonalInfoes", "PictureURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonalInfoes", "PictureURL");
        }
    }
}
