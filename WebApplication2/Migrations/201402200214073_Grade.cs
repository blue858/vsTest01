namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Grade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cricketers", "Grade", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cricketers", "Grade");
        }
    }
}
