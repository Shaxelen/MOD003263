namespace MOD003263_SoftwareEngineering {
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtPosAppliedFor = new System.Windows.Forms.TextBox();
            this.lblPosAppliedFor = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTotalScore = new System.Windows.Forms.TextBox();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblAdditionalComments = new System.Windows.Forms.Label();
            this.txtAdditionalComments = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.grbPersonData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFeedbackList
            // 
            this.lstFeedbackList.FormattingEnabled = true;
            this.lstFeedbackList.Location = new System.Drawing.Point(12, 12);
            this.lstFeedbackList.Name = "lstFeedbackList";
            this.lstFeedbackList.Size = new System.Drawing.Size(134, 264);
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
            this.grbPersonData.Location = new System.Drawing.Point(152, 12);
            this.grbPersonData.Name = "grbPersonData";
            this.grbPersonData.Size = new System.Drawing.Size(354, 158);
            this.grbPersonData.TabIndex = 1;
            this.grbPersonData.TabStop = false;
            this.grbPersonData.Text = "Person Data";
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
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
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
            this.txtPosAppliedFor.TextChanged += new System.EventHandler(this.txtPosAppliedFor_TextChanged);
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
            this.btnAccept.Location = new System.Drawing.Point(205, 186);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 40);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(356, 186);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(100, 40);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(130, 70);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(138, 20);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtTotalScore
            // 
            this.txtTotalScore.Location = new System.Drawing.Point(130, 97);
            this.txtTotalScore.Name = "txtTotalScore";
            this.txtTotalScore.Size = new System.Drawing.Size(138, 20);
            this.txtTotalScore.TabIndex = 6;
            this.txtTotalScore.TextChanged += new System.EventHandler(this.txtTotalScore_TextChanged);
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
            // lblAdditionalComments
            // 
            this.lblAdditionalComments.AutoSize = true;
            this.lblAdditionalComments.Location = new System.Drawing.Point(7, 127);
            this.lblAdditionalComments.Name = "lblAdditionalComments";
            this.lblAdditionalComments.Size = new System.Drawing.Size(105, 13);
            this.lblAdditionalComments.TabIndex = 8;
            this.lblAdditionalComments.Text = "Additional Comments";
            // 
            // txtAdditionalComments
            // 
            this.txtAdditionalComments.Location = new System.Drawing.Point(130, 124);
            this.txtAdditionalComments.Name = "txtAdditionalComments";
            this.txtAdditionalComments.Size = new System.Drawing.Size(138, 20);
            this.txtAdditionalComments.TabIndex = 9;
            this.txtAdditionalComments.TextChanged += new System.EventHandler(this.txtAdditionalComments_TextChanged);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(282, 232);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(100, 40);
            this.btnEmail.TabIndex = 4;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 288);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.grbPersonData);
            this.Controls.Add(this.lstFeedbackList);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.grbPersonData.ResumeLayout(false);
            this.grbPersonData.PerformLayout();
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
    }
}