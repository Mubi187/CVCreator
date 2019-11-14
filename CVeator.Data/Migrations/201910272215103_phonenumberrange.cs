namespace CVeator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phonenumberrange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PersonalInfoes", "PhoneNumber", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PersonalInfoes", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
