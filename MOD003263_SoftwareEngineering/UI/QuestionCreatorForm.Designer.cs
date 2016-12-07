namespace MOD003263_SoftwareEngineering.UI {
    partial class QuestionCreatorForm {
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
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grbGenericFeedback = new System.Windows.Forms.GroupBox();
            this.lblScoreFour = new System.Windows.Forms.Label();
            this.lblScoreFive = new System.Windows.Forms.Label();
            this.lblScoreThree = new System.Windows.Forms.Label();
            this.lblScoreTwo = new System.Windows.Forms.Label();
            this.lblScoreOne = new System.Windows.Forms.Label();
            this.txtGenericFive = new System.Windows.Forms.TextBox();
            this.txtGenericThree = new System.Windows.Forms.TextBox();
            this.txtGenericTwo = new System.Windows.Forms.TextBox();
            this.txtGenericFour = new System.Windows.Forms.TextBox();
            this.txtGenericOne = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lstCategoryList = new System.Windows.Forms.ListBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.grbGenericFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(12, 25);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(347, 20);
            this.txtCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(9, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(374, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Question";
            // 
            // grbGenericFeedback
            // 
            this.grbGenericFeedback.Controls.Add(this.lblScoreFour);
            this.grbGenericFeedback.Controls.Add(this.lblScoreFive);
            this.grbGenericFeedback.Controls.Add(this.lblScoreThree);
            this.grbGenericFeedback.Controls.Add(this.lblScoreTwo);
            this.grbGenericFeedback.Controls.Add(this.lblScoreOne);
            this.grbGenericFeedback.Controls.Add(this.txtGenericFive);
            this.grbGenericFeedback.Controls.Add(this.txtGenericThree);
            this.grbGenericFeedback.Controls.Add(this.txtGenericTwo);
            this.grbGenericFeedback.Controls.Add(this.txtGenericFour);
            this.grbGenericFeedback.Controls.Add(this.txtGenericOne);
            this.grbGenericFeedback.Location = new System.Drawing.Point(377, 51);
            this.grbGenericFeedback.Name = "grbGenericFeedback";
            this.grbGenericFeedback.Size = new System.Drawing.Size(676, 500);
            this.grbGenericFeedback.TabIndex = 4;
            this.grbGenericFeedback.TabStop = false;
            // 
            // lblScoreFour
            // 
            this.lblScoreFour.AutoSize = true;
            this.lblScoreFour.Location = new System.Drawing.Point(3, 307);
            this.lblScoreFour.Name = "lblScoreFour";
            this.lblScoreFour.Size = new System.Drawing.Size(64, 13);
            this.lblScoreFour.TabIndex = 2;
            this.lblScoreFour.Text = "Feedback 4";
            // 
            // lblScoreFive
            // 
            this.lblScoreFive.AutoSize = true;
            this.lblScoreFive.Location = new System.Drawing.Point(3, 404);
            this.lblScoreFive.Name = "lblScoreFive";
            this.lblScoreFive.Size = new System.Drawing.Size(64, 13);
            this.lblScoreFive.TabIndex = 2;
            this.lblScoreFive.Text = "Feedback 5";
            // 
            // lblScoreThree
            // 
            this.lblScoreThree.AutoSize = true;
            this.lblScoreThree.Location = new System.Drawing.Point(3, 210);
            this.lblScoreThree.Name = "lblScoreThree";
            this.lblScoreThree.Size = new System.Drawing.Size(64, 13);
            this.lblScoreThree.TabIndex = 2;
            this.lblScoreThree.Text = "Feedback 3";
            // 
            // lblScoreTwo
            // 
            this.lblScoreTwo.AutoSize = true;
            this.lblScoreTwo.Location = new System.Drawing.Point(3, 113);
            this.lblScoreTwo.Name = "lblScoreTwo";
            this.lblScoreTwo.Size = new System.Drawing.Size(64, 13);
            this.lblScoreTwo.TabIndex = 2;
            this.lblScoreTwo.Text = "Feedback 2";
            // 
            // lblScoreOne
            // 
            this.lblScoreOne.AutoSize = true;
            this.lblScoreOne.Location = new System.Drawing.Point(3, 16);
            this.lblScoreOne.Name = "lblScoreOne";
            this.lblScoreOne.Size = new System.Drawing.Size(64, 13);
            this.lblScoreOne.TabIndex = 2;
            this.lblScoreOne.Text = "Feedback 1";
            // 
            // txtGenericFive
            // 
            this.txtGenericFive.Location = new System.Drawing.Point(0, 420);
            this.txtGenericFive.Multiline = true;
            this.txtGenericFive.Name = "txtGenericFive";
            this.txtGenericFive.Size = new System.Drawing.Size(676, 78);
            this.txtGenericFive.TabIndex = 1;
            // 
            // txtGenericThree
            // 
            this.txtGenericThree.Location = new System.Drawing.Point(0, 226);
            this.txtGenericThree.Multiline = true;
            this.txtGenericThree.Name = "txtGenericThree";
            this.txtGenericThree.Size = new System.Drawing.Size(676, 78);
            this.txtGenericThree.TabIndex = 1;
            // 
            // txtGenericTwo
            // 
            this.txtGenericTwo.Location = new System.Drawing.Point(0, 129);
            this.txtGenericTwo.Multiline = true;
            this.txtGenericTwo.Name = "txtGenericTwo";
            this.txtGenericTwo.Size = new System.Drawing.Size(676, 78);
            this.txtGenericTwo.TabIndex = 1;
            // 
            // txtGenericFour
            // 
            this.txtGenericFour.Location = new System.Drawing.Point(0, 323);
            this.txtGenericFour.Multiline = true;
            this.txtGenericFour.Name = "txtGenericFour";
            this.txtGenericFour.Size = new System.Drawing.Size(676, 78);
            this.txtGenericFour.TabIndex = 1;
            // 
            // txtGenericOne
            // 
            this.txtGenericOne.Location = new System.Drawing.Point(0, 32);
            this.txtGenericOne.Multiline = true;
            this.txtGenericOne.Name = "txtGenericOne";
            this.txtGenericOne.Size = new System.Drawing.Size(676, 78);
            this.txtGenericOne.TabIndex = 1;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(377, 25);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(676, 20);
            this.txtQuestion.TabIndex = 1;
            // 
            // lstCategoryList
            // 
            this.lstCategoryList.FormattingEnabled = true;
            this.lstCategoryList.Location = new System.Drawing.Point(12, 103);
            this.lstCategoryList.Name = "lstCategoryList";
            this.lstCategoryList.Size = new System.Drawing.Size(161, 498);
            this.lstCategoryList.TabIndex = 5;
            this.lstCategoryList.SelectedIndexChanged += new System.EventHandler(this.lstCategoryList_SelectedIndexChanged);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(12, 48);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(347, 23);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(377, 555);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(333, 39);
            this.btnAddQuestion.TabIndex = 7;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // lstQuestions
            // 
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.Location = new System.Drawing.Point(179, 103);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(180, 498);
            this.lstQuestions.TabIndex = 8;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category Questions";
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Location = new System.Drawing.Point(716, 557);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(337, 37);
            this.btnSaveQuestion.TabIndex = 11;
            this.btnSaveQuestion.Text = "Save Question";
            this.btnSaveQuestion.UseVisualStyleBackColor = true;
            this.btnSaveQuestion.Visible = false;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // QuestionCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 606);
            this.Controls.Add(this.btnSaveQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lstCategoryList);
            this.Controls.Add(this.grbGenericFeedback);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionCreatorForm";
            this.ShowIcon = false;
            this.Text = "Question Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionCreatorForm_FormClosing);
            this.grbGenericFeedback.ResumeLayout(false);
            this.grbGenericFeedback.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox grbGenericFeedback;
        private System.Windows.Forms.Label lblScoreFour;
        private System.Windows.Forms.Label lblScoreFive;
        private System.Windows.Forms.Label lblScoreThree;
        private System.Windows.Forms.Label lblScoreTwo;
        private System.Windows.Forms.Label lblScoreOne;
        private System.Windows.Forms.TextBox txtGenericFive;
        private System.Windows.Forms.TextBox txtGenericThree;
        private System.Windows.Forms.TextBox txtGenericTwo;
        private System.Windows.Forms.TextBox txtGenericFour;
        private System.Windows.Forms.TextBox txtGenericOne;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.ListBox lstCategoryList;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveQuestion;
    }
}