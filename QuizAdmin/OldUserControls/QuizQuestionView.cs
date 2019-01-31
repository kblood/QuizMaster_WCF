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
    public partial class QuizQuestionView : UserControl
    {
        private TestFormv2 form;
        private QuizMasterServiceClient quizClient;
        private List<Question> allQuestions;
        private List<Question> quizQuestions;
        private BindingList<Question> includedQuestions;
        private BindingList<Question> excludedQuestions;

        private Question selectedQuestion;

        public QuizQuestionView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for this view.
        /// It gets the questions for the quiz and all questions
        /// then makes a list of all questions not on the list to display
        /// beside the list of questions that is on the list.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="quizClient"></param>
        public QuizQuestionView(TestFormv2 form, QuizMasterServiceClient quizClient)
        {
            InitializeComponent();
            this.form = form;
            this.quizClient = quizClient;
            allQuestions = quizClient.GetQuestions();
            quizQuestions = quizClient.GetAllByQuizId(form.ActiveQuiz.Id);
            includedQuestions = new BindingList<Question>(quizQuestions);

            // Get all questions not on the quiz
            var result = allQuestions.Where(aq => !quizQuestions.Any(qq => aq.Id == qq.Id)).ToList();
            
            excludedQuestions = new BindingList<Question>(result);
            listBoxQuestionsOnQuiz.DisplayMember = "Header";
            listBoxQuestionsNotOnQuiz.DisplayMember = "Header";
            listBoxQuestionsOnQuiz.DataSource = includedQuestions;
            listBoxQuestionsNotOnQuiz.DataSource = excludedQuestions;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Question question = (Question)listBoxQuestionsNotOnQuiz.SelectedItem;
            if (question != null)
            {
                includedQuestions.Add(question);
                //quizQuestions.Add(question);
                excludedQuestions.Remove(question);
                quizClient.AddQuestion(form.ActiveQuiz.Id, question.Id);
            }
        }

        private void listBoxQuestionsOnQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedQuestion = (Question)listBoxQuestionsOnQuiz.SelectedItem;
        }

        private void listBoxQuestionsNotOnQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedQuestion = (Question)listBoxQuestionsNotOnQuiz.SelectedItem;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            form.SetWindow("QuizListView");
        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            form.PreviousWindow = "QuizQuestionView";
            form.SetWindow("CreateQuestion");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Question question = (Question)listBoxQuestionsOnQuiz.SelectedItem;
            if (question != null)
            {
                excludedQuestions.Add(question);
                includedQuestions.Remove(question);
                quizClient.RemoveQuestion(form.ActiveQuiz.Id, question.Id);
            }
        }
    }
}
