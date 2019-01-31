namespace QuizAdmin.UserViews
{
    partial class QuizView
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblToggleHeader = new System.Windows.Forms.Label();
            this.pnlBtnDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.quizList = new QuizAdmin.UserControls.QuizList();
            this.quizDetail = new QuizAdmin.UserControls.QuizDetail();
            this.quizCreate = new QuizAdmin.UserControls.QuizCreate();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.pnlBtnDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(30, 10);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(95, 29);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Quizzer";
            // 
            // lblToggleHeader
            // 
            this.lblToggleHeader.AutoSize = true;
            this.lblToggleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleHeader.Location = new System.Drawing.Point(350, 15);
            this.lblToggleHeader.Name = "lblToggleHeader";
            this.lblToggleHeader.Size = new System.Drawing.Size(64, 20);
            this.lblToggleHeader.TabIndex = 2;
            this.lblToggleHeader.Text = "Detaljer";
            // 
            // pnlBtnDetail
            // 
            this.pnlBtnDetail.AutoSize = true;
            this.pnlBtnDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBtnDetail.Controls.Add(this.btnDelete);
            this.pnlBtnDetail.Controls.Add(this.btnStart);
            this.pnlBtnDetail.Controls.Add(this.btnQuestion);
            this.pnlBtnDetail.Location = new System.Drawing.Point(350, 241);
            this.pnlBtnDetail.Name = "pnlBtnDetail";
            this.pnlBtnDetail.Size = new System.Drawing.Size(243, 29);
            this.pnlBtnDetail.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Snow;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Slet";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(84, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuestion.BackColor = System.Drawing.Color.White;
            this.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnQuestion.Location = new System.Drawing.Point(165, 3);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion.TabIndex = 8;
            this.btnQuestion.Text = "Spørgsmål";
            this.btnQuestion.UseVisualStyleBackColor = false;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(237)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(350, 421);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Opret Quiz";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // quizList
            // 
            this.quizList.Location = new System.Drawing.Point(30, 50);
            this.quizList.Name = "quizList";
            this.quizList.Size = new System.Drawing.Size(290, 400);
            this.quizList.TabIndex = 0;
            // 
            // quizDetail
            // 
            this.quizDetail.Location = new System.Drawing.Point(350, 50);
            this.quizDetail.Margin = new System.Windows.Forms.Padding(0);
            this.quizDetail.Name = "quizDetail";
            this.quizDetail.Size = new System.Drawing.Size(290, 197);
            this.quizDetail.TabIndex = 3;
            // 
            // quizCreate
            // 
            this.quizCreate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.quizCreate.Location = new System.Drawing.Point(350, 50);
            this.quizCreate.Name = "quizCreate";
            this.quizCreate.Size = new System.Drawing.Size(290, 279);
            this.quizCreate.TabIndex = 10;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(350, 277);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.feedbackLabel.TabIndex = 11;
            // 
            // QuizView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlBtnDetail);
            this.Controls.Add(this.lblToggleHeader);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.quizList);
            this.Controls.Add(this.quizDetail);
            this.Controls.Add(this.quizCreate);
            this.Name = "QuizView";
            this.Size = new System.Drawing.Size(675, 525);
            this.VisibleChanged += new System.EventHandler(this.QuizView_VisibleChanged);
            this.pnlBtnDetail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.QuizList quizList;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblToggleHeader;
        private UserControls.QuizDetail quizDetail;
        private System.Windows.Forms.FlowLayoutPanel pnlBtnDetail;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnCreate;
        private UserControls.QuizCreate quizCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label feedbackLabel;
    }
}
