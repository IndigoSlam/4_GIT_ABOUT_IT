namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Answer", "Order", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Answer", "Order");
        }
    }
}
