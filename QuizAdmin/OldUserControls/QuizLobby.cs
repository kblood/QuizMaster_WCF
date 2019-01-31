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
    public partial class QuizLobby : UserControl
    {
        private Quiz quiz;
        private TestFormv2 form;
        private QuizMasterServiceClient quizClient;

        public QuizLobby()
        {
            InitializeComponent();
        }

        public QuizLobby(QuizMasterServiceClient quizClient, TestFormv2 form) : this()
        {
            this.quizClient = quizClient;
            this.quiz = form.ActiveQuiz;
            this.form = form;
            txtQuizInfo.Text = quiz.Title;
            form.ActiveQuizInstance = quizClient.OpenQuiz(quiz, form.ActiveUser);
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            form.ActiveQuizInstance.Running = true;
            quizClient.RunQuiz(form.ActiveQuizInstance);
            form.SetWindow("QuizRunning");
        }

        private void btnCloseQuiz_Click(object sender, EventArgs e)
        {
            form.ActiveQuizInstance.Open = false;
            quizClient.CloseQuiz(form.ActiveQuizInstance);
            form.ActiveQuizInstance = null;
            form.SetWindow("QuizListView");
        }
    }
}
