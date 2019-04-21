namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedbirthdayforcustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDay", c => c.DateTime());
            Sql("update dbo.Customers set Birthday='11/06/1993' where Name='John Smith'");
            Sql("update dbo.Customers set Birthday=null where Name='Mary Williams'");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDay");
        }
    }
}
