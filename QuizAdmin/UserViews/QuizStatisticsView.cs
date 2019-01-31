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
    public partial class QuizStatisticsView : UserControl
    {
        private QuizInstance activeQuizInstance;
        private IRepository repository;

        public QuizStatisticsView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the connection to the service.
        /// </summary>
        internal void InjectIRepository(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Initializes the page.
        /// </summary>
        internal void SetActiveQuizInstance(QuizInstance quizInstance)
        {
            this.activeQuizInstance = quizInstance;
            statisticTable.InitializeTable(quizInstance);
            quizInstanceDetail2.InitializeQuizDetail(quizInstance);
        }
    }
}
