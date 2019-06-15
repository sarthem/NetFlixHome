namespace BootFlixHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.MembershipType (Id, Price, DurationInMonths, DiscountRate) VALUES (1, 0, 1, 0)");
            Sql("INSERT INTO dbo.MembershipType (Id, Price, DurationInMonths, DiscountRate) VALUES (2, 9, 3, 10)");
            Sql("INSERT INTO dbo.MembershipType (Id, Price, DurationInMonths, DiscountRate) VALUES (3, 13, 6, 15)");
            Sql("INSERT INTO dbo.MembershipType (Id, Price, DurationInMonths, DiscountRate) VALUES (4, 16, 12, 20)");
        }
        
        public override void Down()
        {
            
            Sql("DELETE FROM dbo.MembershipType WHERE Id IN (1, 2, 3, 4) ");
        }
    }
}
