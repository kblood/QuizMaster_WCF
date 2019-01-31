using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModel
{
    /// <summary>
    /// Public class made partial for later use in MVC 
    /// </summary>
   
    public partial class QuestionViewModel
    {
        public int QuestionId { get; set; }
        public string Header { get; set; }
        public State State { get; set; }

        public QuestionViewModel(int questionId, string header, State state)
        {
            this.QuestionId = questionId;
            this.Header = header;
            this.State = state;
        }

        /// <summary>
        /// Created an emty Constructor, for use by WCF to serilize object 
        /// </summary>
        public QuestionViewModel()
        {

        }

        public void SetState(State state)
        {
            this.State = state;
        }
    }

    public enum State
    {       
        OPEN, // open for all
        LOCKED, // closed for all
        PENDING, // someone is answering
        CORRECT, // this contestant answered correct
        WRONG // this contestant answered wrong
    }
}
