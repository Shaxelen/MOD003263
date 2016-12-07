namespace MOD003263_SoftwareEngineering.UI {
    partial class InterviewForm {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadTemp = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadApplicant = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.cmbApplicant = new System.Windows.Forms.ComboBox();
            this.btnOpenCV = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnFinishInterview = new System.Windows.Forms.Button();
            this.picApplicantPicture = new System.Windows.Forms.PictureBox();
            this.grpFeedbackAnswers = new System.Windows.Forms.GroupBox();
            this.radAnswerOne = new System.Windows.Forms.RadioButton();
            this.radAnswerTwo = new System.Windows.Forms.RadioButton();
            this.radAnswerThree = new System.Windows.Forms.RadioButton();
            this.radAnswerFour = new System.Windows.Forms.RadioButton();
            this.radAnswerFive = new System.Windows.Forms.RadioButton();
            this.txtAnswerOne = new System.Windows.Forms.TextBox();
            this.txtAnswerTwo = new System.Windows.Forms.TextBox();
            this.txtAnswerThree = new System.Windows.Forms.TextBox();
            this.txtAnswerFour = new System.Windows.Forms.TextBox();
            this.txtAnswerFive = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApplicantPicture)).BeginInit();
            this.grpFeedbackAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoadTemp,
            this.personToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // menuLoadTemp
            // 
            this.menuLoadTemp.Name = "menuLoadTemp";
            this.menuLoadTemp.Size = new System.Drawing.Size(124, 22);
            this.menuLoadTemp.Text = "Template";
            this.menuLoadTemp.Click += new System.EventHandler(this.menuLoadTemp_Click);
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoadApplicant,
            this.menuLoadEmployee});
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.personToolStripMenuItem.Text = "Person";
            // 
            // menuLoadApplicant
            // 
            this.menuLoadApplicant.Name = "menuLoadApplicant";
            this.menuLoadApplicant.Size = new System.Drawing.Size(126, 22);
            this.menuLoadApplicant.Text = "Applicant";
            this.menuLoadApplicant.Click += new System.EventHandler(this.menuLoadApplicant_Click);
            // 
            // menuLoadEmployee
            // 
            this.menuLoadEmployee.Name = "menuLoadEmployee";
            this.menuLoadEmployee.Size = new System.Drawing.Size(126, 22);
            this.menuLoadEmployee.Text = "Employee";
            this.menuLoadEmployee.Click += new System.EventHandler(this.menuLoadEmployee_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.menuSaveAs});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(114, 22);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(114, 22);
            this.menuSaveAs.Text = "Save As";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClearHeader,
            this.menuClearFeedback});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // menuClearHeader
            // 
            this.menuClearHeader.Name = "menuClearHeader";
            this.menuClearHeader.Size = new System.Drawing.Size(124, 22);
            this.menuClearHeader.Text = "Header";
            this.menuClearHeader.Click += new System.EventHandler(this.menuClearHeader_Click);
            // 
            // menuClearFeedback
            // 
            this.menuClearFeedback.Name = "menuClearFeedback";
            this.menuClearFeedback.Size = new System.Drawing.Size(124, 22);
            this.menuClearFeedback.Text = "Feedback";
            this.menuClearFeedback.Click += new System.EventHandler(this.menuClearFeedback_Click);
            // 
            // lstQuestions
            // 
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.Location = new System.Drawing.Point(12, 27);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(191, 563);
            this.lstQuestions.TabIndex = 1;
            // 
            // cmbApplicant
            // 
            this.cmbApplicant.FormattingEnabled = true;
            this.cmbApplicant.Location = new System.Drawing.Point(350, 27);
            this.cmbApplicant.Name = "cmbApplicant";
            this.cmbApplicant.Size = new System.Drawing.Size(413, 21);
            this.cmbApplicant.TabIndex = 2;
            // 
            // btnOpenCV
            // 
            this.btnOpenCV.Location = new System.Drawing.Point(899, 27);
            this.btnOpenCV.Name = "btnOpenCV";
            this.btnOpenCV.Size = new System.Drawing.Size(154, 56);
            this.btnOpenCV.TabIndex = 3;
            this.btnOpenCV.Text = "Open Applicant CV";
            this.btnOpenCV.UseVisualStyleBackColor = true;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(899, 476);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(154, 56);
            this.btnNextQuestion.TabIndex = 4;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            // 
            // btnFinishInterview
            // 
            this.btnFinishInterview.Location = new System.Drawing.Point(899, 538);
            this.btnFinishInterview.Name = "btnFinishInterview";
            this.btnFinishInterview.Size = new System.Drawing.Size(154, 56);
            this.btnFinishInterview.TabIndex = 5;
            this.btnFinishInterview.Text = "Finish Interview";
            this.btnFinishInterview.UseVisualStyleBackColor = true;
            // 
            // picApplicantPicture
            // 
            this.picApplicantPicture.Location = new System.Drawing.Point(899, 89);
            this.picApplicantPicture.Name = "picApplicantPicture";
            this.picApplicantPicture.Size = new System.Drawing.Size(154, 154);
            this.picApplicantPicture.TabIndex = 6;
            this.picApplicantPicture.TabStop = false;
            // 
            // grpFeedbackAnswers
            // 
            this.grpFeedbackAnswers.Controls.Add(this.txtAnswerFive);
            this.grpFeedbackAnswers.Controls.Add(this.txtAnswerFour);
            this.grpFeedbackAnswers.Controls.Add(this.txtAnswerThree);
            this.grpFeedbackAnswers.Controls.Add(this.txtAnswerTwo);
            this.grpFeedbackAnswers.Controls.Add(this.txtAnswerOne);
            this.grpFeedbackAnswers.Controls.Add(this.radAnswerFive);
            this.grpFeedbackAnswers.Controls.Add(this.radAnswerFour);
            this.grpFeedbackAnswers.Controls.Add(this.radAnswerThree);
            this.grpFeedbackAnswers.Controls.Add(this.radAnswerTwo);
            this.grpFeedbackAnswers.Controls.Add(this.radAnswerOne);
            this.grpFeedbackAnswers.Location = new System.Drawing.Point(209, 54);
            this.grpFeedbackAnswers.Name = "grpFeedbackAnswers";
            this.grpFeedbackAnswers.Size = new System.Drawing.Size(684, 536);
            this.grpFeedbackAnswers.TabIndex = 7;
            this.grpFeedbackAnswers.TabStop = false;
            this.grpFeedbackAnswers.Text = "Feedback Answers";
            // 
            // radAnswerOne
            // 
            this.radAnswerOne.AutoSize = true;
            this.radAnswerOne.Location = new System.Drawing.Point(6, 35);
            this.radAnswerOne.Name = "radAnswerOne";
            this.radAnswerOne.Size = new System.Drawing.Size(83, 17);
            this.radAnswerOne.TabIndex = 0;
            this.radAnswerOne.TabStop = true;
            this.radAnswerOne.Text = "Answer One";
            this.radAnswerOne.UseVisualStyleBackColor = true;
            // 
            // radAnswerTwo
            // 
            this.radAnswerTwo.AutoSize = true;
            this.radAnswerTwo.Location = new System.Drawing.Point(6, 125);
            this.radAnswerTwo.Name = "radAnswerTwo";
            this.radAnswerTwo.Size = new System.Drawing.Size(84, 17);
            this.radAnswerTwo.TabIndex = 1;
            this.radAnswerTwo.TabStop = true;
            this.radAnswerTwo.Text = "Answer Two";
            this.radAnswerTwo.UseVisualStyleBackColor = true;
            // 
            // radAnswerThree
            // 
            this.radAnswerThree.AutoSize = true;
            this.radAnswerThree.Location = new System.Drawing.Point(6, 215);
            this.radAnswerThree.Name = "radAnswerThree";
            this.radAnswerThree.Size = new System.Drawing.Size(91, 17);
            this.radAnswerThree.TabIndex = 2;
            this.radAnswerThree.TabStop = true;
            this.radAnswerThree.Text = "Answer Three";
            this.radAnswerThree.UseVisualStyleBackColor = true;
            // 
            // radAnswerFour
            // 
            this.radAnswerFour.AutoSize = true;
            this.radAnswerFour.Location = new System.Drawing.Point(6, 305);
            this.radAnswerFour.Name = "radAnswerFour";
            this.radAnswerFour.Size = new System.Drawing.Size(84, 17);
            this.radAnswerFour.TabIndex = 3;
            this.radAnswerFour.TabStop = true;
            this.radAnswerFour.Text = "Answer Four";
            this.radAnswerFour.UseVisualStyleBackColor = true;
            // 
            // radAnswerFive
            // 
            this.radAnswerFive.AutoSize = true;
            this.radAnswerFive.Location = new System.Drawing.Point(6, 395);
            this.radAnswerFive.Name = "radAnswerFive";
            this.radAnswerFive.Size = new System.Drawing.Size(83, 17);
            this.radAnswerFive.TabIndex = 4;
            this.radAnswerFive.TabStop = true;
            this.radAnswerFive.Text = "Answer Five";
            this.radAnswerFive.UseVisualStyleBackColor = true;
            // 
            // txtAnswerOne
            // 
            this.txtAnswerOne.Location = new System.Drawing.Point(97, 35);
            this.txtAnswerOne.Multiline = true;
            this.txtAnswerOne.Name = "txtAnswerOne";
            this.txtAnswerOne.Size = new System.Drawing.Size(581, 80);
            this.txtAnswerOne.TabIndex = 5;
            // 
            // txtAnswerTwo
            // 
            this.txtAnswerTwo.Location = new System.Drawing.Point(97, 125);
            this.txtAnswerTwo.Multiline = true;
            this.txtAnswerTwo.Name = "txtAnswerTwo";
            this.txtAnswerTwo.Size = new System.Drawing.Size(581, 80);
            this.txtAnswerTwo.TabIndex = 6;
            // 
            // txtAnswerThree
            // 
            this.txtAnswerThree.Location = new System.Drawing.Point(97, 215);
            this.txtAnswerThree.Multiline = true;
            this.txtAnswerThree.Name = "txtAnswerThree";
            this.txtAnswerThree.Size = new System.Drawing.Size(581, 80);
            this.txtAnswerThree.TabIndex = 7;
            // 
            // txtAnswerFour
            // 
            this.txtAnswerFour.Location = new System.Drawing.Point(97, 305);
            this.txtAnswerFour.Multiline = true;
            this.txtAnswerFour.Name = "txtAnswerFour";
            this.txtAnswerFour.Size = new System.Drawing.Size(581, 80);
            this.txtAnswerFour.TabIndex = 8;
            // 
            // txtAnswerFive
            // 
            this.txtAnswerFive.Location = new System.Drawing.Point(97, 395);
            this.txtAnswerFive.Multiline = true;
            this.txtAnswerFive.Name = "txtAnswerFive";
            this.txtAnswerFive.Size = new System.Drawing.Size(581, 80);
            this.txtAnswerFive.TabIndex = 9;
            // 
            // InterviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 606);
            this.Controls.Add(this.grpFeedbackAnswers);
            this.Controls.Add(this.picApplicantPicture);
            this.Controls.Add(this.btnFinishInterview);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnOpenCV);
            this.Controls.Add(this.cmbApplicant);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterviewForm";
            this.ShowIcon = false;
            this.Text = "Conduct Interview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeedbackForm_FormClosing);
            this.Load += new System.EventHandler(this.InterviewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApplicantPicture)).EndInit();
            this.grpFeedbackAnswers.ResumeLayout(false);
            this.grpFeedbackAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLoadTemp;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLoadApplicant;
        private System.Windows.Forms.ToolStripMenuItem menuLoadEmployee;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuClearHeader;
        private System.Windows.Forms.ToolStripMenuItem menuClearFeedback;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.ComboBox cmbApplicant;
        private System.Windows.Forms.Button btnOpenCV;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnFinishInterview;
        private System.Windows.Forms.PictureBox picApplicantPicture;
        private System.Windows.Forms.GroupBox grpFeedbackAnswers;
        private System.Windows.Forms.RadioButton radAnswerFive;
        private System.Windows.Forms.RadioButton radAnswerFour;
        private System.Windows.Forms.RadioButton radAnswerThree;
        private System.Windows.Forms.RadioButton radAnswerTwo;
        private System.Windows.Forms.RadioButton radAnswerOne;
        private System.Windows.Forms.TextBox txtAnswerFive;
        private System.Windows.Forms.TextBox txtAnswerFour;
        private System.Windows.Forms.TextBox txtAnswerThree;
        private System.Windows.Forms.TextBox txtAnswerTwo;
        private System.Windows.Forms.TextBox txtAnswerOne;
    }
}