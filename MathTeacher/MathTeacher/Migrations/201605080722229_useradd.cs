namespace MathTeacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useradd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Game", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Game", "UserName");
        }
    }
}
