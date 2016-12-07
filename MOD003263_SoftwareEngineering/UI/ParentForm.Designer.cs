namespace MOD003263_SoftwareEngineering.UI {
    partial class ParentForm {
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
            this.menuItemQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemApplicants = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateFeedback = new System.Windows.Forms.Button();
            this.btnConductInterview = new System.Windows.Forms.Button();
            this.btnCreateQuestions = new System.Windows.Forms.Button();
            this.btnFilterApplicants = new System.Windows.Forms.Button();
            this.btnEditSettings = new System.Windows.Forms.Button();
            this.btnAddApplicants = new System.Windows.Forms.Button();
            this.menuScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuScreen
            // 
            this.menuScreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemQuestion,
            this.menuItemTemplate,
            this.menuItemFeedback,
            this.menuItemFilter,
            this.menuItemSettings,
            this.menuItemApplicants});
            this.menuScreen.Location = new System.Drawing.Point(0, 0);
            this.menuScreen.Name = "menuScreen";
            this.menuScreen.Size = new System.Drawing.Size(1069, 24);
            this.menuScreen.TabIndex = 1;
            this.menuScreen.Text = "menuStrip1";
            // 
            // menuItemQuestion
            // 
            this.menuItemQuestion.Name = "menuItemQuestion";
            this.menuItemQuestion.Size = new System.Drawing.Size(117, 20);
            this.menuItemQuestion.Text = "Create Question(s)";
            this.menuItemQuestion.Click += new System.EventHandler(this.menuItemQuestion_Click);
            // 
            // menuItemTemplate
            // 
            this.menuItemTemplate.Name = "menuItemTemplate";
            this.menuItemTemplate.Size = new System.Drawing.Size(106, 20);
            this.menuItemTemplate.Text = "Create Feedback";
            this.menuItemTemplate.Click += new System.EventHandler(this.templatesToolStripMenuItem_Click);
            // 
            // menuItemFeedback
            // 
            this.menuItemFeedback.Name = "menuItemFeedback";
            this.menuItemFeedback.Size = new System.Drawing.Size(116, 20);
            this.menuItemFeedback.Text = "Conduct Interview";
            this.menuItemFeedback.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // menuItemFilter
            // 
            this.menuItemFilter.Name = "menuItemFilter";
            this.menuItemFilter.Size = new System.Drawing.Size(104, 20);
            this.menuItemFilter.Text = "Filter Applicants";
            this.menuItemFilter.Click += new System.EventHandler(this.filterApplicantsToolStripMenuItem_Click);
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Size = new System.Drawing.Size(84, 20);
            this.menuItemSettings.Text = "Edit Settings";
            this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
            // 
            // menuItemApplicants
            // 
            this.menuItemApplicants.Name = "menuItemApplicants";
            this.menuItemApplicants.Size = new System.Drawing.Size(108, 20);
            this.menuItemApplicants.Text = "Add Applicant(s)";
            this.menuItemApplicants.Click += new System.EventHandler(this.menuItemApplicants_Click);
            // 
            // btnCreateFeedback
            // 
            this.btnCreateFeedback.Location = new System.Drawing.Point(406, 130);
            this.btnCreateFeedback.Name = "btnCreateFeedback";
            this.btnCreateFeedback.Size = new System.Drawing.Size(272, 90);
            this.btnCreateFeedback.TabIndex = 3;
            this.btnCreateFeedback.Text = "Create Feedback";
            this.btnCreateFeedback.UseVisualStyleBackColor = true;
            this.btnCreateFeedback.Click += new System.EventHandler(this.templatesToolStripMenuItem_Click);
            // 
            // btnConductInterview
            // 
            this.btnConductInterview.Location = new System.Drawing.Point(406, 225);
            this.btnConductInterview.Name = "btnConductInterview";
            this.btnConductInterview.Size = new System.Drawing.Size(272, 90);
            this.btnConductInterview.TabIndex = 4;
            this.btnConductInterview.Text = "Conduct Interview";
            this.btnConductInterview.UseVisualStyleBackColor = true;
            this.btnConductInterview.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // btnCreateQuestions
            // 
            this.btnCreateQuestions.Location = new System.Drawing.Point(406, 35);
            this.btnCreateQuestions.Name = "btnCreateQuestions";
            this.btnCreateQuestions.Size = new System.Drawing.Size(272, 90);
            this.btnCreateQuestions.TabIndex = 5;
            this.btnCreateQuestions.Text = "Create Question(s)";
            this.btnCreateQuestions.UseVisualStyleBackColor = true;
            this.btnCreateQuestions.Click += new System.EventHandler(this.menuItemQuestion_Click);
            // 
            // btnFilterApplicants
            // 
            this.btnFilterApplicants.Location = new System.Drawing.Point(406, 320);
            this.btnFilterApplicants.Name = "btnFilterApplicants";
            this.btnFilterApplicants.Size = new System.Drawing.Size(272, 90);
            this.btnFilterApplicants.TabIndex = 6;
            this.btnFilterApplicants.Text = "Filter Applicants";
            this.btnFilterApplicants.UseVisualStyleBackColor = true;
            this.btnFilterApplicants.Click += new System.EventHandler(this.filterApplicantsToolStripMenuItem_Click);
            // 
            // btnEditSettings
            // 
            this.btnEditSettings.Location = new System.Drawing.Point(406, 415);
            this.btnEditSettings.Name = "btnEditSettings";
            this.btnEditSettings.Size = new System.Drawing.Size(272, 90);
            this.btnEditSettings.TabIndex = 7;
            this.btnEditSettings.Text = "Edit Settings";
            this.btnEditSettings.UseVisualStyleBackColor = true;
            this.btnEditSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
            // 
            // btnAddApplicants
            // 
            this.btnAddApplicants.Location = new System.Drawing.Point(406, 510);
            this.btnAddApplicants.Name = "btnAddApplicants";
            this.btnAddApplicants.Size = new System.Drawing.Size(272, 90);
            this.btnAddApplicants.TabIndex = 8;
            this.btnAddApplicants.Text = "Add Applicant(s)";
            this.btnAddApplicants.UseVisualStyleBackColor = true;
            this.btnAddApplicants.Click += new System.EventHandler(this.menuItemApplicants_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 634);
            this.Controls.Add(this.btnAddApplicants);
            this.Controls.Add(this.btnEditSettings);
            this.Controls.Add(this.btnFilterApplicants);
            this.Controls.Add(this.btnCreateQuestions);
            this.Controls.Add(this.btnConductInterview);
            this.Controls.Add(this.btnCreateFeedback);
            this.Controls.Add(this.menuScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParentForm";
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
        private System.Windows.Forms.Button btnCreateFeedback;
        private System.Windows.Forms.Button btnConductInterview;
        private System.Windows.Forms.Button btnCreateQuestions;
        private System.Windows.Forms.Button btnFilterApplicants;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemApplicants;
        private System.Windows.Forms.Button btnEditSettings;
        private System.Windows.Forms.Button btnAddApplicants;
    }
}