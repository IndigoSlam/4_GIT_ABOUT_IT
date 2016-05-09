using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MathTeacher.Models
{
    public class Answer
    {
        public int ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTIme { get; set; }
        public int Result { get; set; }
        public int Order { get; set; }

        public virtual Game Game { get; set; }
        public virtual Question Question { get; set; }

        public Answer Previous()
        {
            if (Order == 0)
                return null;
            else
                return Game.Answers.FirstOrDefault(a => a.Order == Order - 1);
        }

        public Answer Next()
        {
            if (Order == Game.Answers.Max(a => a.Order))
                return null;
            else
                return Game.Answers.FirstOrDefault(a => a.Order == Order + 1);
        }
    }
}
