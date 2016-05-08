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
        public DateTime EndTIme {get; set;}

        public virtual ICollection<Game> Game { get; set; }
        public virtual ICollection<Question> Question { get; set; }

    }
}
