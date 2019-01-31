namespace QuizAdmin.UserViews
{
    partial class UserView
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.userLogin = new QuizAdmin.UserControls.UserLogin();
            this.userCreate = new QuizAdmin.UserControls.UserCreate();
            this.pnlWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Controls.Add(this.userLogin);
            this.pnlWrapper.Controls.Add(this.userCreate);
            this.pnlWrapper.Location = new System.Drawing.Point(337, 168);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(248, 508);
            this.pnlWrapper.TabIndex = 0;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(357, 142);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(27, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "hest";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.Location = new System.Drawing.Point(241, 34);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(535, 108);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Quizmaster";
            // 
            // userLogin
            // 
            this.userLogin.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.userLogin.Location = new System.Drawing.Point(3, 3);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(225, 223);
            this.userLogin.TabIndex = 0;
            // 
            // userCreate
            // 
            this.userCreate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.userCreate.Location = new System.Drawing.Point(3, 232);
            this.userCreate.Name = "userCreate";
            this.userCreate.Size = new System.Drawing.Size(225, 223);
            this.userCreate.TabIndex = 1;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlWrapper);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblHeader);
            this.Name = "UserView";
            this.Size = new System.Drawing.Size(1184, 697);
            this.VisibleChanged += new System.EventHandler(this.UserView_VisibleChanged);
            this.pnlWrapper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlWrapper;
        private UserControls.UserLogin userLogin;
        private UserControls.UserCreate userCreate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblOutput;
    }
}
