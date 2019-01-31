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
    /// QuizDetail UserControl
    /// Used to display details of quiz
    /// </summary>
    public partial class QuizDetail : UserControl
    {
        public QuizDetail()
        {
            InitializeComponent();
        }

        // Feed with selected/active quiz
        public void InitializeQuizDetail(Quiz quiz)
        {
            lblTitle.Text = quiz.Title;
            lblDescription.Text = quiz.Description;
            lblCreateDate.Text = quiz.CreateDate.ToString("d");
            lblUpdatedDate.Text = quiz.UpdatedDate.ToString("d");
        }
    }
}
