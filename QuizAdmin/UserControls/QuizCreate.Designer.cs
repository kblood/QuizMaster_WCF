namespace QuizAdmin.UserControls
{
    partial class QuizCreate
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
            this.lblQuizTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitleError = new System.Windows.Forms.Label();
            this.lblQuizDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescriptionError = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pnlWrapper.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Controls.Add(this.lblQuizTitle);
            this.pnlWrapper.Controls.Add(this.txtTitle);
            this.pnlWrapper.Controls.Add(this.lblTitleError);
            this.pnlWrapper.Controls.Add(this.lblQuizDescription);
            this.pnlWrapper.Controls.Add(this.txtDescription);
            this.pnlWrapper.Controls.Add(this.lblDescriptionError);
            this.pnlWrapper.Controls.Add(this.flowLayoutPanel1);
            this.pnlWrapper.Controls.Add(this.lblOutput);
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapper.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(290, 279);
            this.pnlWrapper.TabIndex = 0;
            this.pnlWrapper.WrapContents = false;
            // 
            // lblQuizTitle
            // 
            this.lblQuizTitle.AutoSize = true;
            this.lblQuizTitle.Location = new System.Drawing.Point(0, 0);
            this.lblQuizTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 5);
            this.lblQuizTitle.Name = "lblQuizTitle";
            this.lblQuizTitle.Size = new System.Drawing.Size(27, 13);
            this.lblQuizTitle.TabIndex = 0;
            this.lblQuizTitle.Text = "Titel";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(3, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(284, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            this.txtTitle.Validated += new System.EventHandler(this.txtTitle_Validated);
            // 
            // lblTitleError
            // 
            this.lblTitleError.AutoSize = true;
            this.lblTitleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitleError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitleError.Location = new System.Drawing.Point(3, 44);
            this.lblTitleError.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblTitleError.Name = "lblTitleError";
            this.lblTitleError.Size = new System.Drawing.Size(9, 12);
            this.lblTitleError.TabIndex = 11;
            this.lblTitleError.Text = "*";
            // 
            // lblQuizDescription
            // 
            this.lblQuizDescription.AutoSize = true;
            this.lblQuizDescription.Location = new System.Drawing.Point(0, 66);
            this.lblQuizDescription.Margin = new System.Windows.Forms.Padding(0, 0, 3, 5);
            this.lblQuizDescription.Name = "lblQuizDescription";
            this.lblQuizDescription.Size = new System.Drawing.Size(61, 13);
            this.lblQuizDescription.TabIndex = 12;
            this.lblQuizDescription.Text = "Beskrivelse";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(3, 87);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(284, 53);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.Text = "Not a RichText Box anymore";
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            this.txtDescription.Validated += new System.EventHandler(this.txtDescription_Validated);
            // 
            // lblDescriptionError
            // 
            this.lblDescriptionError.AutoSize = true;
            this.lblDescriptionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDescriptionError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDescriptionError.Location = new System.Drawing.Point(3, 143);
            this.lblDescriptionError.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblDescriptionError.Name = "lblDescriptionError";
            this.lblDescriptionError.Size = new System.Drawing.Size(9, 12);
            this.lblDescriptionError.TabIndex = 17;
            this.lblDescriptionError.Text = "*";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnCreate);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 168);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 36);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(237)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(84, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Opret";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(3, 210);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(3);
            this.lblOutput.MaximumSize = new System.Drawing.Size(300, 40);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(16, 13);
            this.lblOutput.TabIndex = 16;
            this.lblOutput.Text = "...";
            // 
            // QuizCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlWrapper);
            this.Name = "QuizCreate";
            this.Size = new System.Drawing.Size(290, 279);
            this.VisibleChanged += new System.EventHandler(this.QuizCreate_VisibleChanged);
            this.pnlWrapper.ResumeLayout(false);
            this.pnlWrapper.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlWrapper;
        private System.Windows.Forms.Label lblQuizTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitleError;
        private System.Windows.Forms.Label lblQuizDescription;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblDescriptionError;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
    }
}
