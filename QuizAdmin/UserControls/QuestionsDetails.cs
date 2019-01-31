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
    /// QuestionsDetails UserControl
    /// Used to display details of question
    /// </summary>
    public partial class QuestionsDetails : UserControl
    {
        public QuestionsDetails()
        {
            InitializeComponent();
        }

        // Feed with selected/active question
        public void InitializeQuestionsDetail(Question question)
        {
            lblHeader.Text = question.Header;
            lblQuestion.Text = question.Text;
            lblCreateDate.Text = question.CreateDate.ToString("d");          
        }
    }
}
