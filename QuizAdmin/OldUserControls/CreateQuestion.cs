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

namespace QuizAdmin
{
    public partial class CreateQuestion : UserControl
    {
        private Question question;
        private List<CreateAnswer> answersControl;

        private QuizMasterServiceClient quizClient;
        private TestFormv2 form;
        /// <summary>
        /// Creates a proxy class with question from service with a list of answers
        /// </summary>
        /// <param name="quizClient"></param>
        /// <param name="form"></param>
        public CreateQuestion(QuizMasterServiceClient quizClient, TestFormv2 form)
        {                                
            InitializeComponent();
            this.question = quizClient.CreateQuestion();
            this.answersControl = new List<CreateAnswer>();
            this.quizClient = quizClient;
            this.form = form;
        }
        /// <summary>
        /// Creates a button with right answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntAddAnswer_Click(object sender, EventArgs e)
        {
            var answer = new Answer();
            var answerControl = new CreateAnswer(this, answer);
            pnlAnswers.Controls.Add(answerControl);
            answersControl.Add(answerControl);
            question.Answers.Add(answer);
        }
        /// <summary>
        /// Removes answers from List and check if correct answer isn't null
        /// </summary>
        /// <param name="createanswer"></param>
        public void removeAnswers(CreateAnswer createanswer)
        {
            pnlAnswers.Controls.Remove(createanswer);
            question.Answers.Remove(createanswer.answer);

            if (question.CorrectAnswer != null && question.CorrectAnswer.Equals(createanswer.answer))
            {
                question.CorrectAnswer = null;
            }
        }

        /// <summary>
        /// Checks if the state of the correct answer has changed
        /// </summary>
        /// <param name="answer"></param>
        public void CorrectAnswerChanged(CreateAnswer answer)
        {
            //if (question.CorrectAnswer != null)
            //{
            //    question.CorrectAnswer.Id = 0;
            //}
            foreach (var item in answersControl)
            {
                if (item != answer)
                {
                    item.BackColor = Color.AliceBlue;                      
                }
                else
                {
                    item.BackColor = Color.Green;
                }
            }
            if (question.CorrectAnswer == answer.answer)
            {
                question.CorrectAnswer = null;
                answer.BackColor = Color.AliceBlue;
            }

            //if (question.CorrectAnswer != null && question.CorrectAnswer.Equals(answer.answer))
            //{
                
            //}

            else
            {
                question.CorrectAnswer = answer.answer;
                //question.CorrectAnswer.Id = 1337;
            }
            
        }

        /// <summary>
        /// Saves answers using the saveQuestion method from the Ctr. The lblOutput label shows
        /// if the answer is saved and disables the Save btn so it's not possible to save the same answer again(only for now).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (question.CorrectAnswer == null || string.IsNullOrEmpty(txtHeader.Text) || string.IsNullOrEmpty(txtQuestion.Text))
            {
                lblOutput.Text = "Tilføj et korrekt svar, eller Headeren er tom, eller Question er tom";
            }
            else
            {
                question.Header = txtHeader.Text;
                question.Text = txtQuestion.Text;

                foreach (var item in answersControl)
                {
                    item.answer.Text = item.txtAnswer.Text;
                }

                quizClient.SaveQuestion(question);
                lblOutput.Text = "Spørgsmål Gemt.";

                btnSave.Enabled = false;
            } 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            form.SetWindow(form.PreviousWindow);
        }
    }
}
