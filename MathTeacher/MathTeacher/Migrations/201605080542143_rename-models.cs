namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamemodels : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AnswerModel", newName: "Answer");
            RenameTable(name: "dbo.GameModel", newName: "Game");
            RenameTable(name: "dbo.QuestionModel", newName: "Question");
            RenameColumn(table: "dbo.Game", name: "AnswerModel_ID", newName: "Answer_ID");
            RenameColumn(table: "dbo.Question", name: "AnswerModel_ID", newName: "Answer_ID");
            RenameIndex(table: "dbo.Game", name: "IX_AnswerModel_ID", newName: "IX_Answer_ID");
            RenameIndex(table: "dbo.Question", name: "IX_AnswerModel_ID", newName: "IX_Answer_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Question", name: "IX_Answer_ID", newName: "IX_AnswerModel_ID");
            RenameIndex(table: "dbo.Game", name: "IX_Answer_ID", newName: "IX_AnswerModel_ID");
            RenameColumn(table: "dbo.Question", name: "Answer_ID", newName: "AnswerModel_ID");
            RenameColumn(table: "dbo.Game", name: "Answer_ID", newName: "AnswerModel_ID");
            RenameTable(name: "dbo.Question", newName: "QuestionModel");
            RenameTable(name: "dbo.Game", newName: "GameModel");
            RenameTable(name: "dbo.Answer", newName: "AnswerModel");
        }
    }
}
