using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MathTeacher.Models

{
    public class Question
    {
        public int ID { get; set;  }
        public int Grade { get; set; }
        public string Text { get; set; }
        public int CorrectAnswer { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

    }
}
