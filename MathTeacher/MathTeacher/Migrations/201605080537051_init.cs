namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnswerModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTIme = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GameModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AnswerModel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AnswerModel", t => t.AnswerModel_ID)
                .Index(t => t.AnswerModel_ID);
            
            CreateTable(
                "dbo.QuestionModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Grade = c.Int(nullable: false),
                        AnswerModel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AnswerModel", t => t.AnswerModel_ID)
                .Index(t => t.AnswerModel_ID);
            
            CreateTable(
                "dbo.Test",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuestionModel", "AnswerModel_ID", "dbo.AnswerModel");
            DropForeignKey("dbo.GameModel", "AnswerModel_ID", "dbo.AnswerModel");
            DropIndex("dbo.QuestionModel", new[] { "AnswerModel_ID" });
            DropIndex("dbo.GameModel", new[] { "AnswerModel_ID" });
            DropTable("dbo.Test");
            DropTable("dbo.QuestionModel");
            DropTable("dbo.GameModel");
            DropTable("dbo.AnswerModel");
        }
    }
}
