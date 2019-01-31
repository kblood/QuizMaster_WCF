namespace QuizAdmin.UserControls
{
    partial class UserLogin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkCreateUser = new System.Windows.Forms.LinkLabel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pnlWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWrapper.AutoSize = true;
            this.pnlWrapper.Controls.Add(this.lblHeader);
            this.pnlWrapper.Controls.Add(this.lblUsername);
            this.pnlWrapper.Controls.Add(this.txtUsername);
            this.pnlWrapper.Controls.Add(this.lblUsernameError);
            this.pnlWrapper.Controls.Add(this.lblPassword);
            this.pnlWrapper.Controls.Add(this.txtPassword);
            this.pnlWrapper.Controls.Add(this.lblPasswordError);
            this.pnlWrapper.Controls.Add(this.btnLogin);
            this.pnlWrapper.Controls.Add(this.lnkCreateUser);
            this.pnlWrapper.Controls.Add(this.lblOutput);
            this.pnlWrapper.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(231, 237);
            this.pnlWrapper.TabIndex = 0;
            this.pnlWrapper.WrapContents = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0, 0, 3, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(73, 29);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "Login";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 39);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Brugernavn:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 60);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Knud";
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            this.txtUsername.Validated += new System.EventHandler(this.txtUsername_Validated);
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblUsernameError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUsernameError.Location = new System.Drawing.Point(6, 83);
            this.lblUsernameError.Margin = new System.Windows.Forms.Padding(6, 0, 3, 10);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(9, 12);
            this.lblUsernameError.TabIndex = 9;
            this.lblUsernameError.Text = "*";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 105);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 126);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "1234";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPasswordError.Location = new System.Drawing.Point(6, 149);
            this.lblPasswordError.Margin = new System.Windows.Forms.Padding(6, 0, 3, 10);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(9, 12);
            this.lblPasswordError.TabIndex = 10;
            this.lblPasswordError.Text = "*";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(237)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(113, 174);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkCreateUser
            // 
            this.lnkCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCreateUser.AutoSize = true;
            this.lnkCreateUser.CausesValidation = false;
            this.lnkCreateUser.LinkColor = System.Drawing.Color.Black;
            this.lnkCreateUser.Location = new System.Drawing.Point(125, 205);
            this.lnkCreateUser.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.lnkCreateUser.Name = "lnkCreateUser";
            this.lnkCreateUser.Size = new System.Drawing.Size(66, 13);
            this.lnkCreateUser.TabIndex = 7;
            this.lnkCreateUser.TabStop = true;
            this.lnkCreateUser.Text = "Opret bruger";
            this.lnkCreateUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreateUser_LinkClicked);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(3, 221);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(3);
            this.lblOutput.MaximumSize = new System.Drawing.Size(300, 40);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(19, 13);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "... ";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlWrapper);
            this.Name = "UserLogin";
            this.Size = new System.Drawing.Size(231, 225);
            this.VisibleChanged += new System.EventHandler(this.UserLogin_VisibleChanged);
            this.pnlWrapper.ResumeLayout(false);
            this.pnlWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlWrapper;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkCreateUser;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblHeader;
    }
}
