namespace QuizAdmin
{
    partial class QuizDetails
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.txtCatagory = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtFieldDescription = new System.Windows.Forms.RichTextBox();
            this.lblPublic = new System.Windows.Forms.Label();
            this.checkBoxPublic = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnManageQuestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(115, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(179, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Titel";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(16, 53);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(46, 13);
            this.lblCatagory.TabIndex = 2;
            this.lblCatagory.Text = "Katagori";
            // 
            // txtCatagory
            // 
            this.txtCatagory.Location = new System.Drawing.Point(115, 50);
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.Size = new System.Drawing.Size(179, 20);
            this.txtCatagory.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 96);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(61, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Beskrivelse";
            // 
            // txtFieldDescription
            // 
            this.txtFieldDescription.Location = new System.Drawing.Point(115, 93);
            this.txtFieldDescription.Name = "txtFieldDescription";
            this.txtFieldDescription.Size = new System.Drawing.Size(179, 62);
            this.txtFieldDescription.TabIndex = 5;
            this.txtFieldDescription.Text = "";
            // 
            // lblPublic
            // 
            this.lblPublic.AutoSize = true;
            this.lblPublic.Location = new System.Drawing.Point(16, 188);
            this.lblPublic.Name = "lblPublic";
            this.lblPublic.Size = new System.Drawing.Size(46, 13);
            this.lblPublic.TabIndex = 6;
            this.lblPublic.Text = "Offentlig";
            // 
            // checkBoxPublic
            // 
            this.checkBoxPublic.AutoSize = true;
            this.checkBoxPublic.Location = new System.Drawing.Point(61, 188);
            this.checkBoxPublic.Name = "checkBoxPublic";
            this.checkBoxPublic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPublic.TabIndex = 7;
            this.checkBoxPublic.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(174, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Annuller";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(115, 188);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(53, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Opret";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnManageQuestions
            // 
            this.btnManageQuestions.Location = new System.Drawing.Point(115, 234);
            this.btnManageQuestions.Name = "btnManageQuestions";
            this.btnManageQuestions.Size = new System.Drawing.Size(179, 22);
            this.btnManageQuestions.TabIndex = 11;
            this.btnManageQuestions.Text = "HåndterSpørgsmål";
            this.btnManageQuestions.UseVisualStyleBackColor = true;
            // 
            // QuizDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnManageQuestions);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.checkBoxPublic);
            this.Controls.Add(this.lblPublic);
            this.Controls.Add(this.txtFieldDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtCatagory);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Name = "QuizDetails";
            this.Size = new System.Drawing.Size(317, 280);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.TextBox txtCatagory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox txtFieldDescription;
        private System.Windows.Forms.Label lblPublic;
        private System.Windows.Forms.CheckBox checkBoxPublic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnManageQuestions;
    }
}
