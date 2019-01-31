namespace QuizAdmin
{
    partial class QuizQuestionView
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
            this.listBoxQuestionsOnQuiz = new System.Windows.Forms.ListBox();
            this.listBoxQuestionsNotOnQuiz = new System.Windows.Forms.ListBox();
            this.quizTitleLabel = new System.Windows.Forms.Label();
            this.getAllButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.viewLabel = new System.Windows.Forms.Label();
            this.btnUpdateQuestion = new System.Windows.Forms.Button();
            this.btnCreateQuestion = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxQuestionsOnQuiz
            // 
            this.listBoxQuestionsOnQuiz.FormattingEnabled = true;
            this.listBoxQuestionsOnQuiz.Location = new System.Drawing.Point(306, 78);
            this.listBoxQuestionsOnQuiz.Name = "listBoxQuestionsOnQuiz";
            this.listBoxQuestionsOnQuiz.ScrollAlwaysVisible = true;
            this.listBoxQuestionsOnQuiz.Size = new System.Drawing.Size(165, 238);
            this.listBoxQuestionsOnQuiz.TabIndex = 2;
            this.listBoxQuestionsOnQuiz.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestionsOnQuiz_SelectedIndexChanged);
            // 
            // listBoxQuestionsNotOnQuiz
            // 
            this.listBoxQuestionsNotOnQuiz.FormattingEnabled = true;
            this.listBoxQuestionsNotOnQuiz.Location = new System.Drawing.Point(31, 78);
            this.listBoxQuestionsNotOnQuiz.Name = "listBoxQuestionsNotOnQuiz";
            this.listBoxQuestionsNotOnQuiz.ScrollAlwaysVisible = true;
            this.listBoxQuestionsNotOnQuiz.Size = new System.Drawing.Size(165, 238);
            this.listBoxQuestionsNotOnQuiz.TabIndex = 3;
            this.listBoxQuestionsNotOnQuiz.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestionsNotOnQuiz_SelectedIndexChanged);
            // 
            // quizTitleLabel
            // 
            this.quizTitleLabel.AutoSize = true;
            this.quizTitleLabel.Location = new System.Drawing.Point(303, 52);
            this.quizTitleLabel.Name = "quizTitleLabel";
            this.quizTitleLabel.Size = new System.Drawing.Size(51, 13);
            this.quizTitleLabel.TabIndex = 4;
            this.quizTitleLabel.Text = "Quiz Titel";
            // 
            // getAllButton
            // 
            this.getAllButton.Location = new System.Drawing.Point(31, 47);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(60, 23);
            this.getAllButton.TabIndex = 5;
            this.getAllButton.Text = "Alle";
            this.getAllButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(97, 47);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(60, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Søg";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(214, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "--->";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(214, 138);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "<---";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Location = new System.Drawing.Point(194, 14);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(119, 13);
            this.viewLabel.TabIndex = 9;
            this.viewLabel.Text = "Quiz: Spørgsmåls admin";
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.Location = new System.Drawing.Point(214, 293);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateQuestion.TabIndex = 10;
            this.btnUpdateQuestion.Text = "Rediger";
            this.btnUpdateQuestion.UseVisualStyleBackColor = true;
            // 
            // btnCreateQuestion
            // 
            this.btnCreateQuestion.Location = new System.Drawing.Point(214, 264);
            this.btnCreateQuestion.Name = "btnCreateQuestion";
            this.btnCreateQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnCreateQuestion.TabIndex = 11;
            this.btnCreateQuestion.Text = "Opret";
            this.btnCreateQuestion.UseVisualStyleBackColor = true;
            this.btnCreateQuestion.Click += new System.EventHandler(this.btnCreateQuestion_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(396, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Afslut";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // QuizQuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreateQuestion);
            this.Controls.Add(this.btnUpdateQuestion);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.getAllButton);
            this.Controls.Add(this.quizTitleLabel);
            this.Controls.Add(this.listBoxQuestionsNotOnQuiz);
            this.Controls.Add(this.listBoxQuestionsOnQuiz);
            this.Name = "QuizQuestionView";
            this.Size = new System.Drawing.Size(516, 392);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxQuestionsOnQuiz;
        private System.Windows.Forms.ListBox listBoxQuestionsNotOnQuiz;
        private System.Windows.Forms.Label quizTitleLabel;
        private System.Windows.Forms.Button getAllButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.Button btnUpdateQuestion;
        private System.Windows.Forms.Button btnCreateQuestion;
        private System.Windows.Forms.Button btnClose;
    }
}
