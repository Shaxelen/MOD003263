namespace ConsoleApplication1 {
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
            this.lstTemplateQuestions = new System.Windows.Forms.ListBox();
            this.grbCreateTemplate = new System.Windows.Forms.GroupBox();
            this.btnCreateTemplate = new System.Windows.Forms.Button();
            this.txtCreateTemplate = new System.Windows.Forms.TextBox();
            this.grbLoadTemplate = new System.Windows.Forms.GroupBox();
            this.txtLoadTemplate = new System.Windows.Forms.TextBox();
            this.btnLoadTemplate = new System.Windows.Forms.Button();
            this.grbSaveTemplate = new System.Windows.Forms.GroupBox();
            this.txtSaveTemplate = new System.Windows.Forms.TextBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.grbRemoveQuestion = new System.Windows.Forms.GroupBox();
            this.grbFeedbackTemplate = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFeedbacker = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFeedbacker = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.picAppImage = new System.Windows.Forms.PictureBox();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.grbAddQuestion.SuspendLayout();
            this.grbCreateTemplate.SuspendLayout();
            this.grbLoadTemplate.SuspendLayout();
            this.grbSaveTemplate.SuspendLayout();
            this.grbRemoveQuestion.SuspendLayout();
            this.grbFeedbackTemplate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAddQuestion
            // 
            this.grbAddQuestion.Controls.Add(this.btnAddQuestion);
            this.grbAddQuestion.Controls.Add(this.txtAddQuestion);
            this.grbAddQuestion.Controls.Add(this.lblQuestion);
            this.grbAddQuestion.Location = new System.Drawing.Point(802, 41);
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
            this.btnRemoveQuestion.Location = new System.Drawing.Point(0, 19);
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
            this.lblTemplateName.Location = new System.Drawing.Point(224, 15);
            this.lblTemplateName.Name = "lblTemplateName";
            this.lblTemplateName.Size = new System.Drawing.Size(82, 13);
            this.lblTemplateName.TabIndex = 1;
            this.lblTemplateName.Text = "Template Name";
            // 
            // lstTemplateQuestions
            // 
            this.lstTemplateQuestions.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lstTemplateQuestions.FormattingEnabled = true;
            this.lstTemplateQuestions.Location = new System.Drawing.Point(7, 189);
            this.lstTemplateQuestions.Name = "lstTemplateQuestions";
            this.lstTemplateQuestions.Size = new System.Drawing.Size(549, 420);
            this.lstTemplateQuestions.TabIndex = 0;
            this.lstTemplateQuestions.SelectedIndexChanged += new System.EventHandler(this.lstTemplateQuestions_SelectedIndexChanged);
            // 
            // grbCreateTemplate
            // 
            this.grbCreateTemplate.Controls.Add(this.btnCreateTemplate);
            this.grbCreateTemplate.Controls.Add(this.txtCreateTemplate);
            this.grbCreateTemplate.Location = new System.Drawing.Point(12, 12);
            this.grbCreateTemplate.Name = "grbCreateTemplate";
            this.grbCreateTemplate.Size = new System.Drawing.Size(200, 74);
            this.grbCreateTemplate.TabIndex = 2;
            this.grbCreateTemplate.TabStop = false;
            this.grbCreateTemplate.Text = "Create Template";
            // 
            // btnCreateTemplate
            // 
            this.btnCreateTemplate.Location = new System.Drawing.Point(6, 45);
            this.btnCreateTemplate.Name = "btnCreateTemplate";
            this.btnCreateTemplate.Size = new System.Drawing.Size(188, 23);
            this.btnCreateTemplate.TabIndex = 0;
            this.btnCreateTemplate.Text = "Create Template";
            this.btnCreateTemplate.UseVisualStyleBackColor = true;
            this.btnCreateTemplate.Click += new System.EventHandler(this.btnCreateTemplate_Click);
            // 
            // txtCreateTemplate
            // 
            this.txtCreateTemplate.Location = new System.Drawing.Point(6, 19);
            this.txtCreateTemplate.Name = "txtCreateTemplate";
            this.txtCreateTemplate.Size = new System.Drawing.Size(188, 20);
            this.txtCreateTemplate.TabIndex = 1;
            this.txtCreateTemplate.UseWaitCursor = true;
            // 
            // grbLoadTemplate
            // 
            this.grbLoadTemplate.Controls.Add(this.txtLoadTemplate);
            this.grbLoadTemplate.Controls.Add(this.btnLoadTemplate);
            this.grbLoadTemplate.Location = new System.Drawing.Point(12, 92);
            this.grbLoadTemplate.Name = "grbLoadTemplate";
            this.grbLoadTemplate.Size = new System.Drawing.Size(200, 73);
            this.grbLoadTemplate.TabIndex = 2;
            this.grbLoadTemplate.TabStop = false;
            this.grbLoadTemplate.Text = "Load Template";
            // 
            // txtLoadTemplate
            // 
            this.txtLoadTemplate.Location = new System.Drawing.Point(6, 19);
            this.txtLoadTemplate.Name = "txtLoadTemplate";
            this.txtLoadTemplate.Size = new System.Drawing.Size(188, 20);
            this.txtLoadTemplate.TabIndex = 1;
            // 
            // btnLoadTemplate
            // 
            this.btnLoadTemplate.Location = new System.Drawing.Point(6, 45);
            this.btnLoadTemplate.Name = "btnLoadTemplate";
            this.btnLoadTemplate.Size = new System.Drawing.Size(188, 23);
            this.btnLoadTemplate.TabIndex = 0;
            this.btnLoadTemplate.Text = "Load Template";
            this.btnLoadTemplate.UseVisualStyleBackColor = true;
            this.btnLoadTemplate.Click += new System.EventHandler(this.btnLoadTemplate_Click);
            // 
            // grbSaveTemplate
            // 
            this.grbSaveTemplate.Controls.Add(this.txtSaveTemplate);
            this.grbSaveTemplate.Controls.Add(this.btnSaveTemplate);
            this.grbSaveTemplate.Location = new System.Drawing.Point(12, 171);
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
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // grbRemoveQuestion
            // 
            this.grbRemoveQuestion.Controls.Add(this.btnRemoveQuestion);
            this.grbRemoveQuestion.Location = new System.Drawing.Point(802, 147);
            this.grbRemoveQuestion.Name = "grbRemoveQuestion";
            this.grbRemoveQuestion.Size = new System.Drawing.Size(200, 49);
            this.grbRemoveQuestion.TabIndex = 3;
            this.grbRemoveQuestion.TabStop = false;
            this.grbRemoveQuestion.Text = "Remove Question";
            // 
            // grbFeedbackTemplate
            // 
            this.grbFeedbackTemplate.AutoSize = true;
            this.grbFeedbackTemplate.Controls.Add(this.groupBox1);
            this.grbFeedbackTemplate.Controls.Add(this.lstTemplateQuestions);
            this.grbFeedbackTemplate.Location = new System.Drawing.Point(227, 31);
            this.grbFeedbackTemplate.Name = "grbFeedbackTemplate";
            this.grbFeedbackTemplate.Size = new System.Drawing.Size(569, 628);
            this.grbFeedbackTemplate.TabIndex = 4;
            this.grbFeedbackTemplate.TabStop = false;
            this.grbFeedbackTemplate.Text = "Feedback Template";
            this.grbFeedbackTemplate.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtFeedbacker);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblFeedbacker);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.picAppImage);
            this.groupBox1.Location = new System.Drawing.Point(7, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            // 
            // txtFeedbacker
            // 
            this.txtFeedbacker.Location = new System.Drawing.Point(76, 123);
            this.txtFeedbacker.Name = "txtFeedbacker";
            this.txtFeedbacker.Size = new System.Drawing.Size(229, 20);
            this.txtFeedbacker.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(350, 123);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(193, 97);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(356, 20);
            this.txtPosition.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(193, 71);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(357, 20);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(194, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(356, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(409, 19);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(194, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(311, 130);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // lblFeedbacker
            // 
            this.lblFeedbacker.AutoSize = true;
            this.lblFeedbacker.Location = new System.Drawing.Point(3, 129);
            this.lblFeedbacker.Name = "lblFeedbacker";
            this.lblFeedbacker.Size = new System.Drawing.Size(67, 13);
            this.lblFeedbacker.TabIndex = 1;
            this.lblFeedbacker.Text = "Feedbacker:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(143, 104);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Position:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(112, 78);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(155, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(340, 26);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(130, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // picAppImage
            // 
            this.picAppImage.Location = new System.Drawing.Point(6, 19);
            this.picAppImage.Name = "picAppImage";
            this.picAppImage.Size = new System.Drawing.Size(100, 100);
            this.picAppImage.TabIndex = 0;
            this.picAppImage.TabStop = false;
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.Location = new System.Drawing.Point(840, 328);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(120, 95);
            this.lstTest.TabIndex = 5;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 654);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.grbFeedbackTemplate);
            this.Controls.Add(this.lblTemplateName);
            this.Controls.Add(this.grbRemoveQuestion);
            this.Controls.Add(this.grbSaveTemplate);
            this.Controls.Add(this.grbLoadTemplate);
            this.Controls.Add(this.grbCreateTemplate);
            this.Controls.Add(this.grbAddQuestion);
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.grbAddQuestion.ResumeLayout(false);
            this.grbAddQuestion.PerformLayout();
            this.grbCreateTemplate.ResumeLayout(false);
            this.grbCreateTemplate.PerformLayout();
            this.grbLoadTemplate.ResumeLayout(false);
            this.grbLoadTemplate.PerformLayout();
            this.grbSaveTemplate.ResumeLayout(false);
            this.grbSaveTemplate.PerformLayout();
            this.grbRemoveQuestion.ResumeLayout(false);
            this.grbFeedbackTemplate.ResumeLayout(false);
            this.grbFeedbackTemplate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TextBox txtAddQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ListBox lstTemplateQuestions;
        private System.Windows.Forms.Label lblTemplateName;
        private System.Windows.Forms.GroupBox grbCreateTemplate;
        private System.Windows.Forms.Button btnCreateTemplate;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.TextBox txtCreateTemplate;
        private System.Windows.Forms.GroupBox grbLoadTemplate;
        private System.Windows.Forms.Button btnLoadTemplate;
        private System.Windows.Forms.GroupBox grbSaveTemplate;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.TextBox txtSaveTemplate;
        private System.Windows.Forms.TextBox txtLoadTemplate;
        private System.Windows.Forms.GroupBox grbRemoveQuestion;
        private System.Windows.Forms.GroupBox grbFeedbackTemplate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFeedbacker;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFeedbacker;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.PictureBox picAppImage;
        private System.Windows.Forms.ListBox lstTest;
    }
}