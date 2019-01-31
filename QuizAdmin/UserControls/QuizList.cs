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
    public partial class QuizList : UserControl
    {
        private BindingList<Quiz> data;

        // Event declaration using generic EventHandler<T> event type
        public event EventHandler<Quiz> OnSelectedQuizChanged;
        public QuizList()
        {
            InitializeComponent();
            listBoxQuiz.DisplayMember = "Title";
        }

        // Repopulate the list
        public void InitializeQuizList(List<Quiz> list)
        {
            data = new BindingList<Quiz>(list);
            listBoxQuiz.DataSource = data;
        }

        // Selected item is changed, fires on load and after selected item is changed
        private void listBoxQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quiz quiz = (Quiz)listBoxQuiz.SelectedItem;

            if (quiz != null && OnSelectedQuizChanged != null)
            {
                // Invoke the event
                this.OnSelectedQuizChanged(this, quiz);
            }
        }
    }
}
