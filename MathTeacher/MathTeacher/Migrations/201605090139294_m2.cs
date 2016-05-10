namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Question", "CorrectAnswer", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Question", "CorrectAnswer");
        }
    }
}
