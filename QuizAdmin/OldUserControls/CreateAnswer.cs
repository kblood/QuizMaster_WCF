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

namespace QuizAdmin
{
    public partial class CreateAnswer : UserControl
    {
        public Answer answer { get; set; }
        private CreateQuestion questionControl;
        public CreateAnswer(CreateQuestion questionControl, Answer answer)
        {
            this.answer = answer;      
            this.questionControl = questionControl;
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void btnRemoveAnswer_Click(object sender, EventArgs e)
        {
            questionControl.removeAnswers(this);
        }     

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            questionControl.CorrectAnswerChanged(this);
        }
    }
}
