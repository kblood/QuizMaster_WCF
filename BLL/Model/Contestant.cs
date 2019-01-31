using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class Contestant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int QuizInstanceId { get; set; }

        public Contestant(string name, int quizInstanceId)
        {
            this.Id =  Guid.NewGuid();
            this.Name = name;
            this.QuizInstanceId = quizInstanceId;
        }
        public Contestant()
        {

        }

    }
}
