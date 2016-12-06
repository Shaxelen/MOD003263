namespace MOD003263_SoftwareEngineering.UI {
    partial class FeedbackCreatorForm {
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
            this.grbAddQuestion = new System.Windows.Forms.GroupBox();
            this.btnAddQuestions = new System.Windows.Forms.Button();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.grbRemoveQuestion = new System.Windows.Forms.GroupBox();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.lblRemove = new System.Windows.Forms.Label();
            this.cmbQuestionID = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCVTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInterviewTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeeTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.flwQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.grbFeedbackTemplate = new System.Windows.Forms.GroupBox();
            this.grbClearQuestions = new System.Windows.Forms.GroupBox();
            this.btnClearQuestions = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectCategory = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.grbAddQuestion.SuspendLayout();
            this.grbRemoveQuestion.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grbFeedbackTemplate.SuspendLayout();
            this.grbClearQuestions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAddQuestion
            // 
            this.grbAddQuestion.Controls.Add(this.btnAddQuestions);
            this.grbAddQuestion.Controls.Add(this.lstQuestions);
            this.grbAddQuestion.Location = new System.Drawing.Point(677, 131);
            this.grbAddQuestion.Name = "grbAddQuestion";
            this.grbAddQuestion.Size = new System.Drawing.Size(376, 253);
            this.grbAddQuestion.TabIndex = 0;
            this.grbAddQuestion.TabStop = false;
            this.grbAddQuestion.Text = "Add Question(s)";
            // 
            // btnAddQuestions
            // 
            this.btnAddQuestions.Location = new System.Drawing.Point(6, 224);
            this.btnAddQuestions.Name = "btnAddQuestions";
            this.btnAddQuestions.Size = new System.Drawing.Size(364, 23);
            this.btnAddQuestions.TabIndex = 7;
            this.btnAddQuestions.Text = "Add Question(s)";
            this.btnAddQuestions.UseVisualStyleBackColor = true;
            this.btnAddQuestions.Click += new System.EventHandler(this.btnAddQuestions_Click);
            // 
            // lstQuestions
            // 
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.Location = new System.Drawing.Point(6, 19);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstQuestions.Size = new System.Drawing.Size(364, 199);
            this.lstQuestions.TabIndex = 7;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            // 
            // grbRemoveQuestion
            // 
            this.grbRemoveQuestion.Controls.Add(this.btnRemoveQuestion);
            this.grbRemoveQuestion.Controls.Add(this.lblRemove);
            this.grbRemoveQuestion.Controls.Add(this.cmbQuestionID);
            this.grbRemoveQuestion.Location = new System.Drawing.Point(677, 390);
            this.grbRemoveQuestion.Name = "grbRemoveQuestion";
            this.grbRemoveQuestion.Size = new System.Drawing.Size(376, 93);
            this.grbRemoveQuestion.TabIndex = 3;
            this.grbRemoveQuestion.TabStop = false;
            this.grbRemoveQuestion.Text = "Remove Question";
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Location = new System.Drawing.Point(6, 64);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(364, 23);
            this.btnRemoveQuestion.TabIndex = 5;
            this.btnRemoveQuestion.Text = "Remove Question";
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(91, 16);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(195, 13);
            this.lblRemove.TabIndex = 4;
            this.lblRemove.Text = "Select the Question Number to Remove";
            // 
            // cmbQuestionID
            // 
            this.cmbQuestionID.FormattingEnabled = true;
            this.cmbQuestionID.Location = new System.Drawing.Point(6, 35);
            this.cmbQuestionID.Name = "cmbQuestionID";
            this.cmbQuestionID.Size = new System.Drawing.Size(364, 21);
            this.cmbQuestionID.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.menuSaveTemplate,
            this.menuLoadTemplate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCVTemplate,
            this.menuInterviewTemplate,
            this.menuEmployeeTemplate});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // menuCVTemplate
            // 
            this.menuCVTemplate.Name = "menuCVTemplate";
            this.menuCVTemplate.Size = new System.Drawing.Size(126, 22);
            this.menuCVTemplate.Text = "CV";
            // 
            // menuInterviewTemplate
            // 
            this.menuInterviewTemplate.Name = "menuInterviewTemplate";
            this.menuInterviewTemplate.Size = new System.Drawing.Size(126, 22);
            this.menuInterviewTemplate.Text = "Interview";
            // 
            // menuEmployeeTemplate
            // 
            this.menuEmployeeTemplate.Name = "menuEmployeeTemplate";
            this.menuEmployeeTemplate.Size = new System.Drawing.Size(126, 22);
            this.menuEmployeeTemplate.Text = "Employee";
            // 
            // menuSaveTemplate
            // 
            this.menuSaveTemplate.Name = "menuSaveTemplate";
            this.menuSaveTemplate.Size = new System.Drawing.Size(43, 20);
            this.menuSaveTemplate.Text = "Save";
            this.menuSaveTemplate.Click += new System.EventHandler(this.menuSaveTemplate_Click);
            // 
            // menuLoadTemplate
            // 
            this.menuLoadTemplate.Name = "menuLoadTemplate";
            this.menuLoadTemplate.Size = new System.Drawing.Size(45, 20);
            this.menuLoadTemplate.Text = "Load";
            this.menuLoadTemplate.Click += new System.EventHandler(this.menuLoadTemplate_Click);
            // 
            // flwQuestions
            // 
            this.flwQuestions.AutoScroll = true;
            this.flwQuestions.Location = new System.Drawing.Point(6, 19);
            this.flwQuestions.Name = "flwQuestions";
            this.flwQuestions.Size = new System.Drawing.Size(633, 518);
            this.flwQuestions.TabIndex = 0;
            // 
            // grbFeedbackTemplate
            // 
            this.grbFeedbackTemplate.AutoSize = true;
            this.grbFeedbackTemplate.Controls.Add(this.flwQuestions);
            this.grbFeedbackTemplate.Location = new System.Drawing.Point(12, 27);
            this.grbFeedbackTemplate.Name = "grbFeedbackTemplate";
            this.grbFeedbackTemplate.Size = new System.Drawing.Size(645, 556);
            this.grbFeedbackTemplate.TabIndex = 4;
            this.grbFeedbackTemplate.TabStop = false;
            this.grbFeedbackTemplate.Text = "Feedback Template";
            // 
            // grbClearQuestions
            // 
            this.grbClearQuestions.Controls.Add(this.btnClearQuestions);
            this.grbClearQuestions.Location = new System.Drawing.Point(677, 489);
            this.grbClearQuestions.Name = "grbClearQuestions";
            this.grbClearQuestions.Size = new System.Drawing.Size(376, 93);
            this.grbClearQuestions.TabIndex = 6;
            this.grbClearQuestions.TabStop = false;
            this.grbClearQuestions.Text = "Clear Questions";
            // 
            // btnClearQuestions
            // 
            this.btnClearQuestions.Location = new System.Drawing.Point(6, 42);
            this.btnClearQuestions.Name = "btnClearQuestions";
            this.btnClearQuestions.Size = new System.Drawing.Size(364, 23);
            this.btnClearQuestions.TabIndex = 5;
            this.btnClearQuestions.Text = "Clear Questions";
            this.btnClearQuestions.UseVisualStyleBackColor = true;
            this.btnClearQuestions.Click += new System.EventHandler(this.btnClearQuestions_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectCategory);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Location = new System.Drawing.Point(677, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Category";
            // 
            // btnSelectCategory
            // 
            this.btnSelectCategory.Location = new System.Drawing.Point(6, 52);
            this.btnSelectCategory.Name = "btnSelectCategory";
            this.btnSelectCategory.Size = new System.Drawing.Size(364, 23);
            this.btnSelectCategory.TabIndex = 1;
            this.btnSelectCategory.Text = "Select Category";
            this.btnSelectCategory.UseVisualStyleBackColor = true;
            this.btnSelectCategory.Click += new System.EventHandler(this.btnSelectCategory_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(6, 19);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(364, 21);
            this.cmbCategory.TabIndex = 0;
            // 
            // FeedbackCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbClearQuestions);
            this.Controls.Add(this.grbFeedbackTemplate);
            this.Controls.Add(this.grbRemoveQuestion);
            this.Controls.Add(this.grbAddQuestion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FeedbackCreatorForm";
            this.Text = "Feedback Creator";
            this.grbAddQuestion.ResumeLayout(false);
            this.grbRemoveQuestion.ResumeLayout(false);
            this.grbRemoveQuestion.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbFeedbackTemplate.ResumeLayout(false);
            this.grbClearQuestions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddQuestion;
        private System.Windows.Forms.GroupBox grbRemoveQuestion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCVTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuInterviewTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuEmployeeTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuSaveTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuLoadTemplate;
        private System.Windows.Forms.FlowLayoutPanel flwQuestions;
        private System.Windows.Forms.GroupBox grbFeedbackTemplate;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.ComboBox cmbQuestionID;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.GroupBox grbClearQuestions;
        private System.Windows.Forms.Button btnClearQuestions;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAddQuestions;
    }
}