namespace MOD003263_SoftwareEngineering.UI {
    partial class FilterApplicantsForm {
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
            this.lblPosAppliedFor = new System.Windows.Forms.Label();
            this.btnAcceptSelected = new System.Windows.Forms.Button();
            this.btnRejectSelected = new System.Windows.Forms.Button();
            this.lstAccepted = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstRejected = new System.Windows.Forms.ListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccSubject = new System.Windows.Forms.TextBox();
            this.txtAccBody = new System.Windows.Forms.TextBox();
            this.btnEmailAccepted = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRejSubject = new System.Windows.Forms.TextBox();
            this.txtRejBody = new System.Windows.Forms.TextBox();
            this.btnEmailRejected = new System.Windows.Forms.Button();
            this.grbPersonData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFeedbackList
            // 
            this.lstFeedbackList.FormattingEnabled = true;
            this.lstFeedbackList.Location = new System.Drawing.Point(12, 51);
            this.lstFeedbackList.Name = "lstFeedbackList";
            this.lstFeedbackList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFeedbackList.Size = new System.Drawing.Size(199, 498);
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
            this.grbPersonData.Location = new System.Drawing.Point(227, 12);
            this.grbPersonData.Name = "grbPersonData";
            this.grbPersonData.Size = new System.Drawing.Size(348, 128);
            this.grbPersonData.TabIndex = 1;
            this.grbPersonData.TabStop = false;
            this.grbPersonData.Text = "Person Data";
            // 
            // txtAdditionalComments
            // 
            this.txtAdditionalComments.Location = new System.Drawing.Point(130, 98);
            this.txtAdditionalComments.Name = "txtAdditionalComments";
            this.txtAdditionalComments.Size = new System.Drawing.Size(212, 20);
            this.txtAdditionalComments.TabIndex = 9;
            // 
            // lblAdditionalComments
            // 
            this.lblAdditionalComments.AutoSize = true;
            this.lblAdditionalComments.Location = new System.Drawing.Point(7, 101);
            this.lblAdditionalComments.Name = "lblAdditionalComments";
            this.lblAdditionalComments.Size = new System.Drawing.Size(105, 13);
            this.lblAdditionalComments.TabIndex = 8;
            this.lblAdditionalComments.Text = "Additional Comments";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Location = new System.Drawing.Point(7, 74);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(62, 13);
            this.lblTotalScore.TabIndex = 7;
            this.lblTotalScore.Text = "Total Score";
            // 
            // txtTotalScore
            // 
            this.txtTotalScore.Location = new System.Drawing.Point(130, 71);
            this.txtTotalScore.Name = "txtTotalScore";
            this.txtTotalScore.Size = new System.Drawing.Size(212, 20);
            this.txtTotalScore.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(130, 44);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(130, 17);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPosAppliedFor
            // 
            this.lblPosAppliedFor.AutoSize = true;
            this.lblPosAppliedFor.Location = new System.Drawing.Point(12, 29);
            this.lblPosAppliedFor.Name = "lblPosAppliedFor";
            this.lblPosAppliedFor.Size = new System.Drawing.Size(100, 13);
            this.lblPosAppliedFor.TabIndex = 0;
            this.lblPosAppliedFor.Text = "Position Applied For";
            // 
            // btnAcceptSelected
            // 
            this.btnAcceptSelected.Location = new System.Drawing.Point(227, 146);
            this.btnAcceptSelected.Name = "btnAcceptSelected";
            this.btnAcceptSelected.Size = new System.Drawing.Size(100, 40);
            this.btnAcceptSelected.TabIndex = 2;
            this.btnAcceptSelected.Text = "Accept Selected";
            this.btnAcceptSelected.UseVisualStyleBackColor = true;
            this.btnAcceptSelected.Click += new System.EventHandler(this.btnAcceptSelected_Click);
            // 
            // btnRejectSelected
            // 
            this.btnRejectSelected.Location = new System.Drawing.Point(475, 146);
            this.btnRejectSelected.Name = "btnRejectSelected";
            this.btnRejectSelected.Size = new System.Drawing.Size(100, 40);
            this.btnRejectSelected.TabIndex = 3;
            this.btnRejectSelected.Text = "Reject Selected";
            this.btnRejectSelected.UseVisualStyleBackColor = true;
            this.btnRejectSelected.Click += new System.EventHandler(this.btnRejectSelected_Click);
            // 
            // lstAccepted
            // 
            this.lstAccepted.FormattingEnabled = true;
            this.lstAccepted.Location = new System.Drawing.Point(6, 19);
            this.lstAccepted.Name = "lstAccepted";
            this.lstAccepted.Size = new System.Drawing.Size(215, 550);
            this.lstAccepted.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAccepted);
            this.groupBox1.Location = new System.Drawing.Point(593, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 582);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accepted Applicants";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstRejected);
            this.groupBox2.Location = new System.Drawing.Point(826, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 582);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rejected Applicants";
            // 
            // lstRejected
            // 
            this.lstRejected.FormattingEnabled = true;
            this.lstRejected.Location = new System.Drawing.Point(6, 19);
            this.lstRejected.Name = "lstRejected";
            this.lstRejected.Size = new System.Drawing.Size(215, 550);
            this.lstRejected.TabIndex = 5;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(12, 554);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(199, 40);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtAccSubject);
            this.groupBox4.Controls.Add(this.txtAccBody);
            this.groupBox4.Controls.Add(this.btnEmailAccepted);
            this.groupBox4.Location = new System.Drawing.Point(227, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 383);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Accepted Email Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subject:";
            // 
            // txtAccSubject
            // 
            this.txtAccSubject.Location = new System.Drawing.Point(58, 19);
            this.txtAccSubject.Name = "txtAccSubject";
            this.txtAccSubject.Size = new System.Drawing.Size(107, 20);
            this.txtAccSubject.TabIndex = 10;
            // 
            // txtAccBody
            // 
            this.txtAccBody.Location = new System.Drawing.Point(6, 45);
            this.txtAccBody.Multiline = true;
            this.txtAccBody.Name = "txtAccBody";
            this.txtAccBody.Size = new System.Drawing.Size(159, 286);
            this.txtAccBody.TabIndex = 9;
            // 
            // btnEmailAccepted
            // 
            this.btnEmailAccepted.Location = new System.Drawing.Point(6, 337);
            this.btnEmailAccepted.Name = "btnEmailAccepted";
            this.btnEmailAccepted.Size = new System.Drawing.Size(159, 40);
            this.btnEmailAccepted.TabIndex = 4;
            this.btnEmailAccepted.Text = "Email Accepted";
            this.btnEmailAccepted.UseVisualStyleBackColor = true;
            this.btnEmailAccepted.Click += new System.EventHandler(this.btnEmailAccepted_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtRejSubject);
            this.groupBox3.Controls.Add(this.txtRejBody);
            this.groupBox3.Controls.Add(this.btnEmailRejected);
            this.groupBox3.Location = new System.Drawing.Point(404, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 383);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rejected Email Text";
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
            // txtRejSubject
            // 
            this.txtRejSubject.Location = new System.Drawing.Point(58, 19);
            this.txtRejSubject.Name = "txtRejSubject";
            this.txtRejSubject.Size = new System.Drawing.Size(107, 20);
            this.txtRejSubject.TabIndex = 10;
            // 
            // txtRejBody
            // 
            this.txtRejBody.Location = new System.Drawing.Point(6, 45);
            this.txtRejBody.Multiline = true;
            this.txtRejBody.Name = "txtRejBody";
            this.txtRejBody.Size = new System.Drawing.Size(159, 286);
            this.txtRejBody.TabIndex = 9;
            // 
            // btnEmailRejected
            // 
            this.btnEmailRejected.Location = new System.Drawing.Point(6, 337);
            this.btnEmailRejected.Name = "btnEmailRejected";
            this.btnEmailRejected.Size = new System.Drawing.Size(159, 40);
            this.btnEmailRejected.TabIndex = 4;
            this.btnEmailRejected.Text = "EmailRejected";
            this.btnEmailRejected.UseVisualStyleBackColor = true;
            this.btnEmailRejected.Click += new System.EventHandler(this.btnEmailRejected_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRejectSelected);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnAcceptSelected);
            this.Controls.Add(this.grbPersonData);
            this.Controls.Add(this.lstFeedbackList);
            this.Controls.Add(this.lblPosAppliedFor);
            this.Name = "FilterForm";
            this.Text = "Filter Applicants";
            this.grbPersonData.ResumeLayout(false);
            this.grbPersonData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFeedbackList;
        private System.Windows.Forms.GroupBox grbPersonData;
        private System.Windows.Forms.Button btnAcceptSelected;
        private System.Windows.Forms.Button btnRejectSelected;
        private System.Windows.Forms.Label lblPosAppliedFor;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtAdditionalComments;
        private System.Windows.Forms.Label lblAdditionalComments;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.TextBox txtTotalScore;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ListBox lstAccepted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstRejected;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccSubject;
        private System.Windows.Forms.TextBox txtAccBody;
        private System.Windows.Forms.Button btnEmailAccepted;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRejSubject;
        private System.Windows.Forms.TextBox txtRejBody;
        private System.Windows.Forms.Button btnEmailRejected;
    }
}