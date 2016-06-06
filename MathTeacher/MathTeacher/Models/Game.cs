using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace MathTeacher.Models
{
    public class Game
    {
       public int ID {get; set; }
       public string UserName { get; set; }
       public bool GameStatus { get; set; }
        public int Score { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

    }
}
