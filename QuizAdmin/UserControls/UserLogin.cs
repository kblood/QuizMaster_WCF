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
    /// UserLogin UserControl
    /// Used to login user in UserView
    /// </summary>
    /// <remarks> 
    /// Invokes UserLoginClick event on login click
    /// Invokes ToggleView on link click
    /// </remarks>
    public partial class UserLogin : UserControl
    {
        // Event declaration
        public event EventHandler UserLoginClick;
        public event EventHandler ToggleView;

        public UserLogin()
        {
            InitializeComponent();
            // Allows us to leave focus on fields, without validating and click elsewhere.
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }


        // User login button click event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // if all controls is validated , do stuff
            if (this.ValidateChildren() && UserLoginClick != null)
            {
                // Invoke the event
                UserLoginClick(this, e);
            }
        }

        // Called when visibility on this control i changed
        private void UserLogin_VisibleChanged(object sender, EventArgs e)
        {
            // Resets/Clears error labels and text boxes
            if (Visible && !Disposing)
            {
                //Utilities.ClearAllText(this);
                lblUsernameError.Text = "";
                lblPasswordError.Text = "";
                lblOutput.Text = "";
            }
        }

        // Link event; Toggle control visibility UserLogin <-> UserCreate
        private void lnkCreateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ToggleView != null)
            {
                // Invoke the event
                ToggleView(this, EventArgs.Empty);
            }
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
