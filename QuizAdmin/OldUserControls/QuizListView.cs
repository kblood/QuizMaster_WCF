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
    public partial class QuizListView : UserControl
    {
        private TestFormv2 form;
        private QuizMasterServiceClient quizClient;
        private List<Quiz> quizzes;
        private BindingList<Quiz> data;

        public QuizListView()
        {
            InitializeComponent();
        }
        public QuizListView(TestFormv2 form, QuizMasterServiceClient quizClient)
        {
            InitializeComponent();
            this.quizClient = quizClient;
            this.form = form;
            quizzes = quizClient.GetQuizes();
            data = new BindingList<Quiz>();
            FillDataList();
            listBoxQuiz.DisplayMember = "Title";
            listBoxQuiz.DataSource = data;
        }

        private void FillDataList()
        {
            foreach (Quiz quiz in quizzes)
            {
                data.Add(quiz);
            }
        }

        private void listBoxQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quiz quiz = (Quiz)listBoxQuiz.SelectedItem;
            txtQuizInfo.Text = $"{quiz.Title}\n{quiz.Description}";
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            form.ActiveQuiz = (Quiz)listBoxQuiz.SelectedItem;
            form.SetWindow("QuizQuestionView");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            form.ActiveQuiz = (Quiz)listBoxQuiz.SelectedItem;
            form.SetWindow("QuizLobby");
        }

        private void btbCreateQuiz_Click(object sender, EventArgs e)
        {
            form.SetWindow("QuizDetails");
        }

        private void QuestionTab_Click(object sender, EventArgs e)
        {
            form.SetWindow("QuestionListView");
        }
    }
}
