namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m34 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Answer", "IsAnswered", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Answer", "IsAnswered");
        }
    }
}
