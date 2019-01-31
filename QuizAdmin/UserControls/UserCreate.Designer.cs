namespace QuizAdmin.UserControls
{
    partial class UserCreate
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
            this.PnlWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lnkLoginUser = new System.Windows.Forms.LinkLabel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.PnlWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlWrapper
            // 
            this.PnlWrapper.Controls.Add(this.lblHeader);
            this.PnlWrapper.Controls.Add(this.lblUsername);
            this.PnlWrapper.Controls.Add(this.txtUsername);
            this.PnlWrapper.Controls.Add(this.lblUsernameError);
            this.PnlWrapper.Controls.Add(this.lblPassword);
            this.PnlWrapper.Controls.Add(this.txtPassword);
            this.PnlWrapper.Controls.Add(this.lblPasswordError);
            this.PnlWrapper.Controls.Add(this.btnCreate);
            this.PnlWrapper.Controls.Add(this.lnkLoginUser);
            this.PnlWrapper.Controls.Add(this.lblOutput);
            this.PnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlWrapper.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PnlWrapper.Location = new System.Drawing.Point(0, 0);
            this.PnlWrapper.Name = "PnlWrapper";
            this.PnlWrapper.Size = new System.Drawing.Size(225, 223);
            this.PnlWrapper.TabIndex = 0;
            this.PnlWrapper.WrapContents = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0, 0, 3, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(151, 29);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "Opret bruger";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 39);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Brugernavn:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 60);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 20);
            this.txtUsername.TabIndex = 2;
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
            this.lblUsernameError.TabIndex = 10;
            this.lblUsernameError.Text = "*";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 105);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 126);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 12;
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
            this.lblPasswordError.TabIndex = 13;
            this.lblPasswordError.Text = "*";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(237)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(113, 174);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Opret";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lnkLoginUser
            // 
            this.lnkLoginUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLoginUser.AutoSize = true;
            this.lnkLoginUser.CausesValidation = false;
            this.lnkLoginUser.LinkColor = System.Drawing.Color.Black;
            this.lnkLoginUser.Location = new System.Drawing.Point(158, 205);
            this.lnkLoginUser.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.lnkLoginUser.Name = "lnkLoginUser";
            this.lnkLoginUser.Size = new System.Drawing.Size(33, 13);
            this.lnkLoginUser.TabIndex = 16;
            this.lnkLoginUser.TabStop = true;
            this.lnkLoginUser.Text = "Login";
            this.lnkLoginUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLoginUser_LinkClicked);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutput.Location = new System.Drawing.Point(3, 221);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(3);
            this.lblOutput.MaximumSize = new System.Drawing.Size(300, 40);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(185, 13);
            this.lblOutput.TabIndex = 15;
            this.lblOutput.Text = "... ";
            this.lblOutput.UseMnemonic = false;
            // 
            // UserCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlWrapper);
            this.Name = "UserCreate";
            this.Size = new System.Drawing.Size(225, 223);
            this.VisibleChanged += new System.EventHandler(this.UserCreate_VisibleChanged);
            this.PnlWrapper.ResumeLayout(false);
            this.PnlWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PnlWrapper;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.LinkLabel lnkLoginUser;
        private System.Windows.Forms.Label lblHeader;
    }
}
