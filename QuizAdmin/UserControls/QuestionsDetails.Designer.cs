namespace QuizAdmin.UserControls
{
    partial class QuestionsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsDetails));
            this.pnlWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOverskrift = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.Spørgsmål = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.CreateDate = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.pnlWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.AutoSize = true;
            this.pnlWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlWrapper.Controls.Add(this.lblOverskrift);
            this.pnlWrapper.Controls.Add(this.lblHeader);
            this.pnlWrapper.Controls.Add(this.Spørgsmål);
            this.pnlWrapper.Controls.Add(this.lblQuestion);
            this.pnlWrapper.Controls.Add(this.CreateDate);
            this.pnlWrapper.Controls.Add(this.lblCreateDate);
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapper.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnlWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(305, 279);
            this.pnlWrapper.TabIndex = 0;
            this.pnlWrapper.WrapContents = false;
            // 
            // lblOverskrift
            // 
            this.lblOverskrift.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOverskrift.AutoSize = true;
            this.lblOverskrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverskrift.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblOverskrift.Location = new System.Drawing.Point(3, 3);
            this.lblOverskrift.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblOverskrift.Name = "lblOverskrift";
            this.lblOverskrift.Size = new System.Drawing.Size(64, 16);
            this.lblOverskrift.TabIndex = 1;
            this.lblOverskrift.Text = "Overskrift";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(3, 25);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(88, 13);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Spørgsmål til quiz";
            // 
            // Spørgsmål
            // 
            this.Spørgsmål.AutoSize = true;
            this.Spørgsmål.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spørgsmål.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Spørgsmål.Location = new System.Drawing.Point(3, 44);
            this.Spørgsmål.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Spørgsmål.Name = "Spørgsmål";
            this.Spørgsmål.Size = new System.Drawing.Size(74, 16);
            this.Spørgsmål.TabIndex = 9;
            this.Spørgsmål.Text = "Spørgsmål";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(3, 66);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(300, 40);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(300, 40);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = resources.GetString("lblQuestion.Text");
            // 
            // CreateDate
            // 
            this.CreateDate.AutoSize = true;
            this.CreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CreateDate.Location = new System.Drawing.Point(3, 112);
            this.CreateDate.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(55, 16);
            this.CreateDate.TabIndex = 11;
            this.CreateDate.Text = "Oprettet";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(3, 131);
            this.lblCreateDate.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(53, 13);
            this.lblCreateDate.TabIndex = 12;
            this.lblCreateDate.Text = "11/11/11";
            // 
            // QuestionsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlWrapper);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "QuestionsDetails";
            this.Size = new System.Drawing.Size(305, 279);
            this.pnlWrapper.ResumeLayout(false);
            this.pnlWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlWrapper;
        private System.Windows.Forms.Label lblOverskrift;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label Spørgsmål;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label CreateDate;
        private System.Windows.Forms.Label lblCreateDate;
    }
}
