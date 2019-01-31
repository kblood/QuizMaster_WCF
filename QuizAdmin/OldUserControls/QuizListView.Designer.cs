namespace QuizAdmin
{
    partial class QuizListView
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
            this.lblQuizInfo = new System.Windows.Forms.Label();
            this.listBoxQuiz = new System.Windows.Forms.ListBox();
            this.txtQuizInfo = new System.Windows.Forms.RichTextBox();
            this.btbCreateQuiz = new System.Windows.Forms.Button();
            this.btnFindQuiz = new System.Windows.Forms.Button();
            this.btnDeleteQuiz = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEditQuiz = new System.Windows.Forms.Button();
            this.QuestionTab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuizInfo
            // 
            this.lblQuizInfo.AllowDrop = true;
            this.lblQuizInfo.AutoSize = true;
            this.lblQuizInfo.Location = new System.Drawing.Point(15, 221);
            this.lblQuizInfo.Name = "lblQuizInfo";
            this.lblQuizInfo.Size = new System.Drawing.Size(46, 13);
            this.lblQuizInfo.TabIndex = 0;
            this.lblQuizInfo.Text = "QuizInfo";
            // 
            // listBoxQuiz
            // 
            this.listBoxQuiz.FormattingEnabled = true;
            this.listBoxQuiz.Location = new System.Drawing.Point(82, 32);
            this.listBoxQuiz.Name = "listBoxQuiz";
            this.listBoxQuiz.ScrollAlwaysVisible = true;
            this.listBoxQuiz.Size = new System.Drawing.Size(137, 134);
            this.listBoxQuiz.TabIndex = 1;
            this.listBoxQuiz.SelectedIndexChanged += new System.EventHandler(this.listBoxQuiz_SelectedIndexChanged);
            // 
            // txtQuizInfo
            // 
            this.txtQuizInfo.Location = new System.Drawing.Point(82, 182);
            this.txtQuizInfo.Name = "txtQuizInfo";
            this.txtQuizInfo.Size = new System.Drawing.Size(137, 100);
            this.txtQuizInfo.TabIndex = 2;
            this.txtQuizInfo.Text = "";
            // 
            // btbCreateQuiz
            // 
            this.btbCreateQuiz.Location = new System.Drawing.Point(249, 24);
            this.btbCreateQuiz.Name = "btbCreateQuiz";
            this.btbCreateQuiz.Size = new System.Drawing.Size(75, 23);
            this.btbCreateQuiz.TabIndex = 3;
            this.btbCreateQuiz.Text = "Opret Quiz";
            this.btbCreateQuiz.UseVisualStyleBackColor = true;
            this.btbCreateQuiz.Click += new System.EventHandler(this.btbCreateQuiz_Click);
            // 
            // btnFindQuiz
            // 
            this.btnFindQuiz.Location = new System.Drawing.Point(249, 53);
            this.btnFindQuiz.Name = "btnFindQuiz";
            this.btnFindQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnFindQuiz.TabIndex = 4;
            this.btnFindQuiz.Text = "Find Quiz";
            this.btnFindQuiz.UseVisualStyleBackColor = true;
            // 
            // btnDeleteQuiz
            // 
            this.btnDeleteQuiz.Location = new System.Drawing.Point(249, 82);
            this.btnDeleteQuiz.Name = "btnDeleteQuiz";
            this.btnDeleteQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteQuiz.TabIndex = 5;
            this.btnDeleteQuiz.Text = "Slet Quiz";
            this.btnDeleteQuiz.UseVisualStyleBackColor = true;
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(249, 135);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion.TabIndex = 6;
            this.btnQuestion.Text = "Spørgsmål";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(249, 213);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEditQuiz
            // 
            this.btnEditQuiz.Location = new System.Drawing.Point(129, 288);
            this.btnEditQuiz.Name = "btnEditQuiz";
            this.btnEditQuiz.Size = new System.Drawing.Size(90, 23);
            this.btnEditQuiz.TabIndex = 8;
            this.btnEditQuiz.Text = "Rediger Quiz";
            this.btnEditQuiz.UseVisualStyleBackColor = true;
            // 
            // QuestionTab
            // 
            this.QuestionTab.Location = new System.Drawing.Point(3, 3);
            this.QuestionTab.Name = "QuestionTab";
            this.QuestionTab.Size = new System.Drawing.Size(85, 23);
            this.QuestionTab.TabIndex = 10;
            this.QuestionTab.Text = "SpørgsmålTab";
            this.QuestionTab.UseVisualStyleBackColor = true;
            this.QuestionTab.Click += new System.EventHandler(this.QuestionTab_Click);
            // 
            // QuizListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QuestionTab);
            this.Controls.Add(this.btnEditQuiz);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.btnDeleteQuiz);
            this.Controls.Add(this.btnFindQuiz);
            this.Controls.Add(this.btbCreateQuiz);
            this.Controls.Add(this.txtQuizInfo);
            this.Controls.Add(this.listBoxQuiz);
            this.Controls.Add(this.lblQuizInfo);
            this.Name = "QuizListView";
            this.Size = new System.Drawing.Size(329, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuizInfo;
        private System.Windows.Forms.ListBox listBoxQuiz;
        private System.Windows.Forms.RichTextBox txtQuizInfo;
        private System.Windows.Forms.Button btbCreateQuiz;
        private System.Windows.Forms.Button btnFindQuiz;
        private System.Windows.Forms.Button btnDeleteQuiz;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEditQuiz;
        private System.Windows.Forms.Button QuestionTab;
    }
}
