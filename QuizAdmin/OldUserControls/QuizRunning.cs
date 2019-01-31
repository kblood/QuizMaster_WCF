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
    public partial class QuizRunning : UserControl
    {
        private TestFormv2 form;
        private QuizMasterServiceClient quizClient;

        public QuizRunning()
        {
            InitializeComponent();
        }

        public QuizRunning(TestFormv2 form, QuizMasterServiceClient quizClient) :this()
        {
            this.quizClient = quizClient;
            this.form = form;
            lblQuiz.Text = "Quizzen " + form.ActiveQuiz.Title + " kører nu";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            form.ActiveQuizInstance.Running = false;
            quizClient.RunQuiz(form.ActiveQuizInstance);
            form.SetWindow("QuizListView");
        }
    }
}
