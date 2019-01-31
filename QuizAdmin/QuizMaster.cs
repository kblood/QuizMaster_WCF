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
{    /// <summary>
     /// QuizMaster Form
     /// Main form to display all user controls
     /// </summary>
     /// <remarks> 
     /// QuizMaster is a IRepository
     /// </remarks>
    public partial class QuizMaster : Form, IRepository
    {
        private User activeUser;

        public QuizMaster()
        {
            InitializeComponent();

            pnlMainWrapper.Hide();
            //pnlMainWrapper.Show();

            IRepositoryInjection();
            InitializeEventHandler();
        }

        // Inject IRepository interface 
        private void IRepositoryInjection()
        {
            userView.InjectIRepository(this);
            quizView.InjectIRepository(this);
            questionView.InjectIRepository(this);
            quizQuestionView.InjectIRepository(this);
            quizRunningView.InjectIRepository(this);
            quizStatisticsListView.InjectIRepository(this);
            quizStatisticsView.InjectIRepository(this);
        }

        // EventHandlers and method that will handle an event when the event provides data.
        private void InitializeEventHandler()
        {
            // User is successfully logged in
            userView.SetActiveUser += new EventHandler<User>(OnUserLoginEvent);
            // Manage question on existing quiz
            quizView.OnAddQuestionToQuiz += new EventHandler<Quiz>(InitializeQuizQuestionView);
            // Start a quiz
            quizView.OnStartQuiz += new EventHandler<Quiz>(StartQuiz);
            // See statistics for a quiz that has been run
            quizStatisticsListView.OnSeeStatistics += new EventHandler<QuizInstance>(InitializeQuizStatisticsView);

            //Cancel run quiz click
            quizRunningView.CancelRun += new EventHandler(CancelRun);
        }

        private void CancelRun(object sender, EventArgs e)
        {
            if (!(sender is Button))
            {
                quizRunningView.Hide();
                quizView.Show();
            }

            ActiveQuiz();
        }

        // Invoked by quiz-view when question button on selected quiz is clicked
        private void InitializeQuizQuestionView(object sender, Quiz quiz)
        {
            // Set active quiz in quiz-question-view
            quizQuestionView.SetActiveQuiz(quiz);
            // Hide quiz-view (sender)
            quizView.Hide();
            // Show quiz-question-view
            quizQuestionView.Show();

            //ActiveQuiz();
        }

        // Invoked by quizStatisticsListView when statistics are requested for at QuizInstance
        private void InitializeQuizStatisticsView(object sender, QuizInstance quizInstance)
        {
            // Set active quiz in quiz-question-view
            quizStatisticsView.SetActiveQuizInstance(quizInstance);
            // Hide quiz-view (sender)
            quizStatisticsListView.Hide();
            // Show quiz-question-view
            quizStatisticsView.Show();

            //ActiveQuiz();
        }

        // Invoked by quiz-view when start button on selected quiz is clicked
        private void StartQuiz(object sender, Quiz quiz)
        {
            var activeQuiz = Service.GetActiveQuizByUserId(ActiveUser.Id);

            if (activeQuiz != null)
            {
                btnSidebarActiveQuiz.Show();
                quizRunningView.lblHeader.Text = "Du har allerede en aktiv quiz";
                quizRunningView.InitializeQuizInstance(activeQuiz);
            }
            else
            {
                // Set active quiz in quiz-running-view
                quizRunningView.SetActiveQuiz(quiz);
            }

            // Hide quiz-view (sender)
            quizView.Hide();
            // Show quiz-running-view
            quizRunningView.Show();

            ActiveQuiz();
        }

        // Invoked by user-view when user is successfully logged in
        private void OnUserLoginEvent(object sender, User user)
        {
            // Set active-user (IRepository)
            this.activeUser = user;
            // Set username label
            lblUsername.Text = activeUser.Username;
            // Hide login panel wrapper with user-view
            pnlLoginWrapper.Hide();

            // Show main panel wrapper with all others views
            pnlMainWrapper.Show();
            questionView.Hide();
            quizView.Show();
            quizQuestionView.Hide();
            quizRunningView.Hide();

            ActiveQuiz();
        }

        private void ActiveQuiz()
        {
            var activeQuiz = Service.GetActiveQuizByUserId(ActiveUser.Id);

            if (activeQuiz != null)
            {
                btnSidebarActiveQuiz.Show();
            }
            else
            {
                btnSidebarActiveQuiz.Hide();
            }
        }

        #region Main form events

        // User logout
        private void lnkUserLoguot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            activeUser = null;
            lblUsername.Text = "";
            pnlLoginWrapper.Show();
            pnlMainWrapper.Hide();

        }

        // Force form to close after a validation is in focus
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        #endregion

        #region Sidebar menu

        // Quiz menu button click
        private void btnSidebarQuiz_Click(object sender, EventArgs e)
        {
            quizView.Show();
            questionView.Hide();
            quizQuestionView.Hide();
            quizRunningView.Hide();
            quizStatisticsListView.Hide();
            quizStatisticsView.Hide();

            ActiveQuiz();
        }

        // Question menu button click
        private void btnSidebarQuestion_Click(object sender, EventArgs e)
        {
            questionView.Show();
            quizView.Hide();
            quizQuestionView.Hide();
            quizRunningView.Hide();
            quizStatisticsListView.Hide();
            quizStatisticsView.Hide();

            ActiveQuiz();
        }

        private void btnSidebarStatistics_Click(object sender, EventArgs e)
        {
            quizView.Hide();
            questionView.Hide();
            quizQuestionView.Hide();
            quizRunningView.Hide();
            quizStatisticsView.Hide();

            quizStatisticsListView.Show();
        }

        private void btnSidebarActiveQuiz_Click(object sender, EventArgs e)
        {
            var activeQuiz = Service.GetActiveQuizByUserId(ActiveUser.Id);
            quizRunningView.InitializeQuizInstance(activeQuiz);
            questionView.Hide();
            quizView.Hide();
            quizQuestionView.Hide();
            quizStatisticsListView.Hide();
            quizStatisticsView.Hide();

            quizRunningView.Show();
        }

        #endregion

        #region Interface IRepository

        public QuizMasterServiceClient Service
        {
            get
            {
                return new QuizMasterServiceClient();
            }
        }

        public User ActiveUser
        {
            get
            {
                return activeUser;
            }
        }

        #endregion
    }
}
