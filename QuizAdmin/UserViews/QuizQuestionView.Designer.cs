namespace QuizAdmin.UserViews
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
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddRemoveBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreateQuestion = new System.Windows.Forms.Button();
            this.questionCreate = new QuizAdmin.UserControls.QuestionCreate();
            this.questionsDetails = new QuizAdmin.UserControls.QuestionsDetails();
            this.questionQuizList = new QuizAdmin.UserControls.QuestionList();
            this.questionAllList = new QuizAdmin.UserControls.QuestionList();
            this.quizDetail = new QuizAdmin.UserControls.QuizDetail();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlAddRemoveBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.Location = new System.Drawing.Point(170, 15);
            this.lblSubHeader.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(164, 18);
            this.lblSubHeader.TabIndex = 4;
            this.lblSubHeader.Text = "Tilgængelige spørgsmål";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valgte spørgsmål";
            // 
            // pnlAddRemoveBtn
            // 
            this.pnlAddRemoveBtn.Controls.Add(this.btnRemove);
            this.pnlAddRemoveBtn.Controls.Add(this.btnAdd);
            this.pnlAddRemoveBtn.Location = new System.Drawing.Point(358, 220);
            this.pnlAddRemoveBtn.Name = "pnlAddRemoveBtn";
            this.pnlAddRemoveBtn.Size = new System.Drawing.Size(88, 87);
            this.pnlAddRemoveBtn.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(3, 3);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(79, 31);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "←";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "→";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCreateQuestion
            // 
            this.btnCreateQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(237)))));
            this.btnCreateQuestion.FlatAppearance.BorderSize = 0;
            this.btnCreateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQuestion.ForeColor = System.Drawing.Color.White;
            this.btnCreateQuestion.Location = new System.Drawing.Point(480, 424);
            this.btnCreateQuestion.Name = "btnCreateQuestion";
            this.btnCreateQuestion.Size = new System.Drawing.Size(160, 23);
            this.btnCreateQuestion.TabIndex = 7;
            this.btnCreateQuestion.Text = "Opret Spørgsmål";
            this.btnCreateQuestion.UseVisualStyleBackColor = false;
            this.btnCreateQuestion.Click += new System.EventHandler(this.btnCreateQuestion_Click);
            // 
            // questionCreate
            // 
            this.questionCreate.AutoSize = true;
            this.questionCreate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.questionCreate.Location = new System.Drawing.Point(170, 50);
            this.questionCreate.Margin = new System.Windows.Forms.Padding(30);
            this.questionCreate.MaximumSize = new System.Drawing.Size(0, 700);
            this.questionCreate.Name = "questionCreate";
            this.questionCreate.Size = new System.Drawing.Size(292, 240);
            this.questionCreate.TabIndex = 8;
            this.questionCreate.Visible = false;
            // 
            // questionsDetails
            // 
            this.questionsDetails.Location = new System.Drawing.Point(340, 50);
            this.questionsDetails.Margin = new System.Windows.Forms.Padding(0);
            this.questionsDetails.Name = "questionsDetails";
            this.questionsDetails.Size = new System.Drawing.Size(130, 178);
            this.questionsDetails.TabIndex = 3;
            // 
            // questionQuizList
            // 
            this.questionQuizList.BackColor = System.Drawing.Color.White;
            this.questionQuizList.Location = new System.Drawing.Point(480, 50);
            this.questionQuizList.Name = "questionQuizList";
            this.questionQuizList.Size = new System.Drawing.Size(160, 360);
            this.questionQuizList.TabIndex = 2;
            // 
            // questionAllList
            // 
            this.questionAllList.BackColor = System.Drawing.Color.White;
            this.questionAllList.Location = new System.Drawing.Point(170, 50);
            this.questionAllList.Name = "questionAllList";
            this.questionAllList.Size = new System.Drawing.Size(160, 400);
            this.questionAllList.TabIndex = 1;
            // 
            // quizDetail
            // 
            this.quizDetail.Location = new System.Drawing.Point(30, 50);
            this.quizDetail.Margin = new System.Windows.Forms.Padding(0);
            this.quizDetail.Name = "quizDetail";
            this.quizDetail.Size = new System.Drawing.Size(130, 273);
            this.quizDetail.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(30, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(62, 29);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Quiz";
            // 
            // QuizQuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnCreateQuestion);
            this.Controls.Add(this.pnlAddRemoveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.questionsDetails);
            this.Controls.Add(this.questionQuizList);
            this.Controls.Add(this.questionAllList);
            this.Controls.Add(this.quizDetail);
            this.Controls.Add(this.questionCreate);
            this.Name = "QuizQuestionView";
            this.Size = new System.Drawing.Size(675, 525);
            this.pnlAddRemoveBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.QuizDetail quizDetail;
        private UserControls.QuestionList questionAllList;
        private UserControls.QuestionList questionQuizList;
        private UserControls.QuestionsDetails questionsDetails;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlAddRemoveBtn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCreateQuestion;
        private UserControls.QuestionCreate questionCreate;
        private System.Windows.Forms.Label lblHeader;
    }
}
