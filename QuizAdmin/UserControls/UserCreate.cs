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
    /// UserCreate UserControl
    /// Used to create new user in UserView
    /// </summary>
    /// <remarks> 
    /// Invokes UserCreateClick event on create click
    /// Invokes ToggleView on link click
    /// </remarks>
    public partial class UserCreate : UserControl
    {
        // Event declaration
        public event EventHandler UserCreateClick;
        public event EventHandler ToggleView;
        public UserCreate()
        {
            InitializeComponent();
            // Allows us to leave focus on fields, without validating and click elsewhere.
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        // Create user button click event
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // if all controls is validated , do stuff
            if (this.ValidateChildren() && UserCreateClick != null)
            {
                // Invoke the event
                UserCreateClick(this, EventArgs.Empty);
            }
        }

        // Called when visibility on this control i changed
        private void UserCreate_VisibleChanged(object sender, EventArgs e)
        {
            // Resets/Clears error labels and text boxes
            if (Visible && !Disposing)
            {
                Utilities.ClearAllText(this);
                lblUsernameError.Text = "";
                lblPasswordError.Text = "";
                lblOutput.Text = "";
            }
        }

        // Link event; Toggle control visibility UserLogin <-> UserCreate
        private void lnkLoginUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ToggleView != null)
            {
                // Invoke the event
                ToggleView(this, EventArgs.Empty);
            }
        }

        // Output label; clear input, called by view
        public void UserCreated()
        {
            Utilities.ClearAllText(this);
            lblUsernameError.Text = "";
            lblPasswordError.Text = "";
            lblOutput.Text = "Bruger blev oprettet";
        }

        // Fields used by views
        #region Fields
        public string Username
        {
            get { return txtUsername.Text; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
        }

        public string Output
        {
            set { lblOutput.Text = value; }
        }

        #endregion

        // Validating. Called after focus changed of text box.
        // Validated. Occurs after text field has been successfully validated.
        // 
        // CancelEventArgs. Cancel = true if the event should be cancel
        #region validating

        // Validating. Called after focus changed of text box
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lblUsernameError.Text = "Brugernavn skal udfyldes";
                e.Cancel = true;
            }
            else if (txtUsername.Text.Length < 4)
            {
                lblUsernameError.Text = "Skal være mindst 4 karakter";
                e.Cancel = true;
            }
        }

        // Validated. Occurs after text field has been successfully validated
        private void txtUsername_Validated(object sender, EventArgs e)
        {
            lblUsernameError.Text = "";
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPasswordError.Text = "Password skal udfyldes";
                e.Cancel = true;
            }
            else if (txtPassword.Text.Length < 4)
            {
                lblPasswordError.Text = "Skal være mindst 4 karakter";
                e.Cancel = true;
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            lblPasswordError.Text = "";
        }
        #endregion
    }
}
