using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class QuestionInstance
    {
        //Primary key: QuestionInstance
        public int QuizInstanceId { get; set; }
        public int QuestionId { get; set; }

        public string Header { get; set; }
        public DateTime TimeOut { get; set; }
        public Contestant CorrectAnswer { get; set; }

        public List<Contestant> WrongAnswers { get; set; }
        public QuizInstance quizInstance { get; set; }
    }
}
