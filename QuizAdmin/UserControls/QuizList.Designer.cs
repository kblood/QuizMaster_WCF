namespace QuizAdmin.UserControls
{
    partial class QuizList
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
            this.listBoxQuiz = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxQuiz
            // 
            this.listBoxQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQuiz.FormattingEnabled = true;
            this.listBoxQuiz.Location = new System.Drawing.Point(0, 0);
            this.listBoxQuiz.Name = "listBoxQuiz";
            this.listBoxQuiz.ScrollAlwaysVisible = true;
            this.listBoxQuiz.Size = new System.Drawing.Size(511, 477);
            this.listBoxQuiz.TabIndex = 4;
            this.listBoxQuiz.SelectedIndexChanged += new System.EventHandler(this.listBoxQuiz_SelectedIndexChanged);
            // 
            // QuizList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxQuiz);
            this.Name = "QuizList";
            this.Size = new System.Drawing.Size(511, 477);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxQuiz;
    }
}
