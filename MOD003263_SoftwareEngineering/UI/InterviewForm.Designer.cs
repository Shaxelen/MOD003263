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
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.cmbApplicant = new System.Windows.Forms.ComboBox();
            this.btnOpenCV = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnFinishInterview = new System.Windows.Forms.Button();
            this.picApplicantPicture = new System.Windows.Forms.PictureBox();
            this.grpFeedbackAnswers = new System.Windows.Forms.GroupBox();
            this.txtAnswerFive = new System.Windows.Forms.TextBox();
            this.txtAnswerFour = new System.Windows.Forms.TextBox();
            this.txtAnswerThree = new System.Windows.Forms.TextBox();
            this.txtAnswerTwo = new System.Windows.Forms.TextBox();
            this.txtAnswerOne = new System.Windows.Forms.TextBox();
            this.radAnswerFive = new System.Windows.Forms.RadioButton();
            this.radAnswerFour = new System.Windows.Forms.RadioButton();
            this.radAnswerThree = new System.Windows.Forms.RadioButton();
            this.radAnswerTwo = new System.Windows.Forms.RadioButton();
            this.radAnswerOne = new System.Windows.Forms.RadioButton();
            this.btnLoadApplicant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picApplicantPicture)).BeginInit();
            this.grpFeedbackAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstQuestions
            // 
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.Location = new System.Drawing.Point(12, 14);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(191, 576);
            this.lstQuestions.TabIndex = 1;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            // 
            // cmbApplicant
            // 
            this.cmbApplicant.FormattingEnabled = true;
            this.cmbApplicant.Location = new System.Drawing.Point(350, 27);
            this.cmbApplicant.Name = "cmbApplicant";
            this.cmbApplicant.Size = new System.Drawing.Size(372, 21);
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
            this.btnOpenCV.Click += new System.EventHandler(this.btnOpenCV_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(899, 476);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(154, 56);
            this.btnNextQuestion.TabIndex = 4;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnFinishInterview
            // 
            this.btnFinishInterview.Location = new System.Drawing.Point(899, 538);
            this.btnFinishInterview.Name = "btnFinishInterview";
            this.btnFinishInterview.Size = new System.Drawing.Size(154, 56);
            this.btnFinishInterview.TabIndex = 5;
            this.btnFinishInterview.Text = "Finish Interview";
            this.btnFinishInterview.UseVisualStyleBackColor = true;
            this.btnFinishInterview.Click += new System.EventHandler(this.btnFinishInterview_Click);
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
            // txtAnswerFive
            // 
            this.txtAnswerFive.Location = new System.Drawing.Point(97, 395);
            this.txtAnswerFive.Multiline = true;
            this.txtAnswerFive.Name = "txtAnswerFive";
            this.txtAnswerFive.Size = new System.Drawing.Size(581, 80);
            this.txtAnswerFive.TabIndex = 9;
            // 
            // txtAnswerFour
            // 
            this.txtAnswerFour.Location = new System.Drawing.Point(97, 305);
            this.txtAnswerFour.Multiline = true;
            this.txtAnswerFour.Name = "txtAnswerFour";
            this.txtAnswerFour.Size = new System.Drawing.Size(581, 80);
            this.txtAnswerFour.TabIndex = 8;
            // 
            // txtAnswerThree
            // 
            this.txtAnswerThree.Location = new System.Drawing.Point(97, 215);
            this.txtAnswerThree.Multiline = true;
            this.txtAnswerThree.Name = "txtAnswerThree";
            this.txtAnswerThree.Size = new System.Drawing.Size(581, 80);
            this.txtAnswerThree.TabIndex = 7;
            // 
            // txtAnswerTwo
            // 
            this.txtAnswerTwo.Location = new System.Drawing.Point(97, 125);
            this.txtAnswerTwo.Multiline = true;
            this.txtAnswerTwo.Name = "txtAnswerTwo";
            this.txtAnswerTwo.Size = new System.Drawing.Size(581, 80);
            this.txtAnswerTwo.TabIndex = 6;
            // 
            // txtAnswerOne
            // 
            this.txtAnswerOne.Location = new System.Drawing.Point(97, 35);
            this.txtAnswerOne.Multiline = true;
            this.txtAnswerOne.Name = "txtAnswerOne";
            this.txtAnswerOne.Size = new System.Drawing.Size(581, 80);
            this.txtAnswerOne.TabIndex = 5;
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
            // btnLoadApplicant
            // 
            this.btnLoadApplicant.Location = new System.Drawing.Point(728, 27);
            this.btnLoadApplicant.Name = "btnLoadApplicant";
            this.btnLoadApplicant.Size = new System.Drawing.Size(93, 23);
            this.btnLoadApplicant.TabIndex = 8;
            this.btnLoadApplicant.Text = "Load Applicant";
            this.btnLoadApplicant.UseVisualStyleBackColor = true;
            this.btnLoadApplicant.Click += new System.EventHandler(this.btnLoadApplicant_Click);
            // 
            // InterviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 606);
            this.Controls.Add(this.btnLoadApplicant);
            this.Controls.Add(this.grpFeedbackAnswers);
            this.Controls.Add(this.picApplicantPicture);
            this.Controls.Add(this.btnFinishInterview);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnOpenCV);
            this.Controls.Add(this.cmbApplicant);
            this.Controls.Add(this.lstQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterviewForm";
            this.ShowIcon = false;
            this.Text = "Conduct Interview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeedbackForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picApplicantPicture)).EndInit();
            this.grpFeedbackAnswers.ResumeLayout(false);
            this.grpFeedbackAnswers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnLoadApplicant;
    }
}