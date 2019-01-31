namespace QuizAdmin
{
    partial class CreateQuestion
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.bntAddAnswer = new System.Windows.Forms.Button();
            this.pnlAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(6, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(42, 13);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Header";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(6, 49);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(73, 3);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(135, 20);
            this.txtHeader.TabIndex = 2;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(73, 49);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(334, 67);
            this.txtQuestion.TabIndex = 3;
            // 
            // bntAddAnswer
            // 
            this.bntAddAnswer.Location = new System.Drawing.Point(9, 142);
            this.bntAddAnswer.Name = "bntAddAnswer";
            this.bntAddAnswer.Size = new System.Drawing.Size(19, 23);
            this.bntAddAnswer.TabIndex = 4;
            this.bntAddAnswer.Text = "+";
            this.bntAddAnswer.UseVisualStyleBackColor = true;
            this.bntAddAnswer.Click += new System.EventHandler(this.bntAddAnswer_Click);
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.Location = new System.Drawing.Point(43, 142);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Size = new System.Drawing.Size(364, 239);
            this.pnlAnswers.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Gem";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(104, 392);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(251, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Luk";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlAnswers);
            this.Controls.Add(this.bntAddAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblHeader);
            this.Name = "CreateQuestion";
            this.Size = new System.Drawing.Size(485, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button bntAddAnswer;
        private System.Windows.Forms.FlowLayoutPanel pnlAnswers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnClose;
    }
}
