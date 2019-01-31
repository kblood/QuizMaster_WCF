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
    /// QuestionCreate UserControl
    /// Used to create new questions with answers
    /// </summary>
    /// <remarks> 
    /// Invokes OnCancelClick event to cancel
    /// Invokes OnSaveQuestionClick when input is validated
    /// </remarks>
    public partial class QuestionCreate : UserControl
    {
        // List of answer controls;
        private List<AnswerCreate> answerControls;
        // Event declaration
        public event EventHandler OnCancelClick;
        public event EventHandler OnSaveQuestionClick;

        public QuestionCreate()
        {
            InitializeComponent();
            // Allows us to leave focus on fields, without validating and click elsewhere.
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        // Reset on visibility changed
        private void QuestionCreate_VisibleChanged(object sender, EventArgs e)
        {
            lblHeaderError.Text = "";
            lblQuestionError.Text = "";
            lblOutput.Text = "";
            pnlAnswers.Controls.Clear();
            Utilities.ClearAllText(this);
            this.answerControls = new List<AnswerCreate>();
        }
        // Fields used by views
        #region Fields
        // Getters to build new Question object
        // Header
        public string HeaderText
        {
            get { return txtHeader.Text; }
        }
        // Text
        public string QuestionText
        {
            get { return txtQuestion.Text; }
        }
        // List<Answers> : AnswerText CorrectAnswerChecked 
        public List<AnswerCreate> Answers
        {
            get { return answerControls; }
        }

        #endregion
        // Validating. Called after focus changed of text box.
        // Validated. Occurs after text field has been successfully validated.
        // 
        // CancelEventArgs. Cancel = true if the event should be cancel
        #region Validating
        private void txtHeader_Validated(object sender, EventArgs e)
        {
            lblHeaderError.Text = "";
        }

        private void txtHeader_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(HeaderText))
            {

                lblHeaderError.Text = "Overskriften skal udfyldes";
                e.Cancel = true;
            }
        }

        private void txtQuestion_Validated(object sender, EventArgs e)
        {
            lblQuestionError.Text = "";
        }

        private void txtQuestion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(QuestionText))
            {
                lblQuestionError.Text = "Spørgsmål skal udfyldes";
                e.Cancel = true;
            }
            else if (QuestionText.Length < 3)
            {
                lblQuestionError.Text = "Skal være mindst 3 karakter lang";
                e.Cancel = true;
            }
        }

        #endregion

        #region Click events


        // Click event; add new "Answer"
        private void lnkAddAnswer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // New
            var answerControl = new AnswerCreate();

            // Add answerControl EventHandlers and method that will handle an event when the event provides data.
            answerControl.CheckStateChanged += new EventHandler<AnswerCreate>(CorrectAnswerChanged);
            answerControl.RemoveAnswer += new EventHandler<AnswerCreate>(RemoveAnswerControl);

            // Add to list of answer-controls
            answerControls.Add(answerControl);
            // Add to panel
            pnlAnswers.Controls.Add(answerControl);
        }

        // Click event; save question
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                // Any answers?
                if (answerControls.Count == 0)
                {
                    lblOutput.Text = "Der skal tilføjes svar";
                }
                // Any correct answers?
                else if (!answerControls.Any(x => x.CorrectAnswerChecked == true))
                {
                    lblOutput.Text = "Der skal vælges korekt svar";
                }
                else
                {
                    SaveQuestion();
                }

            }
        }

        // Invoke the OnSaveQuestionClick event; called after successful validation on btnSave_Click
        private void SaveQuestion()
        {
            if (OnSaveQuestionClick != null)
            {
                // Invoke the event
                OnSaveQuestionClick(this, EventArgs.Empty);
            }
        }
        // Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (OnCancelClick != null)
            {
                // Invoke the event
                OnCancelClick(this, EventArgs.Empty);
            }
        }
        #endregion

        #region EventHandlers

        // Invoked by answer-control, checkCorrect_CheckStateChanged if checked
        // Unchecks all answer-control from list of answer-control, except correct answer(caller)
        private void CorrectAnswerChanged(object checkstate, AnswerCreate answerControl)
        {
            foreach (AnswerCreate item in answerControls)
            {
                // if not caller
                if (!item.Equals(answerControl))
                {
                    item.CorrectAnswerChecked = false;
                }
            }
        }

        // Invoked by answer-control, btnRemove_Click
        // Removed caller from list, and dispose
        private void RemoveAnswerControl(object checkstate, AnswerCreate answerControl)
        {
            answerControls.Remove(answerControl);
            answerControl.Dispose();
        }
        #endregion

    }
}
