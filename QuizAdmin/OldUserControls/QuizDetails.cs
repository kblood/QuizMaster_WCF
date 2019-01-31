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
    public partial class QuizDetails : UserControl
    {
        private TestFormv2 form;
        private QuizMasterServiceClient quizClient;
        //private User user;
        public QuizDetails()
        {
            InitializeComponent();
        }

        public QuizDetails(TestFormv2 form, QuizMasterServiceClient quizClient)
        {
            this.form = form;
            this.quizClient = quizClient;
            //this.user = user;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateQuiz();
            form.SetWindow("QuizListView");
        }

        /*
        Parametres are validated.
        Sends parametres to the quizService. quizService returns a Quiz object.
        */
        private void CreateQuiz()
        {
            string title = txtTitle.Text;
            string description = txtFieldDescription.Text;
            if(title != "" && description != "" && title != "Invalid title" && description != "Invalid description")
            {
                Quiz quiz = quizClient.CreateQuiz(title, description, form.ActiveUser);
                //Forsæt herfra
            }  
            else
            {
                if(title == "" || title == "Invalid title")
                {
                    txtTitle.Text = "Invalid title";
                }
                if(description == "" || description == "Invalid description")
                {
                    txtFieldDescription.Text = "Invalid description";
                }
            }          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            form.SetWindow("QuizListView");
        }
    }
}
