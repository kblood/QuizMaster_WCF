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
    public partial class TestFormv2 : Form
    {
        private QuizMasterServiceClient quizService;

        private UserControl createUser, createQuestion, logIn, quizDetails, quizLobby, questionListView;

        public User ActiveUser { get; set; }
        public Quiz ActiveQuiz { get; set; }
        public QuizInstance ActiveQuizInstance { get; set; }
        public string PreviousWindow { get; set; }

        public TestFormv2()
        {
            InitializeComponent();
            quizService = new QuizMasterServiceClient();
            logIn = new Login(this, quizService);
            SetWindow("Login");
            quizDetails = new QuizDetails(this, quizService);
            questionListView = new QuestionListView(this, quizService);
            createQuestion = new CreateQuestion(quizService, this);
            //createQuestion = new CreateQuestion(...)
            createUser = new CreateUser(quizService, this);
            PreviousWindow = "QuizListView";
        }


        public void SetWindow(string name)
        {
            switch (name)
            {
                case "QuizQuestionView":
                    pnlView.Controls.Clear();
                    pnlView.Controls.Add(new QuizQuestionView(this, quizService));
                    break;
                case "CreateUser":
                    pnlView.Controls.Clear();
                    pnlView.Controls.Add(createUser);
                    break;
                case "CreateQuestion":
                    pnlView.Controls.Clear();
                    pnlView.Controls.Add(createQuestion);
                    break;
                case "Login":
                    pnlView.Controls.Clear();
                    pnlView.Controls.Add(logIn);
                    break;
                case "QuizDetails":
                    pnlView.Controls.Clear();
                    pnlView.Controls.Add(quizDetails);
                    break;
                case "QuizListView":
                    pnlView.Controls.Clear();
                    pnlView.Controls.Add(new QuizListView(this, quizService));
                    break;
                case "QuizLobby":
                    pnlView.Controls.Clear();
                    quizLobby = new QuizLobby(quizService, this);
                    pnlView.Controls.Add(quizLobby);
                    break;
                case "QuestionListView":
                    pnlView.Controls.Clear();
                    pnlView.Controls.Add(questionListView);
                    break;
                case "QuizRunning":
                    pnlView.Controls.Clear();
                    pnlView.Controls.Add(new QuizRunning(this, quizService));
                    break;
                default:
                    break;
            }/*
            if (name == "QuizQuestionView")
            {
                pnlView.Controls.Clear();
                pnlView.Controls.Add(new QuizQuestionView(this, quizService));
            }
            else if (name == "CreateUser")
            {
                pnlView.Controls.Clear();
                pnlView.Controls.Add(createUser);
            }
            else if (name == "CreateQuestion")
            {
                pnlView.Controls.Clear();
                pnlView.Controls.Add(createQuestion);
            }
            else if (name == "Login")
            {
                pnlView.Controls.Clear();
                pnlView.Controls.Add(logIn);
            }
            else if (name == "QuizDetails")
            {
                pnlView.Controls.Clear();
                pnlView.Controls.Add(quizDetails);
            }
            else if (name == "QuizListView")
            {
                pnlView.Controls.Clear();
                pnlView.Controls.Add(quizListView);
            }
            else if (name == "QuizLobby")
            {
                pnlView.Controls.Clear();
                quizLobby = new QuizLobby(quizService, this);
                pnlView.Controls.Add(quizLobby);
            }
            else if (name == "QuestionListView")
            {
                pnlView.Controls.Clear();
                pnlView.Controls.Add(questionListView);
            }
            else if (name == "QuizRunning")
            {
                pnlView.Controls.Clear();
                pnlView.Controls.Add(new QuizRunning(this, quizService));
            }*/
        }
    }
}
