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
    /// QuestionList UserControl
    /// Used to list questions
    /// </summary>
    /// <remarks> 
    /// Invokes OnSelectedQuestionChanged event on index changed
    /// </remarks>
    public partial class QuestionList : UserControl
    {
        private BindingList<Question> data;

        // Event declaration using generic EventHandler<T> event type
        public event EventHandler<Question> OnSelectedQuestionChanged;

        public QuestionList()
        {
            InitializeComponent();
            listBoxQuestion.DisplayMember = "Header";
        }

        // Repopulate the list
        public void InitializeQuestionList(List<Question> list)
        {
            data = new BindingList<Question>(list);
            listBoxQuestion.DataSource = data;
        }

        // Allows views to get selected item
        public Question GetSelectedItem()
        {
            return (Question)listBoxQuestion.SelectedItem;
        }

        // Selected item is changed, fires on load and after selected item is changed
        private void listBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Question question = (Question)listBoxQuestion.SelectedItem;

            if (question != null && OnSelectedQuestionChanged != null)
            {
                // Invoke the event
                this.OnSelectedQuestionChanged(this, question);
            }
        }

    }
}
