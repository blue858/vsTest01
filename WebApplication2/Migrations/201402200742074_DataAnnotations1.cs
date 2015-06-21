namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cricketers", "Grade", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cricketers", "Grade", c => c.String(nullable: false));
        }
    }
}
