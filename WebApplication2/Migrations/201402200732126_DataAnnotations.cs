namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cricketers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Cricketers", "Grade", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cricketers", "Grade", c => c.String());
            AlterColumn("dbo.Cricketers", "Name", c => c.String());
        }
    }
}
