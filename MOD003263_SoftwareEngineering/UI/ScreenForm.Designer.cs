namespace MOD003263_SoftwareEngineering.UI {
    partial class ScreenForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuScreen = new System.Windows.Forms.MenuStrip();
            this.menuItemTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuScreen
            // 
            this.menuScreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTemplate,
            this.menuItemFeedback,
            this.menuItemFilter,
            this.menuItemQuestion});
            this.menuScreen.Location = new System.Drawing.Point(0, 0);
            this.menuScreen.Name = "menuScreen";
            this.menuScreen.Size = new System.Drawing.Size(1069, 24);
            this.menuScreen.TabIndex = 1;
            this.menuScreen.Text = "menuStrip1";
            // 
            // menuItemTemplate
            // 
            this.menuItemTemplate.Name = "menuItemTemplate";
            this.menuItemTemplate.Size = new System.Drawing.Size(73, 20);
            this.menuItemTemplate.Text = "Templates";
            this.menuItemTemplate.Click += new System.EventHandler(this.templatesToolStripMenuItem_Click);
            // 
            // menuItemFeedback
            // 
            this.menuItemFeedback.Name = "menuItemFeedback";
            this.menuItemFeedback.Size = new System.Drawing.Size(69, 20);
            this.menuItemFeedback.Text = "Feedback";
            this.menuItemFeedback.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // menuItemFilter
            // 
            this.menuItemFilter.Name = "menuItemFilter";
            this.menuItemFilter.Size = new System.Drawing.Size(104, 20);
            this.menuItemFilter.Text = "Filter Applicants";
            this.menuItemFilter.Click += new System.EventHandler(this.filterApplicantsToolStripMenuItem_Click);
            // 
            // menuItemQuestion
            // 
            this.menuItemQuestion.Name = "menuItemQuestion";
            this.menuItemQuestion.Size = new System.Drawing.Size(106, 20);
            this.menuItemQuestion.Text = "QuestionCreator";
            this.menuItemQuestion.Click += new System.EventHandler(this.menuItemQuestion_Click);
            // 
            // ScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 634);
            this.Controls.Add(this.menuScreen);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuScreen;
            this.Name = "ScreenForm";
            this.Text = "HappyTech";
            this.menuScreen.ResumeLayout(false);
            this.menuScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuScreen;
        private System.Windows.Forms.ToolStripMenuItem menuItemTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuItemFeedback;
        private System.Windows.Forms.ToolStripMenuItem menuItemFilter;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuestion;
    }
}