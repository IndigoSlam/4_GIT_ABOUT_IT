namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class questionadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Question", "question", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Question", "question");
        }
    }
}
