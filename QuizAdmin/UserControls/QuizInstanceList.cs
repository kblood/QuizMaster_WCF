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

namespace QuizAdmin.UserControls
{
    /// <summary>
    /// QuizList UserControl
    /// Used to list quizzes
    /// </summary>
    /// <remarks> 
    /// Invokes OnSelectedQuizChanged event on index changed
    /// </remarks>
    public partial class QuizInstanceList : UserControl
    {
        private BindingList<QuizInstance> data;

        // Event declaration using generic EventHandler<T> event type
        public event EventHandler<QuizInstance> OnSelectedQuizChanged;
        public QuizInstanceList()
        {
            InitializeComponent();
            listBoxQuiz.DisplayMember = "StartDate";
        }

        // Repopulate the list
        public void InitializeQuizList(List<QuizInstance> list)
        {
            list = list.OrderByDescending(q => q.StartDate).ToList();
            data = new BindingList<QuizInstance>(list);
            listBoxQuiz.DataSource = data;
            listBoxQuiz.DisplayMember = "StartDate";
        }

        public void LoadingList()
        {
            List<string> list = new List<string>();
            list.Add("Indlæser listen");
            listBoxQuiz.DataSource = list;
        }

        // Selected item is changed, fires on load and after selected item is changed
        private void listBoxQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxQuiz.SelectedItem is QuizInstance)
            {
                QuizInstance quizInstance = (QuizInstance)listBoxQuiz.SelectedItem;

                if (quizInstance != null && OnSelectedQuizChanged != null)
                {
                    // Invoke the event
                    this.OnSelectedQuizChanged(this, quizInstance);
                }
            }
        }
    }
}
