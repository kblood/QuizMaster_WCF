namespace QuizAdmin
{
    partial class CreateAnswer
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
            this.btnRemoveAnswer = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveAnswer
            // 
            this.btnRemoveAnswer.Location = new System.Drawing.Point(3, 12);
            this.btnRemoveAnswer.Name = "btnRemoveAnswer";
            this.btnRemoveAnswer.Size = new System.Drawing.Size(20, 23);
            this.btnRemoveAnswer.TabIndex = 0;
            this.btnRemoveAnswer.Text = "-";
            this.btnRemoveAnswer.UseVisualStyleBackColor = true;
            this.btnRemoveAnswer.Click += new System.EventHandler(this.btnRemoveAnswer_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(39, 9);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(188, 26);
            this.txtAnswer.TabIndex = 1;
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(254, 9);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(26, 26);
            this.btnCorrect.TabIndex = 3;
            this.btnCorrect.Text = "✓";
            this.btnCorrect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // CreateAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnRemoveAnswer);
            this.Name = "CreateAnswer";
            this.Size = new System.Drawing.Size(295, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveAnswer;
        private System.Windows.Forms.Button btnCorrect;
        public System.Windows.Forms.TextBox txtAnswer;
    }
}
