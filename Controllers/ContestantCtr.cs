using BLL.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ContestantCtr
    {
        /// <summary>
        /// Takes a contestantName and Guid, creates a new contestant. call db insert, to save the new contestant to database.
        /// </summary>
        /// <param name="contestanName"></param>
        public Contestant InsertContestant(string name, int quizInstanceId)
        {
            Contestant contestant = new Contestant(name, quizInstanceId);

            DBContestant dbContestant = new DBContestant();
            try
            {
                dbContestant.InsertContestant(contestant, quizInstanceId);
                return contestant;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        /// <summary>
        /// Takes a contestantName and Guid, creates a new contestant. call db insert, to save the new contestant to database.
        /// </summary>
        /// <param name="contestanName"></param>
        public List<string> GetScoreTable(Guid contestantId)
        {
            List<string> results = new List<string>();
            int quizInstanceId = new DBContestant().GetQuizInstanceIdByContestantId(contestantId);
            QuizInstance quizInstance = new DBQuizInstance().GetQuizInstanceById(quizInstanceId, true);

            return ContestantHighscore(quizInstance);
        }

        /// <summary>
        /// Figures out who the Contestant with the most correct answers are. 
        /// Returns multiple in case of a tie.
        /// </summary>
        private List<String> ContestantHighscore(QuizInstance quizInstance)
        {
            // The two collections are parallel, so the int in one is owned by the Contestant at the 
            // same location in the other.
            int[] noOfCorrectAnswers = new int[quizInstance.Contestants.Count];
            List<Contestant> contestants = quizInstance.Contestants;
            foreach (QuestionInstance questionInstance in quizInstance.QuestionInstances)
            {
                if (questionInstance.CorrectAnswer != null)
                {
                    bool found = false;
                    for (int i = 0; !found; i++)
                    {
                        if (questionInstance.CorrectAnswer.Id.Equals(contestants[i].Id))
                        {
                            noOfCorrectAnswers[i]++;
                            found = true;
                        }
                    }
                }
            }

            List<string> highscore = new List<string>();

            int iteration = 0;
            List<Contestant> remainingContestants = new List<Contestant>();
            remainingContestants.AddRange(contestants);
            while (remainingContestants.Count > 0 && iteration < 1000)
            {
                iteration++;
                List<Contestant> contestantsWithMostCorrect = new List<Contestant>();
                int highestNumber = 0;
                for (int i = 0; i < contestants.Count; i++)
                {
                    if (noOfCorrectAnswers[i] > highestNumber)
                    {
                        contestantsWithMostCorrect.Clear();
                        contestantsWithMostCorrect.Add(contestants[i]);
                        highestNumber = noOfCorrectAnswers[i];
                    }
                    else if (noOfCorrectAnswers[i] == highestNumber)
                    {
                        contestantsWithMostCorrect.Add(contestants[i]);
                    }
                }
                foreach (Contestant contestant in contestantsWithMostCorrect)
                {
                    noOfCorrectAnswers[contestants.LastIndexOf(contestant)] = -1;
                    remainingContestants.Remove(contestant);
                }
                highscore.Add(iteration + ": ");
                int count = 0;
                foreach (Contestant c in contestantsWithMostCorrect)
                {
                    if (count > 0)
                    {
                        highscore[highscore.Count - 1] += ", ";
                    }
                    highscore[highscore.Count - 1] += c.Name;
                    count++;
                }
            }
            return highscore;
        }
    }
}
