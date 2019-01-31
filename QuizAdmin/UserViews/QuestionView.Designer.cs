namespace QuizAdmin.UserViews
{
    partial class QuestionView
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.questionCreate = new QuizAdmin.UserControls.QuestionCreate();
            this.questionList = new QuizAdmin.UserControls.QuestionList();
            this.questionDetail = new QuizAdmin.UserControls.QuestionsDetails();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(30, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(130, 29);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Spørgsmål";
            // 
            // lblToggleHeader
            // 
            this.lblToggleHeader.AutoSize = true;
            this.lblToggleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleHeader.Location = new System.Drawing.Point(350, 15);
            this.lblToggleHeader.Name = "lblToggleHeader";
            this.lblToggleHeader.Size = new System.Drawing.Size(64, 20);
            this.lblToggleHeader.TabIndex = 3;
            this.lblToggleHeader.Text = "Detaljer";
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(237)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(350, 421);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Opret Spørgsmål";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // questionCreate
            // 
            this.questionCreate.AutoSize = true;
            this.questionCreate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.questionCreate.Location = new System.Drawing.Point(353, 50);
            this.questionCreate.Margin = new System.Windows.Forms.Padding(30);
            this.questionCreate.MaximumSize = new System.Drawing.Size(290, 700);
            this.questionCreate.MinimumSize = new System.Drawing.Size(290, 200);
            this.questionCreate.Name = "questionCreate";
            this.questionCreate.Size = new System.Drawing.Size(290, 246);
            this.questionCreate.TabIndex = 14;
            this.questionCreate.Visible = false;
            // 
            // questionList
            // 
            this.questionList.BackColor = System.Drawing.Color.White;
            this.questionList.Location = new System.Drawing.Point(30, 50);
            this.questionList.Name = "questionList";
            this.questionList.Size = new System.Drawing.Size(290, 400);
            this.questionList.TabIndex = 13;
            // 
            // questionDetail
            // 
            this.questionDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.questionDetail.Location = new System.Drawing.Point(350, 50);
            this.questionDetail.Margin = new System.Windows.Forms.Padding(0);
            this.questionDetail.Name = "questionDetail";
            this.questionDetail.Size = new System.Drawing.Size(290, 197);
            this.questionDetail.TabIndex = 4;
            // 
            // QuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionCreate);
            this.Controls.Add(this.questionList);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblToggleHeader);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.questionDetail);
            this.Name = "QuestionView";
            this.Size = new System.Drawing.Size(675, 525);
            this.VisibleChanged += new System.EventHandler(this.QuestionView_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblToggleHeader;
        private UserControls.QuestionsDetails questionDetail;
        private System.Windows.Forms.Button btnCreate;
        private UserControls.QuestionList questionList;
        private UserControls.QuestionCreate questionCreate;
    }
}
