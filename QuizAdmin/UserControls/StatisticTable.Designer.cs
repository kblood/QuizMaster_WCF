using QuizAdmin.QuizMasterService;
using System.Windows.Forms;
using System;

namespace QuizAdmin.UserControls
{
    partial class StatisticTable
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
            this.questionContestantStats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.questionContestantStats)).BeginInit();
            this.SuspendLayout();
            // 
            // questionContestantStats
            // 
            this.questionContestantStats.AllowUserToAddRows = false;
            this.questionContestantStats.AllowUserToDeleteRows = false;
            this.questionContestantStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionContestantStats.Location = new System.Drawing.Point(0, 0);
            this.questionContestantStats.Name = "questionContestantStats";
            this.questionContestantStats.ReadOnly = true;
            this.questionContestantStats.Size = new System.Drawing.Size(460, 477);
            this.questionContestantStats.TabIndex = 0;
            // 
            // StatisticTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionContestantStats);
            this.Name = "StatisticTable";
            this.Size = new System.Drawing.Size(460, 477);
            ((System.ComponentModel.ISupportInitialize)(this.questionContestantStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView questionContestantStats;
    }
}
