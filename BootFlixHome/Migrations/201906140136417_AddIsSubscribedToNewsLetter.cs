namespace BootFlixHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToNewsLetter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Viewers", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Viewers", "MembershipType_Id", c => c.Byte());
            CreateIndex("dbo.Viewers", "MembershipType_Id");
            AddForeignKey("dbo.Viewers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Viewers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Viewers", new[] { "MembershipType_Id" });
            DropColumn("dbo.Viewers", "MembershipType_Id");
            DropColumn("dbo.Viewers", "IsSubscribedToNewsLetter");
        }
    }
}
