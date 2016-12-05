namespace MOD003263_SoftwareEngineering.UI {
    partial class FilterForm {
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
            this.lstFeedbackList = new System.Windows.Forms.ListBox();
            this.grbPersonData = new System.Windows.Forms.GroupBox();
            this.txtAdditionalComments = new System.Windows.Forms.TextBox();
            this.lblAdditionalComments = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.txtTotalScore = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtPosAppliedFor = new System.Windows.Forms.TextBox();
            this.lblPosAppliedFor = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbPersonData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFeedbackList
            // 
            this.lstFeedbackList.FormattingEnabled = true;
            this.lstFeedbackList.Location = new System.Drawing.Point(12, 12);
            this.lstFeedbackList.Name = "lstFeedbackList";
            this.lstFeedbackList.Size = new System.Drawing.Size(199, 576);
            this.lstFeedbackList.TabIndex = 0;
            this.lstFeedbackList.SelectedIndexChanged += new System.EventHandler(this.lstFeedbackList_SelectedIndexChanged);
            // 
            // grbPersonData
            // 
            this.grbPersonData.Controls.Add(this.txtAdditionalComments);
            this.grbPersonData.Controls.Add(this.lblAdditionalComments);
            this.grbPersonData.Controls.Add(this.lblTotalScore);
            this.grbPersonData.Controls.Add(this.txtTotalScore);
            this.grbPersonData.Controls.Add(this.txtLastName);
            this.grbPersonData.Controls.Add(this.lblLastName);
            this.grbPersonData.Controls.Add(this.txtFirstName);
            this.grbPersonData.Controls.Add(this.lblFirstName);
            this.grbPersonData.Controls.Add(this.txtPosAppliedFor);
            this.grbPersonData.Controls.Add(this.lblPosAppliedFor);
            this.grbPersonData.Location = new System.Drawing.Point(217, 12);
            this.grbPersonData.Name = "grbPersonData";
            this.grbPersonData.Size = new System.Drawing.Size(354, 158);
            this.grbPersonData.TabIndex = 1;
            this.grbPersonData.TabStop = false;
            this.grbPersonData.Text = "Person Data";
            // 
            // txtAdditionalComments
            // 
            this.txtAdditionalComments.Location = new System.Drawing.Point(130, 124);
            this.txtAdditionalComments.Name = "txtAdditionalComments";
            this.txtAdditionalComments.Size = new System.Drawing.Size(138, 20);
            this.txtAdditionalComments.TabIndex = 9;
            // 
            // lblAdditionalComments
            // 
            this.lblAdditionalComments.AutoSize = true;
            this.lblAdditionalComments.Location = new System.Drawing.Point(7, 127);
            this.lblAdditionalComments.Name = "lblAdditionalComments";
            this.lblAdditionalComments.Size = new System.Drawing.Size(105, 13);
            this.lblAdditionalComments.TabIndex = 8;
            this.lblAdditionalComments.Text = "Additional Comments";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Location = new System.Drawing.Point(7, 100);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(62, 13);
            this.lblTotalScore.TabIndex = 7;
            this.lblTotalScore.Text = "Total Score";
            // 
            // txtTotalScore
            // 
            this.txtTotalScore.Location = new System.Drawing.Point(130, 97);
            this.txtTotalScore.Name = "txtTotalScore";
            this.txtTotalScore.Size = new System.Drawing.Size(138, 20);
            this.txtTotalScore.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(130, 70);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(138, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 73);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(130, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(138, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // txtPosAppliedFor
            // 
            this.txtPosAppliedFor.Location = new System.Drawing.Point(130, 17);
            this.txtPosAppliedFor.Name = "txtPosAppliedFor";
            this.txtPosAppliedFor.Size = new System.Drawing.Size(138, 20);
            this.txtPosAppliedFor.TabIndex = 1;
            // 
            // lblPosAppliedFor
            // 
            this.lblPosAppliedFor.AutoSize = true;
            this.lblPosAppliedFor.Location = new System.Drawing.Point(7, 20);
            this.lblPosAppliedFor.Name = "lblPosAppliedFor";
            this.lblPosAppliedFor.Size = new System.Drawing.Size(100, 13);
            this.lblPosAppliedFor.TabIndex = 0;
            this.lblPosAppliedFor.Text = "Position Applied For";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(255, 186);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 40);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(445, 186);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(100, 40);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(120, 266);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(100, 40);
            this.btnEmail.TabIndex = 4;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 550);
            this.listBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(593, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 582);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accepted Applicants";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(826, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 582);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rejected Applicants";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(215, 550);
            this.listBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 215);
            this.textBox1.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btnEmail);
            this.groupBox3.Location = new System.Drawing.Point(227, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 319);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email Body Text";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Subject:";
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.grbPersonData);
            this.Controls.Add(this.lstFeedbackList);
            this.Name = "FilterForm";
            this.Text = "Filter Applicants";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterForm_FormClosing);
            this.grbPersonData.ResumeLayout(false);
            this.grbPersonData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFeedbackList;
        private System.Windows.Forms.GroupBox grbPersonData;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.TextBox txtPosAppliedFor;
        private System.Windows.Forms.Label lblPosAppliedFor;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtAdditionalComments;
        private System.Windows.Forms.Label lblAdditionalComments;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.TextBox txtTotalScore;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}