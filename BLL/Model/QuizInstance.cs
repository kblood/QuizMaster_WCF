using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class QuizInstance
    {
        public int Id { get; set; }
        public bool Running { get; set; }
        public bool Open { get; set; }
        public DateTime StartDate { get; set; }
        public User Owner { get; set; }
        public Quiz Quiz { get; set; }
        public int QuizId { get; set; }
        // List of questionInstances and contestants for statistics later
        public List<Contestant> Contestants { get; set; }
        public List<QuestionInstance> QuestionInstances { get; set; }

        public QuizInstance()
        {
            Contestants = new List<Contestant>();
            QuestionInstances = new List<QuestionInstance>();
        }
    }
}
