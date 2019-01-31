namespace QuizAdmin
{
    partial class QuizMaster
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizMaster));
            this.pnlLoginWrapper = new System.Windows.Forms.Panel();
            this.userView = new QuizAdmin.UserViews.UserView();
            this.pnlMainWrapper = new System.Windows.Forms.Panel();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSidebarTable = new System.Windows.Forms.TableLayoutPanel();
            this.btnSidebarStatistics = new System.Windows.Forms.Button();
            this.btnSidebarActiveQuiz = new System.Windows.Forms.Button();
            this.btnSidebarQuestion = new System.Windows.Forms.Button();
            this.btnSidebarQuiz = new System.Windows.Forms.Button();
            this.pnlViewContainer = new System.Windows.Forms.Panel();
            this.quizStatisticsView = new QuizAdmin.UserViews.QuizStatisticsView();
            this.quizStatisticsListView = new QuizAdmin.UserViews.QuizStatisticsListView();
            this.questionView = new QuizAdmin.UserViews.QuestionView();
            this.quizView = new QuizAdmin.UserViews.QuizView();
            this.quizRunningView = new QuizAdmin.UserViews.QuizRunningView();
            this.quizQuestionView = new QuizAdmin.UserViews.QuizQuestionView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlLoginWrapper.SuspendLayout();
            this.pnlMainWrapper.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.pnlSidebarTable.SuspendLayout();
            this.pnlViewContainer.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginWrapper
            // 
            this.pnlLoginWrapper.AutoSize = true;
            this.pnlLoginWrapper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLoginWrapper.Controls.Add(this.userView);
            this.pnlLoginWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginWrapper.MinimumSize = new System.Drawing.Size(0, 100);
            this.pnlLoginWrapper.Name = "pnlLoginWrapper";
            this.pnlLoginWrapper.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLoginWrapper.Size = new System.Drawing.Size(1184, 697);
            this.pnlLoginWrapper.TabIndex = 2;
            // 
            // userView
            // 
            this.userView.BackColor = System.Drawing.SystemColors.Control;
            this.userView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userView.Location = new System.Drawing.Point(10, 10);
            this.userView.Margin = new System.Windows.Forms.Padding(4);
            this.userView.Name = "userView";
            this.userView.Size = new System.Drawing.Size(1164, 677);
            this.userView.TabIndex = 0;
            // 
            // pnlMainWrapper
            // 
            this.pnlMainWrapper.AutoSize = true;
            this.pnlMainWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainWrapper.Controls.Add(this.mainLayoutPanel);
            this.pnlMainWrapper.Controls.Add(this.pnlHeader);
            this.pnlMainWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnlMainWrapper.MaximumSize = new System.Drawing.Size(0, 800);
            this.pnlMainWrapper.Name = "pnlMainWrapper";
            this.pnlMainWrapper.Size = new System.Drawing.Size(1184, 697);
            this.pnlMainWrapper.TabIndex = 2;
            this.pnlMainWrapper.Visible = false;
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.BackColor = System.Drawing.Color.White;
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayoutPanel.Controls.Add(this.pnlSidebarTable, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.pnlViewContainer, 1, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 96);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 765F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 765F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 765F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(1184, 601);
            this.mainLayoutPanel.TabIndex = 3;
            // 
            // pnlSidebarTable
            // 
            this.pnlSidebarTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSidebarTable.AutoSize = true;
            this.pnlSidebarTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSidebarTable.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSidebarTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.pnlSidebarTable.ColumnCount = 1;
            this.pnlSidebarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlSidebarTable.Controls.Add(this.btnSidebarStatistics, 0, 2);
            this.pnlSidebarTable.Controls.Add(this.btnSidebarActiveQuiz, 0, 3);
            this.pnlSidebarTable.Controls.Add(this.btnSidebarQuestion, 0, 1);
            this.pnlSidebarTable.Controls.Add(this.btnSidebarQuiz, 0, 0);
            this.pnlSidebarTable.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarTable.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebarTable.Name = "pnlSidebarTable";
            this.pnlSidebarTable.RowCount = 5;
            this.pnlSidebarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.pnlSidebarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.pnlSidebarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.pnlSidebarTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSidebarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSidebarTable.Size = new System.Drawing.Size(267, 765);
            this.pnlSidebarTable.TabIndex = 0;
            // 
            // btnSidebarStatistics
            // 
            this.btnSidebarStatistics.CausesValidation = false;
            this.btnSidebarStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSidebarStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSidebarStatistics.FlatAppearance.BorderSize = 0;
            this.btnSidebarStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebarStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSidebarStatistics.Location = new System.Drawing.Point(3, 209);
            this.btnSidebarStatistics.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnSidebarStatistics.Name = "btnSidebarStatistics";
            this.btnSidebarStatistics.Size = new System.Drawing.Size(258, 100);
            this.btnSidebarStatistics.TabIndex = 7;
            this.btnSidebarStatistics.Text = "Kørte Quizzer";
            this.btnSidebarStatistics.UseVisualStyleBackColor = true;
            this.btnSidebarStatistics.Click += new System.EventHandler(this.btnSidebarStatistics_Click);
            // 
            // btnSidebarActiveQuiz
            // 
            this.btnSidebarActiveQuiz.CausesValidation = false;
            this.btnSidebarActiveQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSidebarActiveQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSidebarActiveQuiz.FlatAppearance.BorderSize = 0;
            this.btnSidebarActiveQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebarActiveQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSidebarActiveQuiz.Location = new System.Drawing.Point(3, 312);
            this.btnSidebarActiveQuiz.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnSidebarActiveQuiz.Name = "btnSidebarActiveQuiz";
            this.btnSidebarActiveQuiz.Size = new System.Drawing.Size(258, 100);
            this.btnSidebarActiveQuiz.TabIndex = 6;
            this.btnSidebarActiveQuiz.Text = "Aktiv Quiz";
            this.btnSidebarActiveQuiz.UseVisualStyleBackColor = true;
            this.btnSidebarActiveQuiz.Click += new System.EventHandler(this.btnSidebarActiveQuiz_Click);
            // 
            // btnSidebarQuestion
            // 
            this.btnSidebarQuestion.CausesValidation = false;
            this.btnSidebarQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSidebarQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSidebarQuestion.FlatAppearance.BorderSize = 0;
            this.btnSidebarQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebarQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSidebarQuestion.Location = new System.Drawing.Point(3, 106);
            this.btnSidebarQuestion.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnSidebarQuestion.Name = "btnSidebarQuestion";
            this.btnSidebarQuestion.Size = new System.Drawing.Size(258, 100);
            this.btnSidebarQuestion.TabIndex = 4;
            this.btnSidebarQuestion.Text = "Spørgsmål";
            this.btnSidebarQuestion.UseVisualStyleBackColor = true;
            this.btnSidebarQuestion.Click += new System.EventHandler(this.btnSidebarQuestion_Click);
            // 
            // btnSidebarQuiz
            // 
            this.btnSidebarQuiz.CausesValidation = false;
            this.btnSidebarQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSidebarQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSidebarQuiz.FlatAppearance.BorderSize = 0;
            this.btnSidebarQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebarQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSidebarQuiz.Location = new System.Drawing.Point(3, 3);
            this.btnSidebarQuiz.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnSidebarQuiz.Name = "btnSidebarQuiz";
            this.btnSidebarQuiz.Size = new System.Drawing.Size(258, 100);
            this.btnSidebarQuiz.TabIndex = 3;
            this.btnSidebarQuiz.Text = "Quizzer";
            this.btnSidebarQuiz.UseVisualStyleBackColor = true;
            this.btnSidebarQuiz.Click += new System.EventHandler(this.btnSidebarQuiz_Click);
            // 
            // pnlViewContainer
            // 
            this.pnlViewContainer.AutoSize = true;
            this.pnlViewContainer.Controls.Add(this.quizStatisticsView);
            this.pnlViewContainer.Controls.Add(this.quizStatisticsListView);
            this.pnlViewContainer.Controls.Add(this.questionView);
            this.pnlViewContainer.Controls.Add(this.quizView);
            this.pnlViewContainer.Controls.Add(this.quizRunningView);
            this.pnlViewContainer.Controls.Add(this.quizQuestionView);
            this.pnlViewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewContainer.Location = new System.Drawing.Point(267, 0);
            this.pnlViewContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlViewContainer.Name = "pnlViewContainer";
            this.pnlViewContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pnlViewContainer.Size = new System.Drawing.Size(917, 765);
            this.pnlViewContainer.TabIndex = 1;
            // 
            // quizStatisticsView
            // 
            this.quizStatisticsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizStatisticsView.Location = new System.Drawing.Point(10, 10);
            this.quizStatisticsView.Margin = new System.Windows.Forms.Padding(4);
            this.quizStatisticsView.Name = "quizStatisticsView";
            this.quizStatisticsView.Size = new System.Drawing.Size(897, 745);
            this.quizStatisticsView.TabIndex = 5;
            this.quizStatisticsView.Visible = false;
            // 
            // quizStatisticsListView
            // 
            this.quizStatisticsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizStatisticsListView.Location = new System.Drawing.Point(10, 10);
            this.quizStatisticsListView.Margin = new System.Windows.Forms.Padding(4);
            this.quizStatisticsListView.Name = "quizStatisticsListView";
            this.quizStatisticsListView.Size = new System.Drawing.Size(897, 745);
            this.quizStatisticsListView.TabIndex = 4;
            this.quizStatisticsListView.Visible = false;
            // 
            // questionView
            // 
            this.questionView.AutoSize = true;
            this.questionView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.questionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionView.Location = new System.Drawing.Point(10, 10);
            this.questionView.Margin = new System.Windows.Forms.Padding(4);
            this.questionView.Name = "questionView";
            this.questionView.Size = new System.Drawing.Size(897, 745);
            this.questionView.TabIndex = 1;
            this.questionView.Visible = false;
            // 
            // quizView
            // 
            this.quizView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizView.Location = new System.Drawing.Point(10, 10);
            this.quizView.Margin = new System.Windows.Forms.Padding(4);
            this.quizView.Name = "quizView";
            this.quizView.Size = new System.Drawing.Size(897, 745);
            this.quizView.TabIndex = 0;
            // 
            // quizRunningView
            // 
            this.quizRunningView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizRunningView.Location = new System.Drawing.Point(10, 10);
            this.quizRunningView.Margin = new System.Windows.Forms.Padding(4);
            this.quizRunningView.Name = "quizRunningView";
            this.quizRunningView.Size = new System.Drawing.Size(897, 745);
            this.quizRunningView.TabIndex = 3;
            this.quizRunningView.Visible = false;
            // 
            // quizQuestionView
            // 
            this.quizQuestionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizQuestionView.Location = new System.Drawing.Point(10, 10);
            this.quizQuestionView.Margin = new System.Windows.Forms.Padding(4);
            this.quizQuestionView.Name = "quizQuestionView";
            this.quizQuestionView.Size = new System.Drawing.Size(897, 745);
            this.quizQuestionView.TabIndex = 2;
            this.quizQuestionView.Visible = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.CausesValidation = false;
            this.pnlHeader.Controls.Add(this.lblUsername);
            this.pnlHeader.Controls.Add(this.linkLogout);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 96);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(959, 22);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblUsername.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(200, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "brugernavn";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLogout
            // 
            this.linkLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLogout.AutoSize = true;
            this.linkLogout.LinkColor = System.Drawing.Color.DarkOrange;
            this.linkLogout.Location = new System.Drawing.Point(959, 48);
            this.linkLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLogout.MinimumSize = new System.Drawing.Size(200, 0);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLogout.Size = new System.Drawing.Size(200, 16);
            this.linkLogout.TabIndex = 1;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Log ud";
            this.linkLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUserLoguot_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(30, 31);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(166, 33);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Quizmaster";
            // 
            // QuizMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 697);
            this.Controls.Add(this.pnlMainWrapper);
            this.Controls.Add(this.pnlLoginWrapper);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuizMaster";
            this.Text = "QuizMaster";
            this.pnlLoginWrapper.ResumeLayout(false);
            this.pnlMainWrapper.ResumeLayout(false);
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.pnlSidebarTable.ResumeLayout(false);
            this.pnlViewContainer.ResumeLayout(false);
            this.pnlViewContainer.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginWrapper;
        private System.Windows.Forms.Panel pnlMainWrapper;
        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel pnlSidebarTable;
        private System.Windows.Forms.Button btnSidebarQuestion;
        private System.Windows.Forms.Button btnSidebarQuiz;
        private System.Windows.Forms.Panel pnlViewContainer;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.Label lblHeader;
        private UserViews.UserView userView;
        private UserViews.QuizView quizView;
        private UserViews.QuestionView questionView;
        private UserViews.QuizQuestionView quizQuestionView;
        private UserViews.QuizRunningView quizRunningView;
        private System.Windows.Forms.Button btnSidebarActiveQuiz;
        private System.Windows.Forms.Button btnSidebarStatistics;
        private UserViews.QuizStatisticsListView quizStatisticsListView;
        private UserViews.QuizStatisticsView quizStatisticsView;
    }
}