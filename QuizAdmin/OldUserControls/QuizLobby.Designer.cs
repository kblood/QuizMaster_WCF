namespace QuizAdmin
{
    partial class QuizLobby
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
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnCloseQuiz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuizInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Location = new System.Drawing.Point(486, 372);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnStartQuiz.TabIndex = 0;
            this.btnStartQuiz.Text = "Start quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // btnCloseQuiz
            // 
            this.btnCloseQuiz.Location = new System.Drawing.Point(405, 372);
            this.btnCloseQuiz.Name = "btnCloseQuiz";
            this.btnCloseQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnCloseQuiz.TabIndex = 1;
            this.btnCloseQuiz.Text = "Anuller";
            this.btnCloseQuiz.UseVisualStyleBackColor = true;
            this.btnCloseQuiz.Click += new System.EventHandler(this.btnCloseQuiz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quiz lobby";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quiz:";
            // 
            // txtQuizInfo
            // 
            this.txtQuizInfo.Location = new System.Drawing.Point(63, 51);
            this.txtQuizInfo.Name = "txtQuizInfo";
            this.txtQuizInfo.ReadOnly = true;
            this.txtQuizInfo.Size = new System.Drawing.Size(229, 20);
            this.txtQuizInfo.TabIndex = 4;
            // 
            // QuizLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQuizInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseQuiz);
            this.Controls.Add(this.btnStartQuiz);
            this.Name = "QuizLobby";
            this.Size = new System.Drawing.Size(599, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnCloseQuiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuizInfo;
    }
}
