namespace QuizAdmin.UserViews
{
    partial class QuizStatisticsListView
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
            this.btnStatistics = new System.Windows.Forms.Button();
            this.quizInstanceList = new QuizAdmin.UserControls.QuizInstanceList();
            this.quizInstanceDetail = new QuizAdmin.UserControls.QuizInstanceDetail();
            this.quizCreate = new QuizAdmin.UserControls.QuizCreate();
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
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(237)))));
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Location = new System.Drawing.Point(350, 421);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(159, 23);
            this.btnStatistics.TabIndex = 9;
            this.btnStatistics.Text = "Se Statistik";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // quizInstanceList
            // 
            this.quizInstanceList.Location = new System.Drawing.Point(30, 50);
            this.quizInstanceList.Name = "quizInstanceList";
            this.quizInstanceList.Size = new System.Drawing.Size(290, 400);
            this.quizInstanceList.TabIndex = 0;
            // 
            // quizInstanceDetail
            // 
            this.quizInstanceDetail.Location = new System.Drawing.Point(350, 50);
            this.quizInstanceDetail.Margin = new System.Windows.Forms.Padding(0);
            this.quizInstanceDetail.Name = "quizInstanceDetail";
            this.quizInstanceDetail.Size = new System.Drawing.Size(290, 197);
            this.quizInstanceDetail.TabIndex = 3;
            // 
            // quizCreate
            // 
            this.quizCreate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.quizCreate.Location = new System.Drawing.Point(350, 50);
            this.quizCreate.Name = "quizCreate";
            this.quizCreate.Size = new System.Drawing.Size(290, 279);
            this.quizCreate.TabIndex = 10;
            // 
            // QuizStatisticsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.lblToggleHeader);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.quizInstanceList);
            this.Controls.Add(this.quizInstanceDetail);
            this.Controls.Add(this.quizCreate);
            this.Name = "QuizStatisticsListView";
            this.Size = new System.Drawing.Size(675, 525);
            this.VisibleChanged += new System.EventHandler(this.QuizView_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.QuizInstanceList quizInstanceList;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblToggleHeader;
        private UserControls.QuizInstanceDetail quizInstanceDetail;
        private System.Windows.Forms.Button btnStatistics;
        private UserControls.QuizCreate quizCreate;
    }
}
