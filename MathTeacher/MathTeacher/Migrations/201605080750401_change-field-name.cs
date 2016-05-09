namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changefieldname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Question", "Text", c => c.String());
            DropColumn("dbo.Question", "question");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Question", "question", c => c.String());
            DropColumn("dbo.Question", "Text");
        }
    }
}
