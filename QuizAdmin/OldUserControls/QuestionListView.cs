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
    public partial class QuestionListView : UserControl
    {
        private TestFormv2 form;
        private QuizMasterServiceClient quizClient;
        private List<Question> questions;
        private BindingList<Question> data;

        public QuestionListView()
        {
            InitializeComponent();
        }
        public QuestionListView(TestFormv2 form, QuizMasterServiceClient quizClient)
        {
            InitializeComponent();
            this.quizClient = quizClient;
            this.form = form;
            questions = quizClient.GetQuestions().ToList();
            data = new BindingList<Question>();
            FillDataList();
            listBoxQuestion.DisplayMember = "Header";
            listBoxQuestion.DataSource = data;
        }

        private void FillDataList()
        {
            foreach (Question question in questions)
            {
                data.Add(question);
            }
        }

        private void listBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Question question = (Question)listBoxQuestion.SelectedItem;
            txtQuestionInfo.Text = $"{question.Header}\n{question.Text}";
        }

        private void btbCreateQuestion_Click(object sender, EventArgs e)
        {
            form.PreviousWindow = "QuestionListView";
            this.pnlQuestion.Controls.Clear();
            this.pnlQuestion.Controls.Add(new CreateQuestion(quizClient, form));
        }

        private void QuestionTab_Click(object sender, EventArgs e)
        {
            form.SetWindow("QuizListView");
        }
    }
}
