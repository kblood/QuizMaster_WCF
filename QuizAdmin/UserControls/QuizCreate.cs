using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAdmin.UserControls
{
    /// <summary>
    /// QuizCreate UserControl
    /// Used to create a  new quiz
    /// </summary>
    /// <remarks> 
    /// Invokes OnCancelClick event to abort
    /// Invokes OnSaveQuizClick event when input is validated
    /// </remarks>
    public partial class QuizCreate : UserControl
    {
        // Event declaration
        public event EventHandler OnCancelClick;
        public event EventHandler OnSaveQuizClick;

        public QuizCreate()
        {
            InitializeComponent();
            // Allows us to leave focus on fields, without validating and click elsewhere.
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        // Reset, fires when visible changed
        private void QuizCreate_VisibleChanged(object sender, EventArgs e)
        {
            // Resets/Clears error labels and text boxes
            if (Visible && !Disposing)
            {
                Utilities.ClearAllText(this);
                lblTitleError.Text = "";
                lblDescriptionError.Text = "";
                lblOutput.Text = "";
            }
        }

        // Create new quiz
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // if all controls is validated , do stuff
            if (this.ValidateChildren() && OnSaveQuizClick != null)
            {
                // Invoke the event
                OnSaveQuizClick(this, EventArgs.Empty);
            }
        }

        // Cancel/Hide this again
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (OnCancelClick != null)
            {
                // Invoke the event
                OnCancelClick(this, EventArgs.Empty);
            }
        }

        // Fields used by views
        #region Fields
        public string Title
        {
            get { return txtTitle.Text; }
        }

        public string Description
        {
            get { return txtDescription.Text; }
        }

        #endregion
        /// Validating. Called after focus changed of text box.
        /// Validated. Occurs after text field has been successfully validated.
        /// 
        /// CancelEventArgs. Cancel = true if the event should be cancel

        #region Validating
        // Validating. Called after focus changed of text box
        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                lblTitleError.Text = "Titel skal udfyldes";
                e.Cancel = true;
            }

        }
        // Validated. Occurs after text field has been successfully validated
        private void txtTitle_Validated(object sender, EventArgs e)
        {
            lblTitleError.Text = "";
        }
        // 0 Extra line spaces to irritate Henrik Munk
        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                lblDescriptionError.Text = "Beskrivelse skal udfyldes";
                e.Cancel = true;
            }
        }


        private void txtDescription_Validated(object sender, EventArgs e)
        {
            lblDescriptionError.Text = "";
        }
        #endregion

    }
}
