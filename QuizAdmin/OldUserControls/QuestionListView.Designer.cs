namespace QuizAdmin
{
    partial class QuestionListView
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
            this.lblQuestionInfo = new System.Windows.Forms.Label();
            this.listBoxQuestion = new System.Windows.Forms.ListBox();
            this.txtQuestionInfo = new System.Windows.Forms.RichTextBox();
            this.btbCreateQuestion = new System.Windows.Forms.Button();
            this.btnFindQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.QuestionTab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionInfo
            // 
            this.lblQuestionInfo.AllowDrop = true;
            this.lblQuestionInfo.AutoSize = true;
            this.lblQuestionInfo.Location = new System.Drawing.Point(3, 221);
            this.lblQuestionInfo.Name = "lblQuestionInfo";
            this.lblQuestionInfo.Size = new System.Drawing.Size(76, 13);
            this.lblQuestionInfo.TabIndex = 0;
            this.lblQuestionInfo.Text = "Spørgsmål info";
            // 
            // listBoxQuestion
            // 
            this.listBoxQuestion.FormattingEnabled = true;
            this.listBoxQuestion.Location = new System.Drawing.Point(82, 32);
            this.listBoxQuestion.Name = "listBoxQuestion";
            this.listBoxQuestion.ScrollAlwaysVisible = true;
            this.listBoxQuestion.Size = new System.Drawing.Size(137, 134);
            this.listBoxQuestion.TabIndex = 1;
            this.listBoxQuestion.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestion_SelectedIndexChanged);
            // 
            // txtQuestionInfo
            // 
            this.txtQuestionInfo.Location = new System.Drawing.Point(82, 182);
            this.txtQuestionInfo.Name = "txtQuestionInfo";
            this.txtQuestionInfo.Size = new System.Drawing.Size(137, 100);
            this.txtQuestionInfo.TabIndex = 2;
            this.txtQuestionInfo.Text = "";
            // 
            // btbCreateQuestion
            // 
            this.btbCreateQuestion.Location = new System.Drawing.Point(225, 53);
            this.btbCreateQuestion.Name = "btbCreateQuestion";
            this.btbCreateQuestion.Size = new System.Drawing.Size(99, 23);
            this.btbCreateQuestion.TabIndex = 3;
            this.btbCreateQuestion.Text = "Opret Spørgsmål";
            this.btbCreateQuestion.UseVisualStyleBackColor = true;
            this.btbCreateQuestion.Click += new System.EventHandler(this.btbCreateQuestion_Click);
            // 
            // btnFindQuestion
            // 
            this.btnFindQuestion.Location = new System.Drawing.Point(225, 24);
            this.btnFindQuestion.Name = "btnFindQuestion";
            this.btnFindQuestion.Size = new System.Drawing.Size(99, 23);
            this.btnFindQuestion.TabIndex = 4;
            this.btnFindQuestion.Text = "Find Spørgsmål";
            this.btnFindQuestion.UseVisualStyleBackColor = true;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(225, 82);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteQuestion.TabIndex = 5;
            this.btnDeleteQuestion.Text = "Slet Spørgsmål";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(129, 288);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(90, 23);
            this.btnEditQuestion.TabIndex = 8;
            this.btnEditQuestion.Text = "Rediger Spørgsmål";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Location = new System.Drawing.Point(347, 24);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(445, 444);
            this.pnlQuestion.TabIndex = 9;
            // 
            // QuestionTab
            // 
            this.QuestionTab.Location = new System.Drawing.Point(6, 3);
            this.QuestionTab.Name = "QuestionTab";
            this.QuestionTab.Size = new System.Drawing.Size(85, 23);
            this.QuestionTab.TabIndex = 11;
            this.QuestionTab.Text = "QuizTab";
            this.QuestionTab.UseVisualStyleBackColor = true;
            this.QuestionTab.Click += new System.EventHandler(this.QuestionTab_Click);
            // 
            // QuestionListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QuestionTab);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.btnFindQuestion);
            this.Controls.Add(this.btbCreateQuestion);
            this.Controls.Add(this.txtQuestionInfo);
            this.Controls.Add(this.listBoxQuestion);
            this.Controls.Add(this.lblQuestionInfo);
            this.Name = "QuestionListView";
            this.Size = new System.Drawing.Size(806, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionInfo;
        private System.Windows.Forms.ListBox listBoxQuestion;
        private System.Windows.Forms.RichTextBox txtQuestionInfo;
        private System.Windows.Forms.Button btbCreateQuestion;
        private System.Windows.Forms.Button btnFindQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Button QuestionTab;
    }
}
