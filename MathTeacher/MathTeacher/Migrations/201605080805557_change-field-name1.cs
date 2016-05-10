namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changefieldname1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Game", "Answer_ID", "dbo.Answer");
            DropIndex("dbo.Game", new[] { "Answer_ID" });
            AddColumn("dbo.Answer", "Game_ID", c => c.Int());
            CreateIndex("dbo.Answer", "Game_ID");
            AddForeignKey("dbo.Answer", "Game_ID", "dbo.Game", "ID");
            DropColumn("dbo.Game", "Answer_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Game", "Answer_ID", c => c.Int());
            DropForeignKey("dbo.Answer", "Game_ID", "dbo.Game");
            DropIndex("dbo.Answer", new[] { "Game_ID" });
            DropColumn("dbo.Answer", "Game_ID");
            CreateIndex("dbo.Game", "Answer_ID");
            AddForeignKey("dbo.Game", "Answer_ID", "dbo.Answer", "ID");
        }
    }
}
