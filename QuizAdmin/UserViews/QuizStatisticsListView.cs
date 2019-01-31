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
    public partial class QuizStatisticsListView : UserControl
    {
        private IRepository repository;
        private QuizInstance activeQuizInstance;
        
        public event EventHandler<QuizInstance> OnSeeStatistics;

        public QuizStatisticsListView()
        {
            InitializeComponent();
            InitializeEventHandler();
        }

        public void InjectIRepository(IRepository repository)
        {
            this.repository = repository;
        }

        // Reset; Called when visibility on this control is changed
        private void QuizView_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && !Disposing && repository != null)
            {
                InitializeQuizList();
                ShowQuizInstanceDetail();
            }
        }

        // Add event handlers and event-invoking method
        private void InitializeEventHandler()
        {
            // when selected index/quiz is changed
            this.quizInstanceList.OnSelectedQuizChanged += (sender, quizInstance) =>
            {
                this.activeQuizInstance = quizInstance;
                InitializeQuizDetail();
            };
        }

        // Repopulate quiz list
        private async void InitializeQuizList()
        {
            this.quizInstanceList.LoadingList();
            this.quizInstanceList.InitializeQuizList(await repository.Service.GetQuizInstancesAsync(repository.ActiveUser));
        }

        // When selected index/quiz is changed on quiz list
        private void InitializeQuizDetail()
        {
            this.quizInstanceDetail.InitializeQuizDetail(activeQuizInstance);
        }

        // Create quiz; click
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (OnSeeStatistics != null)
            {
                // Invoke the event; main form display another view
                OnSeeStatistics(this, repository.Service.GetQuizInstanceById(activeQuizInstance.Id));
            }
        }

        // Show quiz detail user control
        private void ShowQuizInstanceDetail()
        {
            quizInstanceDetail.Show();
            quizCreate.Hide();
            btnStatistics.Show();
            lblToggleHeader.Text = "Detaljer";
        }

        // Show create quiz user control
        private void ShowQuizCreate()
        {
            quizInstanceDetail.Hide();
            quizCreate.Show();

            btnStatistics.Hide();
            lblToggleHeader.Text = "Opret quiz";
        }
    }
}