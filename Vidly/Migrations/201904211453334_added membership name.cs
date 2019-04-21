namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmembershipname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("update dbo.MembershipTypes set Name ='Pay as You Go' where ID =1");
            Sql("update dbo.MembershipTypes set Name ='Monthly' where ID =2");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
