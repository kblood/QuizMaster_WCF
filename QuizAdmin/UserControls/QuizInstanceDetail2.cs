using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizAdmin.QuizMasterService;

namespace QuizAdmin.UserControls
{
    /// <summary>
    /// QuizDetail UserControl
    /// Used to display details of quiz
    /// </summary>
    public partial class QuizInstanceDetail2 : UserControl
    {
        public QuizInstanceDetail2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the text based on the quizInstance.
        /// </summary>
        public void InitializeQuizDetail(QuizInstance quizInstance)
        {
            lblTitle.Text = quizInstance.Quiz.Title;
            lblDescription.Text = quizInstance.Quiz.Description;
            lblRunDate.Text = quizInstance.StartDate.ToString("yyyy-MM-dd hh:mm:ss");
            lblNoOfQuestions.Text = "" + quizInstance.QuestionInstances.Count;
            lblNoOfContestants.Text = "" + quizInstance.Contestants.Count;

            string contestantsWithMostCorrectText = "";
            List<Contestant> contestantsWithMostCorrect = ContestantsWithMostCorrect(quizInstance);
            for (int i = 0; i < contestantsWithMostCorrect.Count; i++)
            {
                contestantsWithMostCorrectText += contestantsWithMostCorrect[i].Name;
                if (contestantsWithMostCorrect.Count > i+1)
                {
                    contestantsWithMostCorrectText += "\n";
                }
            }
            lblBestContestants.Text = contestantsWithMostCorrectText;

            string questionsWithMostWrongText = "";
            List<QuestionInstance> questionsWithMostWrong = QuestionsWithMostWrong(quizInstance);
            for (int i = 0; i < questionsWithMostWrong.Count; i++)
            {
                questionsWithMostWrongText += questionsWithMostWrong[i].Header;
                if (questionsWithMostWrong.Count > i + 1)
                {
                    questionsWithMostWrongText += "\n";
                }
            }
            lblHardestQuestion.Text = questionsWithMostWrongText;
        }

        /// <summary>
        /// Figures out who the Contestant with the most correct answers are. 
        /// Returns multiple in case of a tie.
        /// </summary>
        private List<Contestant> ContestantsWithMostCorrect(QuizInstance quizInstance)
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

            // Goes through the Contestants, seing if they have more correct, than the last one.
            // If they do, or are tied, they are added to the return-List.
            int highestNumber = 0;
            List<Contestant> contestantsWithMostCorrect = new List<Contestant>();
            for (int i = 0; i < contestants.Count; i++)
            {
                if (noOfCorrectAnswers[i] > highestNumber)
                {
                    contestantsWithMostCorrect.Clear();
                    contestantsWithMostCorrect.Add(contestants[i]);
                    highestNumber = noOfCorrectAnswers[i];
                }
                else if (noOfCorrectAnswers[i] == highestNumber && contestantsWithMostCorrect.Count < 4)
                {
                    contestantsWithMostCorrect.Add(contestants[i]);
                }
            }
            return contestantsWithMostCorrect;
        }

        /// <summary>
        /// Figures out which question most people answered wrongly. 
        /// Returns multiple in case of a tie.
        /// </summary>
        private List<QuestionInstance> QuestionsWithMostWrong(QuizInstance quizInstance)
        {
            int highestNumber = 0;
            List<QuestionInstance> questionsWithMostWrong = new List<QuestionInstance>();
            foreach (QuestionInstance questionInstance in quizInstance.QuestionInstances)
            {
                if (questionInstance.WrongAnswers.Count > highestNumber)
                {
                    questionsWithMostWrong.Clear();
                    questionsWithMostWrong.Add(questionInstance);
                    highestNumber = questionInstance.WrongAnswers.Count;
                }
                else if (questionInstance.WrongAnswers.Count == highestNumber && questionsWithMostWrong.Count < 4)
                {
                    questionsWithMostWrong.Add(questionInstance);
                }
            }
            return questionsWithMostWrong;
        }
    }
}