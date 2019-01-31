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

namespace QuizAdmin.UserViews
{
    /// <summary>
    /// QuizView UserControl
    /// Used to show list of quizzes, details and create new quiz
    /// </summary>
    /// <remarks> 
    /// Invokes OnStartQuiz event to start quiz
    /// Invokes OnAddQuestionToQuiz event to add questions
    /// </remarks>
    public partial class QuizView : UserControl
    {
        private IRepository repository;
        private Quiz activeQuiz;

        // Event declaration using generic EventHandler<T> event type
        public event EventHandler<Quiz> OnAddQuestionToQuiz;
        public event EventHandler<Quiz> OnStartQuiz;

        public QuizView()
        {
            InitializeComponent();
            InitializeEventHandler();
        }

        public void InjectIRepository(IRepository repository)
        {
            this.repository = repository;
        }

        // Reset; Called when visibility on this control i changed
        private void QuizView_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && !Disposing && repository != null)
            {
                InitializeQuizList();
                ShowQuizDetail();
            }
        }

        // Add event handlers and event-invoking method
        private void InitializeEventHandler()
        {
            // when selected index/quiz is changed
            this.quizList.OnSelectedQuizChanged += (sender, quiz) =>
            {
                this.activeQuiz = quiz;
                InitializeQuizDetail();
                feedbackLabel.Text = "";
            };

            // Create quiz
            this.quizCreate.OnSaveQuizClick += new EventHandler(OnQuizCreate);
            this.quizCreate.OnCancelClick += new EventHandler(CancelCreate);
        }

        // Hide quiz create control again
        private void CancelCreate(object sender, EventArgs e)
        {
            ShowQuizDetail();
        }

        // Create quiz; input is validate. Call service to create new quiz
        private void OnQuizCreate(object sender, EventArgs e)
        {
            repository.Service.CreateQuiz(quizCreate.Title, quizCreate.Description, repository.ActiveUser);
            // get a fresh list
            InitializeQuizList();
            // hide create view
            ShowQuizDetail();
        }


        // Repopulate quiz list
        private void InitializeQuizList()
        {
            this.quizList.InitializeQuizList(repository.Service.GetQuizes());
        }

        // When selected index/quiz is changed on quiz list
        private void InitializeQuizDetail()
        {
            this.quizDetail.InitializeQuizDetail(activeQuiz);
        }

        // Create quiz; click
        private void btnCreate_Click(object sender, EventArgs e)
        {
            ShowQuizCreate();
        }

        // Show quiz detail user control
        private void ShowQuizDetail()
        {
            quizDetail.Show();
            quizCreate.Hide();
            pnlBtnDetail.Show();
            btnCreate.Show();
            lblToggleHeader.Text = "Detaljer";
            
        }

        // Show create quiz user control
        private void ShowQuizCreate()
        {
            quizDetail.Hide();
            quizCreate.Show();

            pnlBtnDetail.Hide();
            btnCreate.Hide();
            lblToggleHeader.Text = "Opret quiz";
        }

        // Add question to selected quiz click
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            if(OnAddQuestionToQuiz != null)
            {
                // Invoke the event; main form display another view
                OnAddQuestionToQuiz(this, activeQuiz);
            }
        }

        // Start selected quiz
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (OnStartQuiz != null)
            {
                // Invoke the event; main form display another view
                OnStartQuiz(this, activeQuiz);
            }
        }

        // Delete selected quiz
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(activeQuiz.AuthorId != repository.ActiveUser.Id)
            {
                feedbackLabel.ForeColor = Color.Red;
                feedbackLabel.Text = "Du kan kun slette dine egne quizzer.";
            }
            else if (MessageBox.Show($"Vil du slette {activeQuiz.Title}? Ole!", "Quizmaster",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string name = activeQuiz.Title;
                repository.Service.DeleteQuiz(activeQuiz.Id);
                InitializeQuizList();
                feedbackLabel.ForeColor = Color.Black;
                feedbackLabel.Text = "Du slettede quizzen: " +name;
            }
            
        }
    }
}
