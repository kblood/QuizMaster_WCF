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
    public partial class Login : UserControl
    {
        private TestFormv2 form;
        private QuizMasterServiceClient quizClient;

        /// <summary>
        /// UI constructor
        /// 
        /// </summary>
        /// <param name="form"></param>
        /// <param name="quizClient"></param>
        public Login(TestFormv2 form, QuizMasterServiceClient quizClient)
        {
            InitializeComponent();
            this.form = form;
            this.quizClient = quizClient;
            //"Easy-login" functionality
            UsernameTextBox.Text = "Knud";
            PasswordTextBox.Text = "1234";
        }

        /// <summary>
        /// Try to log user in
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = quizClient.Login(UsernameTextBox.Text, PasswordTextBox.Text);
            if (user != null)
            {
                successLabel.Text = "Login successful";
                form.ActiveUser = user;
                form.SetWindow("QuizListView");
            }
            else
            {
                successLabel.Text = "Login failed";
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            form.SetWindow("CreateUser");
        }
    }
}
