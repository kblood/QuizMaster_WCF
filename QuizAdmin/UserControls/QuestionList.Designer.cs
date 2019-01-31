namespace QuizAdmin.UserControls
{
    partial class QuestionList
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
            this.listBoxQuestion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxQuestion
            // 
            this.listBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQuestion.FormattingEnabled = true;
            this.listBoxQuestion.Location = new System.Drawing.Point(0, 0);
            this.listBoxQuestion.Name = "listBoxQuestion";
            this.listBoxQuestion.ScrollAlwaysVisible = true;
            this.listBoxQuestion.Size = new System.Drawing.Size(511, 477);
            this.listBoxQuestion.TabIndex = 4;
            this.listBoxQuestion.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestion_SelectedIndexChanged);
            // 
            // QuestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listBoxQuestion);
            this.Name = "QuestionList";
            this.Size = new System.Drawing.Size(511, 477);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxQuestion;
    }
}
