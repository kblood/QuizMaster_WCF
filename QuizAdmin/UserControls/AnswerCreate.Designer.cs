namespace QuizAdmin.UserControls
{
    partial class AnswerCreate
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
            this.components = new System.ComponentModel.Container();
            this.pnlFormContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.checkCorrect = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlErrorRemove = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAnswerError = new System.Windows.Forms.Label();
            this.pnlFormContainer.SuspendLayout();
            this.pnlErrorRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormContainer
            // 
            this.pnlFormContainer.AutoSize = true;
            this.pnlFormContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFormContainer.Controls.Add(this.btnRemove);
            this.pnlFormContainer.Controls.Add(this.txtAnswer);
            this.pnlFormContainer.Controls.Add(this.checkCorrect);
            this.pnlFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlFormContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormContainer.MinimumSize = new System.Drawing.Size(0, 30);
            this.pnlFormContainer.Name = "pnlFormContainer";
            this.pnlFormContainer.Size = new System.Drawing.Size(300, 30);
            this.pnlFormContainer.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Window;
            this.btnRemove.CausesValidation = false;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemove.Location = new System.Drawing.Point(0, 0);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.MaximumSize = new System.Drawing.Size(30, 30);
            this.btnRemove.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 30);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "✖";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(30, 0);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(0);
            this.txtAnswer.MinimumSize = new System.Drawing.Size(240, 30);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(240, 30);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnswer_Validating);
            this.txtAnswer.Validated += new System.EventHandler(this.txtAnswer_Validated);
            // 
            // checkCorrect
            // 
            this.checkCorrect.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkCorrect.BackColor = System.Drawing.SystemColors.Window;
            this.checkCorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkCorrect.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkCorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCorrect.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.checkCorrect.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.checkCorrect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.checkCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCorrect.ForeColor = System.Drawing.Color.Green;
            this.checkCorrect.Location = new System.Drawing.Point(270, 0);
            this.checkCorrect.Margin = new System.Windows.Forms.Padding(0);
            this.checkCorrect.MaximumSize = new System.Drawing.Size(30, 30);
            this.checkCorrect.MinimumSize = new System.Drawing.Size(0, 30);
            this.checkCorrect.Name = "checkCorrect";
            this.checkCorrect.Size = new System.Drawing.Size(30, 30);
            this.checkCorrect.TabIndex = 3;
            this.checkCorrect.Text = "✓";
            this.checkCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkCorrect.UseVisualStyleBackColor = false;
            this.checkCorrect.CheckStateChanged += new System.EventHandler(this.checkCorrect_CheckStateChanged);
            // 
            // pnlErrorRemove
            // 
            this.pnlErrorRemove.AutoSize = true;
            this.pnlErrorRemove.Controls.Add(this.lblAnswerError);
            this.pnlErrorRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlErrorRemove.Location = new System.Drawing.Point(0, 30);
            this.pnlErrorRemove.Name = "pnlErrorRemove";
            this.pnlErrorRemove.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.pnlErrorRemove.Size = new System.Drawing.Size(300, 26);
            this.pnlErrorRemove.TabIndex = 1;
            // 
            // lblAnswerError
            // 
            this.lblAnswerError.AutoSize = true;
            this.lblAnswerError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAnswerError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAnswerError.Location = new System.Drawing.Point(0, 5);
            this.lblAnswerError.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblAnswerError.Name = "lblAnswerError";
            this.lblAnswerError.Size = new System.Drawing.Size(0, 12);
            this.lblAnswerError.TabIndex = 18;
            // 
            // AnswerCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pnlFormContainer);
            this.Controls.Add(this.pnlErrorRemove);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(0, 80);
            this.MinimumSize = new System.Drawing.Size(160, 0);
            this.Name = "AnswerCreate";
            this.Size = new System.Drawing.Size(300, 56);
            this.pnlFormContainer.ResumeLayout(false);
            this.pnlFormContainer.PerformLayout();
            this.pnlErrorRemove.ResumeLayout(false);
            this.pnlErrorRemove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.FlowLayoutPanel pnlFormContainer;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.CheckBox checkCorrect;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FlowLayoutPanel pnlErrorRemove;
        private System.Windows.Forms.Label lblAnswerError;
    }
}
