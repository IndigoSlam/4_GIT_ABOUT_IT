namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changefieldname3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.QuestionAnswer", "Question_ID", "dbo.Question");
            DropForeignKey("dbo.QuestionAnswer", "Answer_ID", "dbo.Answer");
            DropIndex("dbo.QuestionAnswer", new[] { "Question_ID" });
            DropIndex("dbo.QuestionAnswer", new[] { "Answer_ID" });
            AddColumn("dbo.Answer", "Question_ID", c => c.Int());
            CreateIndex("dbo.Answer", "Question_ID");
            AddForeignKey("dbo.Answer", "Question_ID", "dbo.Question", "ID");
            DropTable("dbo.QuestionAnswer");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.QuestionAnswer",
                c => new
                    {
                        Question_ID = c.Int(nullable: false),
                        Answer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Question_ID, t.Answer_ID });
            
            DropForeignKey("dbo.Answer", "Question_ID", "dbo.Question");
            DropIndex("dbo.Answer", new[] { "Question_ID" });
            DropColumn("dbo.Answer", "Question_ID");
            CreateIndex("dbo.QuestionAnswer", "Answer_ID");
            CreateIndex("dbo.QuestionAnswer", "Question_ID");
            AddForeignKey("dbo.QuestionAnswer", "Answer_ID", "dbo.Answer", "ID", cascadeDelete: true);
            AddForeignKey("dbo.QuestionAnswer", "Question_ID", "dbo.Question", "ID", cascadeDelete: true);
        }
    }
}
