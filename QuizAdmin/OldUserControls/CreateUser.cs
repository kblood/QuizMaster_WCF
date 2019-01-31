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
    public partial class CreateUser : UserControl
    {
        private QuizMasterServiceClient quizClient;
        private TestFormv2 form;

        /// <summary>
        /// Initialize UI-element
        /// </summary>
        /// <param name="quizClient">The service-reference</param>
        public CreateUser(QuizMasterServiceClient quizClient, TestFormv2 form)
        {
            InitializeComponent();
            this.quizClient = quizClient;
            this.form = form;
        }

        /// <summary>
        /// Attempts to create the new user.
        /// Informs if the username and/or is invalid or something went wrong server-side.
        /// </summary>
        private void createButton_Click(object sender, EventArgs e)
        {
            successLabel.Text = "";
            char[] chars = new char[] { ' ' };
            UsernameTextBox.Text = UsernameTextBox.Text.TrimStart(chars).TrimEnd(chars);
            if (validateUserData())
            {
                try
                {
                    String username = UsernameTextBox.Text, password = PasswordTextBox.Text;
                    if(quizClient.InsertUser(username, password) > 0)
                    {
                        successLabel.Text = "Bruger oprettet";
                        backButton.Text = "Tilbage";
                    }
                    else
                    {
                        successLabel.Text = "Der opstod en fejl under oprettelsen af brugeren.\n";
                        successLabel.Text += "Prøv evt. et andet brugernavn";
                    }
                }
                catch (Exception)
                {
                    successLabel.Text = "Der opstod en fejl under oprettelsen af brugeren.\n";
                    successLabel.Text += "Prøv evt. et andet brugernavn";
                }
            }
        }

        /// <summary>
        /// Tests if the given username and passwords works with our standards.
        /// </summary>
        /// <returns>True if all good, otherwise false</returns>
        private bool validateUserData()
        {
            bool valid = true;
            #region username
            if (UsernameTextBox.Text.Length < 4)
            {
                successLabel.Text += "Brugernavn skal mindst være 4 karakterer langt\n";
                valid = false;
            }
            #endregion
            #region password
            if (PasswordTextBox.Text.Length < 4)
            {
                successLabel.Text += "Password skal mindst være 4 karakterer langt\n";
                valid = false;
            }
            #endregion
            return valid;
        }

        /// <summary>
        /// Is to change to the Login-screen.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            form.SetWindow("Login");
        }

        /// <summary>
        /// When enter is pressed, while the passwordTextBox is in focus, create the User.
        /// </summary>
        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                createButton_Click(sender, e);
            }
        }

        /// <summary>
        /// When enter is pressed, while the usernameTextBox is in focus, move the focus on.
        /// </summary>
        private void UsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PasswordTextBox.Focus();
            }
        }
    }
}
