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
using System.Threading;

namespace QuizAdmin.UserViews
{
    public partial class QuizRunningView : UserControl
    {
        public event EventHandler CancelRun;
        private IRepository repository;
        private Quiz activeQuiz;
        private QuizInstance quizInstance;
        private Thread thread;

        public QuizRunningView()
        {
            InitializeComponent();

            this.toolTip.SetToolTip(this.btnOpen, "Åben quizzen for deltagelse");
            this.toolTip.SetToolTip(this.btnStart, "Start quizzen og luk for deltagelse");
            this.toolTip.SetToolTip(this.btnStop, "Afslut quizzen");
        }

        public void InitializeQuizInstance(QuizInstance quizInstance)
        {
            lblOutput.Text = "";
            btnOpen.Hide();
            btnStart.Hide();
            btnStop.Hide();

            this.activeQuiz = quizInstance.Quiz;
            this.quizInstance = quizInstance;

            quizDetail.InitializeQuizDetail(activeQuiz);


            if (quizInstance.Open)
            {
                btnStart.Show();
            }

            else if (quizInstance.Running)
            {
                btnStop.Show();
            }

        }

        // Inject QuizMasterServiceClient dependency, and active user
        public void InjectIRepository(IRepository repository)
        {
            this.repository = repository;
        }

        public void SetActiveQuiz(Quiz quiz)
        {
            this.activeQuiz = quiz;
            quizDetail.InitializeQuizDetail(activeQuiz);
            lblHeader.Text = "Start Quiz";
            lblOutput.Text = "";
            btnOpen.Show();
            btnStart.Hide();
            btnStop.Hide();

        }

        private void QuizRunning_VisibleChanged(object sender, EventArgs e)
        {
            if (quizInstance != null)
            {
                if (quizInstance.Running)
                {
                    ShowTable();
                }
                else
                {
                    statisticTable.Visible = false;
                }
            }
        }
        
        private void ShowTable()
        {
            statisticTable.Show();
            statisticTable.InitializeTable(repository.Service.GetQuizInstanceById(quizInstance.Id));
            if (thread == null)
            {
                thread = new Thread(UpdateTable);
                thread.Name = "UpdateTableThread";
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void UpdateTable()
        {
            while (Visible)
            {
                Thread.Sleep(5000);
                statisticTable.InitializeTable(repository.Service.GetQuizInstanceById(quizInstance.Id));
            }
            try
            {
                thread.Abort();
            }
            finally
            {
                thread = null;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.quizInstance = repository.Service.OpenQuiz(activeQuiz, repository.ActiveUser);

            lblOutput.Text = $"Quizzen {activeQuiz.Title} er åben for deltagelse";

            btnOpen.Hide();
            btnStart.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.quizInstance.Running = true;
            repository.Service.RunQuiz(quizInstance);

            lblOutput.Text = $"Quizzen {activeQuiz.Title} er startet";

            btnStart.Hide();
            btnStop.Show();
            ShowTable();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.quizInstance.Running = false;
            repository.Service.RunQuiz(quizInstance);

            lblOutput.Text = $"Quizzen {activeQuiz.Title} er stoppet";

            btnStop.Hide();

            if (CancelRun != null)
            {
                CancelRun(btnStop, EventArgs.Empty);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (quizInstance != null)
            {
                this.quizInstance.Running = false;
                repository.Service.RunQuiz(quizInstance);
            }

            if (CancelRun != null)
            {
                CancelRun(this, EventArgs.Empty);
            }
        }
    }
}
