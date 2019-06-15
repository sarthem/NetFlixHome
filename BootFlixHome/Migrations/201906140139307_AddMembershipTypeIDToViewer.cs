namespace BootFlixHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeIDToViewer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Viewers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Viewers", new[] { "MembershipType_Id" });
            RenameColumn(table: "dbo.Viewers", name: "MembershipType_Id", newName: "MembershipTypeID");
            AlterColumn("dbo.Viewers", "MembershipTypeID", c => c.Byte(nullable: false));
            CreateIndex("dbo.Viewers", "MembershipTypeID");
            AddForeignKey("dbo.Viewers", "MembershipTypeID", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Viewers", "MembershipTypeID", "dbo.MembershipTypes");
            DropIndex("dbo.Viewers", new[] { "MembershipTypeID" });
            AlterColumn("dbo.Viewers", "MembershipTypeID", c => c.Byte());
            RenameColumn(table: "dbo.Viewers", name: "MembershipTypeID", newName: "MembershipType_Id");
            CreateIndex("dbo.Viewers", "MembershipType_Id");
            AddForeignKey("dbo.Viewers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
