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
    /// AnswerCreate UserControl
    /// Used to create new answer
    /// </summary>
    /// <remarks> 
    /// Invokes CheckStateChanged event when checkbox changed
    /// Invokes RemoveAnswer event to remove answer/user control
    /// </remarks>
    public partial class AnswerCreate : UserControl
    {
        public event EventHandler<AnswerCreate> CheckStateChanged;
        public event EventHandler<AnswerCreate> RemoveAnswer;

        public AnswerCreate()
        {
            InitializeComponent();
            // Allows us to leave focus on fields, without validating and click elsewhere.
            AutoValidate = AutoValidate.EnableAllowFocusChange;

            // Mouse over tool tips :)
            toolTip.SetToolTip(this.checkCorrect, "Vælg korrekte svar");
            toolTip.SetToolTip(this.btnRemove, "Slet dette svar");
        }


        #region Fields
        // Getters to build new Answer object
        // Text
        public string AnswerText
        {
            get { return txtAnswer.Text; }
        }
        // True equals correct answer
        public bool CorrectAnswerChecked
        {
            get { return checkCorrect.Checked; }
            set { checkCorrect.Checked = value; }
        }

        #endregion

        #region Validate
        private void txtAnswer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnswer.Text))
            {
                lblAnswerError.Text = "Svaret skal udfyldes";
                e.Cancel = true;
            }
        }

        private void txtAnswer_Validated(object sender, EventArgs e)
        {
            lblAnswerError.Text = "";
        }
        #endregion

        // Invokes RemoveAnswer event in question-create control;
        // where this control is removed from list and disposed
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (RemoveAnswer != null)
            {
                // Invoke the event
                RemoveAnswer(checkCorrect.Checked, this);
            }
        }
        // Fires when checkbox checkCorrect is changed
        // Invokes CheckStateChanged event if checked; in question-create control
        private void checkCorrect_CheckStateChanged(object sender, EventArgs e)
        {
            bool @checked = checkCorrect.Checked;
            //checkCorrect.Text = @checked ? "✓" : "✓"; // sets text on checkbox(button)
            checkCorrect.ForeColor = @checked ? Color.White : Color.Green; // sets colour on checkbox(button)
            //checkCorrect.BackColor = @checked ? Color.DarkGreen : Color.White;
            if (CheckStateChanged != null && @checked)
            {
                // Invoke the event
                CheckStateChanged(@checked, this);
            }
        }


    }
}
