using QuizAdmin.QuizMasterService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAdmin
{
    public partial class TestForm : Form
    {
        private QuizMasterServiceClient quizService;
        private User user;
        public TestForm()
        {
            quizService = new QuizMasterServiceClient();
            user = new User();
            user.Id = 1;
            user.Username = "Frank";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlTest.Controls.Clear();
            //pnlTest.Controls.Add(new QuizDetails(this, quizService, user));
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            pnlTest.Controls.Clear();
            //pnlTest.Controls.Add(new Login(this, quizService));
        }

        private void btnFindQuiz_Click(object sender, EventArgs e)
        {
            pnlTest.Controls.Clear();
            //pnlTest.Controls.Add(new QuizListView(this, quizService, user));
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            //pnlTest.Controls.Clear();
            //pnlTest.Controls.Add(new CreateQuestion(this, quizService));
        }     

        private void button2_Click(object sender, EventArgs e)
        {
            pnlTest.Controls.Clear();
            //pnlTest.Controls.Add(new CreateUser(quizService));
        }
    }
}
