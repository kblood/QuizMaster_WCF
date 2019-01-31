namespace QuizAdmin.UserViews
{
    partial class QuizStatisticsView
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
            this.statisticTable = new QuizAdmin.UserControls.StatisticTable();
            this.quizInstanceDetail2 = new QuizAdmin.UserControls.QuizInstanceDetail2();
            this.SuspendLayout();
            // 
            // statisticTable
            // 
            this.statisticTable.Location = new System.Drawing.Point(3, 3);
            this.statisticTable.Name = "statisticTable";
            this.statisticTable.Size = new System.Drawing.Size(460, 477);
            this.statisticTable.TabIndex = 0;
            // 
            // quizInstanceDetail21
            // 
            this.quizInstanceDetail2.Location = new System.Drawing.Point(470, 3);
            this.quizInstanceDetail2.Margin = new System.Windows.Forms.Padding(0);
            this.quizInstanceDetail2.Name = "quizInstanceDetail21";
            this.quizInstanceDetail2.Size = new System.Drawing.Size(205, 475);
            this.quizInstanceDetail2.TabIndex = 1;
            // 
            // QuizStatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quizInstanceDetail2);
            this.Controls.Add(this.statisticTable);
            this.Name = "QuizStatisticsView";
            this.Size = new System.Drawing.Size(675, 525);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.StatisticTable statisticTable;
        private UserControls.QuizInstanceDetail2 quizInstanceDetail2;
    }
}
