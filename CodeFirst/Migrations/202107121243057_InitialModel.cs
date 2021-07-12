namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Salary", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Salary");
        }
    }
}
