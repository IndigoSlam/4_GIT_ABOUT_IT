namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class i1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Game", "GameStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Game", "GameStatus");
        }
    }
}
