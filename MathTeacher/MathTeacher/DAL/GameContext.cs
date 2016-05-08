using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MathTeacher.Models;


namespace MathTeacher.DAL
{
    public class GameContext : DbContext
    {

        public GameContext(): base("GameContext")
        {
            Database.SetInitializer<GameContext>(null);
        }
   

        public DbSet<Test> Tests { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<GameModel> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
}
}
