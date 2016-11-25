namespace MOD003263_SoftwareEngineering.Forms {
    partial class TemplateForm {
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
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.txtAddQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.lblTemplateName = new System.Windows.Forms.Label();
            this.grbSaveTemplate = new System.Windows.Forms.GroupBox();
            this.txtSaveTemplate = new System.Windows.Forms.TextBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.grbRemoveQuestion = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCVTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInterviewTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeeTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.flwQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.grbFeedbackTemplate = new System.Windows.Forms.GroupBox();
            this.grbAddQuestion.SuspendLayout();
            this.grbSaveTemplate.SuspendLayout();
            this.grbRemoveQuestion.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grbFeedbackTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAddQuestion
            // 
            this.grbAddQuestion.Controls.Add(this.btnAddQuestion);
            this.grbAddQuestion.Controls.Add(this.txtAddQuestion);
            this.grbAddQuestion.Controls.Add(this.lblQuestion);
            this.grbAddQuestion.Location = new System.Drawing.Point(606, 54);
            this.grbAddQuestion.Name = "grbAddQuestion";
            this.grbAddQuestion.Size = new System.Drawing.Size(200, 100);
            this.grbAddQuestion.TabIndex = 0;
            this.grbAddQuestion.TabStop = false;
            this.grbAddQuestion.Text = "Add Question";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(6, 62);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(188, 23);
            this.btnAddQuestion.TabIndex = 2;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // txtAddQuestion
            // 
            this.txtAddQuestion.Location = new System.Drawing.Point(6, 36);
            this.txtAddQuestion.Name = "txtAddQuestion";
            this.txtAddQuestion.Size = new System.Drawing.Size(188, 20);
            this.txtAddQuestion.TabIndex = 1;
            this.txtAddQuestion.UseWaitCursor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(7, 20);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Location = new System.Drawing.Point(6, 19);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(188, 23);
            this.btnRemoveQuestion.TabIndex = 2;
            this.btnRemoveQuestion.Text = "Remove Question";
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            this.btnRemoveQuestion.UseWaitCursor = true;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // lblTemplateName
            // 
            this.lblTemplateName.AutoSize = true;
            this.lblTemplateName.Location = new System.Drawing.Point(9, 38);
            this.lblTemplateName.Name = "lblTemplateName";
            this.lblTemplateName.Size = new System.Drawing.Size(82, 13);
            this.lblTemplateName.TabIndex = 1;
            this.lblTemplateName.Text = "Template Name";
            // 
            // grbSaveTemplate
            // 
            this.grbSaveTemplate.Controls.Add(this.txtSaveTemplate);
            this.grbSaveTemplate.Controls.Add(this.btnSaveTemplate);
            this.grbSaveTemplate.Location = new System.Drawing.Point(606, 225);
            this.grbSaveTemplate.Name = "grbSaveTemplate";
            this.grbSaveTemplate.Size = new System.Drawing.Size(200, 79);
            this.grbSaveTemplate.TabIndex = 2;
            this.grbSaveTemplate.TabStop = false;
            this.grbSaveTemplate.Text = "Save Template";
            // 
            // txtSaveTemplate
            // 
            this.txtSaveTemplate.Location = new System.Drawing.Point(6, 19);
            this.txtSaveTemplate.Name = "txtSaveTemplate";
            this.txtSaveTemplate.Size = new System.Drawing.Size(188, 20);
            this.txtSaveTemplate.TabIndex = 1;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(6, 45);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(188, 23);
            this.btnSaveTemplate.TabIndex = 0;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            // 
            // grbRemoveQuestion
            // 
            this.grbRemoveQuestion.Controls.Add(this.btnRemoveQuestion);
            this.grbRemoveQuestion.Location = new System.Drawing.Point(606, 160);
            this.grbRemoveQuestion.Name = "grbRemoveQuestion";
            this.grbRemoveQuestion.Size = new System.Drawing.Size(200, 59);
            this.grbRemoveQuestion.TabIndex = 3;
            this.grbRemoveQuestion.TabStop = false;
            this.grbRemoveQuestion.Text = "Remove Question";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.menuSaveTemplate,
            this.menuClearTemplate,
            this.menuLoadTemplate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
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
            this.menuCVTemplate.Click += new System.EventHandler(this.menuCVTemplate_Click);
            // 
            // menuInterviewTemplate
            // 
            this.menuInterviewTemplate.Name = "menuInterviewTemplate";
            this.menuInterviewTemplate.Size = new System.Drawing.Size(126, 22);
            this.menuInterviewTemplate.Text = "Interview";
            this.menuInterviewTemplate.Click += new System.EventHandler(this.menuInterviewTemplate_Click);
            // 
            // menuEmployeeTemplate
            // 
            this.menuEmployeeTemplate.Name = "menuEmployeeTemplate";
            this.menuEmployeeTemplate.Size = new System.Drawing.Size(126, 22);
            this.menuEmployeeTemplate.Text = "Employee";
            this.menuEmployeeTemplate.Click += new System.EventHandler(this.menuEmployeeTemplate_Click);
            // 
            // menuSaveTemplate
            // 
            this.menuSaveTemplate.Name = "menuSaveTemplate";
            this.menuSaveTemplate.Size = new System.Drawing.Size(43, 20);
            this.menuSaveTemplate.Text = "Save";
            // 
            // menuClearTemplate
            // 
            this.menuClearTemplate.Name = "menuClearTemplate";
            this.menuClearTemplate.Size = new System.Drawing.Size(46, 20);
            this.menuClearTemplate.Text = "Clear";
            this.menuClearTemplate.Click += new System.EventHandler(this.menuClearTemplate_Click);
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
            this.flwQuestions.Location = new System.Drawing.Point(6, 19);
            this.flwQuestions.Name = "flwQuestions";
            this.flwQuestions.Size = new System.Drawing.Size(571, 569);
            this.flwQuestions.TabIndex = 0;
            // 
            // grbFeedbackTemplate
            // 
            this.grbFeedbackTemplate.AutoSize = true;
            this.grbFeedbackTemplate.Controls.Add(this.flwQuestions);
            this.grbFeedbackTemplate.Location = new System.Drawing.Point(12, 54);
            this.grbFeedbackTemplate.Name = "grbFeedbackTemplate";
            this.grbFeedbackTemplate.Size = new System.Drawing.Size(588, 607);
            this.grbFeedbackTemplate.TabIndex = 4;
            this.grbFeedbackTemplate.TabStop = false;
            this.grbFeedbackTemplate.Text = "Feedback Template";
            this.grbFeedbackTemplate.Visible = false;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 654);
            this.Controls.Add(this.grbFeedbackTemplate);
            this.Controls.Add(this.lblTemplateName);
            this.Controls.Add(this.grbRemoveQuestion);
            this.Controls.Add(this.grbSaveTemplate);
            this.Controls.Add(this.grbAddQuestion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.grbAddQuestion.ResumeLayout(false);
            this.grbAddQuestion.PerformLayout();
            this.grbSaveTemplate.ResumeLayout(false);
            this.grbSaveTemplate.PerformLayout();
            this.grbRemoveQuestion.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbFeedbackTemplate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TextBox txtAddQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTemplateName;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.GroupBox grbSaveTemplate;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.TextBox txtSaveTemplate;
        private System.Windows.Forms.GroupBox grbRemoveQuestion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCVTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuInterviewTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuEmployeeTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuSaveTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuClearTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuLoadTemplate;
        private System.Windows.Forms.FlowLayoutPanel flwQuestions;
        private System.Windows.Forms.GroupBox grbFeedbackTemplate;
    }
}