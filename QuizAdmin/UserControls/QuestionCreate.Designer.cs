namespace QuizAdmin.UserControls
{
    partial class QuestionCreate
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
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this._Header = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.lblHeaderError = new System.Windows.Forms.Label();
            this._Question = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestionError = new System.Windows.Forms.Label();
            this.lnkAddAnswer = new System.Windows.Forms.LinkLabel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pnlAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.pblButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.pblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoSize = true;
            this.pnlContainer.Controls.Add(this._Header);
            this.pnlContainer.Controls.Add(this.txtHeader);
            this.pnlContainer.Controls.Add(this.lblHeaderError);
            this.pnlContainer.Controls.Add(this._Question);
            this.pnlContainer.Controls.Add(this.txtQuestion);
            this.pnlContainer.Controls.Add(this.lblQuestionError);
            this.pnlContainer.Controls.Add(this.lnkAddAnswer);
            this.pnlContainer.Controls.Add(this.lblOutput);
            this.pnlContainer.Controls.Add(this.pnlAnswers);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(292, 217);
            this.pnlContainer.TabIndex = 1;
            this.pnlContainer.WrapContents = false;
            // 
            // _Header
            // 
            this._Header.AutoSize = true;
            this._Header.Location = new System.Drawing.Point(0, 0);
            this._Header.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._Header.Name = "_Header";
            this._Header.Size = new System.Drawing.Size(55, 13);
            this._Header.TabIndex = 11;
            this._Header.Text = "Overskrift:";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(3, 16);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(284, 20);
            this.txtHeader.TabIndex = 12;
            this.txtHeader.Validating += new System.ComponentModel.CancelEventHandler(this.txtHeader_Validating);
            this.txtHeader.Validated += new System.EventHandler(this.txtHeader_Validated);
            // 
            // lblHeaderError
            // 
            this.lblHeaderError.AutoSize = true;
            this.lblHeaderError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblHeaderError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHeaderError.Location = new System.Drawing.Point(3, 39);
            this.lblHeaderError.Name = "lblHeaderError";
            this.lblHeaderError.Size = new System.Drawing.Size(23, 12);
            this.lblHeaderError.TabIndex = 17;
            this.lblHeaderError.Text = "hest";
            // 
            // _Question
            // 
            this._Question.AutoSize = true;
            this._Question.Location = new System.Drawing.Point(0, 61);
            this._Question.Margin = new System.Windows.Forms.Padding(0, 10, 3, 0);
            this._Question.Name = "_Question";
            this._Question.Size = new System.Drawing.Size(59, 13);
            this._Question.TabIndex = 13;
            this._Question.Text = "Spørgsmål:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(3, 77);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(284, 60);
            this.txtQuestion.TabIndex = 14;
            this.txtQuestion.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuestion_Validating);
            this.txtQuestion.Validated += new System.EventHandler(this.txtQuestion_Validated);
            // 
            // lblQuestionError
            // 
            this.lblQuestionError.AutoSize = true;
            this.lblQuestionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblQuestionError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblQuestionError.Location = new System.Drawing.Point(3, 140);
            this.lblQuestionError.Name = "lblQuestionError";
            this.lblQuestionError.Size = new System.Drawing.Size(23, 12);
            this.lblQuestionError.TabIndex = 18;
            this.lblQuestionError.Text = "hest";
            // 
            // lnkAddAnswer
            // 
            this.lnkAddAnswer.AutoSize = true;
            this.lnkAddAnswer.LinkColor = System.Drawing.Color.DarkOrange;
            this.lnkAddAnswer.Location = new System.Drawing.Point(3, 155);
            this.lnkAddAnswer.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lnkAddAnswer.Name = "lnkAddAnswer";
            this.lnkAddAnswer.Size = new System.Drawing.Size(52, 13);
            this.lnkAddAnswer.TabIndex = 21;
            this.lnkAddAnswer.TabStop = true;
            this.lnkAddAnswer.Text = "Tilføj svar";
            this.lnkAddAnswer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddAnswer_LinkClicked);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(3, 171);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(37, 13);
            this.lblOutput.TabIndex = 20;
            this.lblOutput.Text = "output";
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.AutoScroll = true;
            this.pnlAnswers.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.pnlAnswers.AutoSize = true;
            this.pnlAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAnswers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlAnswers.Location = new System.Drawing.Point(6, 187);
            this.pnlAnswers.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.pnlAnswers.MaximumSize = new System.Drawing.Size(0, 182);
            this.pnlAnswers.MinimumSize = new System.Drawing.Size(280, 0);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Size = new System.Drawing.Size(280, 0);
            this.pnlAnswers.TabIndex = 0;
            this.pnlAnswers.WrapContents = false;
            // 
            // pblButtons
            // 
            this.pblButtons.AutoSize = true;
            this.pblButtons.Controls.Add(this.btnCancel);
            this.pblButtons.Controls.Add(this.btnSave);
            this.pblButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblButtons.Location = new System.Drawing.Point(0, 217);
            this.pblButtons.Name = "pblButtons";
            this.pblButtons.Size = new System.Drawing.Size(292, 29);
            this.pblButtons.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(6, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.btnCancel.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(237)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(87, 3);
            this.btnSave.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Opret";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // QuestionCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pblButtons);
            this.Margin = new System.Windows.Forms.Padding(30);
            this.MaximumSize = new System.Drawing.Size(0, 400);
            this.Name = "QuestionCreate";
            this.Size = new System.Drawing.Size(292, 246);
            this.VisibleChanged += new System.EventHandler(this.QuestionCreate_VisibleChanged);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pblButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlContainer;
        private System.Windows.Forms.Label _Header;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Label lblHeaderError;
        private System.Windows.Forms.Label _Question;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblQuestionError;
        private System.Windows.Forms.FlowLayoutPanel pblButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel pnlAnswers;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.LinkLabel lnkAddAnswer;
    }
}
