namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changefieldname2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Question", "Answer_ID", "dbo.Answer");
            DropIndex("dbo.Question", new[] { "Answer_ID" });
            CreateTable(
                "dbo.QuestionAnswer",
                c => new
                    {
                        Question_ID = c.Int(nullable: false),
                        Answer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Question_ID, t.Answer_ID })
                .ForeignKey("dbo.Question", t => t.Question_ID, cascadeDelete: true)
                .ForeignKey("dbo.Answer", t => t.Answer_ID, cascadeDelete: true)
                .Index(t => t.Question_ID)
                .Index(t => t.Answer_ID);
            
            DropColumn("dbo.Question", "Answer_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Question", "Answer_ID", c => c.Int());
            DropForeignKey("dbo.QuestionAnswer", "Answer_ID", "dbo.Answer");
            DropForeignKey("dbo.QuestionAnswer", "Question_ID", "dbo.Question");
            DropIndex("dbo.QuestionAnswer", new[] { "Answer_ID" });
            DropIndex("dbo.QuestionAnswer", new[] { "Question_ID" });
            DropTable("dbo.QuestionAnswer");
            CreateIndex("dbo.Question", "Answer_ID");
            AddForeignKey("dbo.Question", "Answer_ID", "dbo.Answer", "ID");
        }
    }
}
