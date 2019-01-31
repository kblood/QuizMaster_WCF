namespace QuizAdmin.UserControls
{
    partial class QuizDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizDetail));
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.Title = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.CreateDate = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.Updated = new System.Windows.Forms.Label();
            this.lblUpdatedDate = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoSize = true;
            this.pnlContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContainer.Controls.Add(this.Title);
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.Description);
            this.pnlContainer.Controls.Add(this.lblDescription);
            this.pnlContainer.Controls.Add(this.CreateDate);
            this.pnlContainer.Controls.Add(this.lblCreateDate);
            this.pnlContainer.Controls.Add(this.Updated);
            this.pnlContainer.Controls.Add(this.lblUpdatedDate);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(320, 273);
            this.pnlContainer.TabIndex = 14;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Title.Location = new System.Drawing.Point(0, 3);
            this.Title.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(34, 16);
            this.Title.TabIndex = 0;
            this.Title.Text = "Titel";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(0, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Quiz om alt";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Description.Location = new System.Drawing.Point(0, 44);
            this.Description.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(79, 16);
            this.Description.TabIndex = 1;
            this.Description.Text = "Beskrivelse";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(0, 66);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblDescription.MaximumSize = new System.Drawing.Size(300, 40);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(300, 40);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // CreateDate
            // 
            this.CreateDate.AutoSize = true;
            this.CreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CreateDate.Location = new System.Drawing.Point(0, 112);
            this.CreateDate.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(55, 16);
            this.CreateDate.TabIndex = 2;
            this.CreateDate.Text = "Oprettet";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(0, 131);
            this.lblCreateDate.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(53, 13);
            this.lblCreateDate.TabIndex = 11;
            this.lblCreateDate.Text = "11/11/11";
            // 
            // Updated
            // 
            this.Updated.AutoSize = true;
            this.Updated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updated.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Updated.Location = new System.Drawing.Point(0, 147);
            this.Updated.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Updated.Name = "Updated";
            this.Updated.Size = new System.Drawing.Size(68, 16);
            this.Updated.TabIndex = 3;
            this.Updated.Text = "Opdateret";
            // 
            // lblUpdatedDate
            // 
            this.lblUpdatedDate.AutoSize = true;
            this.lblUpdatedDate.Location = new System.Drawing.Point(0, 166);
            this.lblUpdatedDate.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblUpdatedDate.Name = "lblUpdatedDate";
            this.lblUpdatedDate.Size = new System.Drawing.Size(53, 13);
            this.lblUpdatedDate.TabIndex = 8;
            this.lblUpdatedDate.Text = "11/11/11";
            // 
            // QuizDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "QuizDetail";
            this.Size = new System.Drawing.Size(320, 273);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlContainer;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label CreateDate;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label Updated;
        private System.Windows.Forms.Label lblUpdatedDate;
    }
}
