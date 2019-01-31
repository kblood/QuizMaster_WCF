using BLL.Model;
using BLL.ViewModel;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class QuestionInstanceCtr
    {
        public List<QuestionViewModel> SeeQuestionsOnQuiz(Guid contestantId, int quizInstanceId)
        {
            List<QuestionInstance> instances = new DBQuestionInstance().GetQuestionInstances(quizInstanceId, contestantId);
            List<QuestionViewModel> models = new List<QuestionViewModel>();
            foreach(QuestionInstance instance in instances)
            {
                models.Add(QuestionViewModelBuilder(instance, contestantId));
            }
            return models;
        }

        private QuestionViewModel QuestionViewModelBuilder(QuestionInstance instance, Guid contestantId)
        {
            QuestionViewModel model = new QuestionViewModel();

            model.Header = instance.Header;
            model.QuestionId = instance.QuestionId;
            bool found = false;
            //Guid guid; //A Guid can't be null
            //If the question has been answered, save the guid
            if (instance.CorrectAnswer !=null)
            {
                //Is the guid someone else?
                if (!instance.CorrectAnswer.Id.Equals(contestantId))
                {
                    model.SetState(State.LOCKED);
                }
                //or is it this contestant?
                else
                {
                    model.SetState(State.CORRECT);
                }
            }
            //Has this contestant tried this question and answered with a wrong question?
            else if (SearchWrongContestants(contestantId, instance.WrongAnswers))
            {
                model.SetState(State.WRONG);
            }
            //Has the timeout been passed yet?
            else if (instance.TimeOut.Ticks > DateTime.Now.Ticks)
            {
                model.SetState(State.PENDING);
            }
            //If none of all that is the case, the question is open
            else
            {
                model.SetState(State.OPEN);
            }
            return model;
        }

        private bool SearchWrongContestants(Guid contestantId, List<Contestant> contestants)
        {
            bool found = false;
            int index = 0;
            while(!found && index < contestants.Count)
            {
                if(contestantId.Equals(contestants[index].Id))
                {
                    found = true;
                }
                index++;
            }
            return found;
        }
    }
}
