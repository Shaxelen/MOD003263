namespace MOD003263_SoftwareEngineering.UI {
    partial class SettingsEntryForm {
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
            this.grpEmailLogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.txtEmailEmail = new System.Windows.Forms.TextBox();
            this.grpEmailAccetped = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAcceptedSubject = new System.Windows.Forms.TextBox();
            this.txtAcceptedBody = new System.Windows.Forms.TextBox();
            this.btnSaveAllSettings = new System.Windows.Forms.Button();
            this.btnEmailTest = new System.Windows.Forms.Button();
            this.grpEmailRejected = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRejectedSubject = new System.Windows.Forms.TextBox();
            this.txtRejectedBody = new System.Windows.Forms.TextBox();
            this.grpEmailLogin.SuspendLayout();
            this.grpEmailAccetped.SuspendLayout();
            this.grpEmailRejected.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmailLogin
            // 
            this.grpEmailLogin.Controls.Add(this.btnEmailTest);
            this.grpEmailLogin.Controls.Add(this.label2);
            this.grpEmailLogin.Controls.Add(this.label1);
            this.grpEmailLogin.Controls.Add(this.txtEmailPassword);
            this.grpEmailLogin.Controls.Add(this.txtEmailEmail);
            this.grpEmailLogin.Location = new System.Drawing.Point(12, 12);
            this.grpEmailLogin.Name = "grpEmailLogin";
            this.grpEmailLogin.Size = new System.Drawing.Size(510, 120);
            this.grpEmailLogin.TabIndex = 0;
            this.grpEmailLogin.TabStop = false;
            this.grpEmailLogin.Text = "Email Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.Location = new System.Drawing.Point(68, 56);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '*';
            this.txtEmailPassword.Size = new System.Drawing.Size(436, 20);
            this.txtEmailPassword.TabIndex = 1;
            // 
            // txtEmailEmail
            // 
            this.txtEmailEmail.Location = new System.Drawing.Point(68, 30);
            this.txtEmailEmail.Name = "txtEmailEmail";
            this.txtEmailEmail.Size = new System.Drawing.Size(436, 20);
            this.txtEmailEmail.TabIndex = 0;
            // 
            // grpEmailAccetped
            // 
            this.grpEmailAccetped.Controls.Add(this.label4);
            this.grpEmailAccetped.Controls.Add(this.label3);
            this.grpEmailAccetped.Controls.Add(this.txtAcceptedSubject);
            this.grpEmailAccetped.Controls.Add(this.txtAcceptedBody);
            this.grpEmailAccetped.Location = new System.Drawing.Point(12, 138);
            this.grpEmailAccetped.Name = "grpEmailAccetped";
            this.grpEmailAccetped.Size = new System.Drawing.Size(510, 427);
            this.grpEmailAccetped.TabIndex = 1;
            this.grpEmailAccetped.TabStop = false;
            this.grpEmailAccetped.Text = "Accepted Auto Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject:";
            // 
            // txtAcceptedSubject
            // 
            this.txtAcceptedSubject.Location = new System.Drawing.Point(58, 22);
            this.txtAcceptedSubject.Name = "txtAcceptedSubject";
            this.txtAcceptedSubject.Size = new System.Drawing.Size(446, 20);
            this.txtAcceptedSubject.TabIndex = 3;
            // 
            // txtAcceptedBody
            // 
            this.txtAcceptedBody.Location = new System.Drawing.Point(9, 66);
            this.txtAcceptedBody.Multiline = true;
            this.txtAcceptedBody.Name = "txtAcceptedBody";
            this.txtAcceptedBody.Size = new System.Drawing.Size(495, 355);
            this.txtAcceptedBody.TabIndex = 2;
            // 
            // btnSaveAllSettings
            // 
            this.btnSaveAllSettings.Location = new System.Drawing.Point(12, 571);
            this.btnSaveAllSettings.Name = "btnSaveAllSettings";
            this.btnSaveAllSettings.Size = new System.Drawing.Size(1041, 23);
            this.btnSaveAllSettings.TabIndex = 3;
            this.btnSaveAllSettings.Text = "Save All Settings";
            this.btnSaveAllSettings.UseVisualStyleBackColor = true;
            this.btnSaveAllSettings.Click += new System.EventHandler(this.btnSaveAllSettings_Click);
            // 
            // btnEmailTest
            // 
            this.btnEmailTest.Location = new System.Drawing.Point(9, 82);
            this.btnEmailTest.Name = "btnEmailTest";
            this.btnEmailTest.Size = new System.Drawing.Size(495, 23);
            this.btnEmailTest.TabIndex = 4;
            this.btnEmailTest.Text = "Test Email Connection";
            this.btnEmailTest.UseVisualStyleBackColor = true;
            this.btnEmailTest.Click += new System.EventHandler(this.btnEmailTest_Click);
            // 
            // grpEmailRejected
            // 
            this.grpEmailRejected.Controls.Add(this.label5);
            this.grpEmailRejected.Controls.Add(this.label6);
            this.grpEmailRejected.Controls.Add(this.txtRejectedSubject);
            this.grpEmailRejected.Controls.Add(this.txtRejectedBody);
            this.grpEmailRejected.Location = new System.Drawing.Point(543, 138);
            this.grpEmailRejected.Name = "grpEmailRejected";
            this.grpEmailRejected.Size = new System.Drawing.Size(510, 427);
            this.grpEmailRejected.TabIndex = 6;
            this.grpEmailRejected.TabStop = false;
            this.grpEmailRejected.Text = "Rejected Auto Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Body:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Subject:";
            // 
            // txtRejectedSubject
            // 
            this.txtRejectedSubject.Location = new System.Drawing.Point(58, 22);
            this.txtRejectedSubject.Name = "txtRejectedSubject";
            this.txtRejectedSubject.Size = new System.Drawing.Size(446, 20);
            this.txtRejectedSubject.TabIndex = 3;
            // 
            // txtRejectedBody
            // 
            this.txtRejectedBody.Location = new System.Drawing.Point(9, 66);
            this.txtRejectedBody.Multiline = true;
            this.txtRejectedBody.Name = "txtRejectedBody";
            this.txtRejectedBody.Size = new System.Drawing.Size(495, 355);
            this.txtRejectedBody.TabIndex = 2;
            // 
            // SettingsEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 606);
            this.Controls.Add(this.grpEmailRejected);
            this.Controls.Add(this.btnSaveAllSettings);
            this.Controls.Add(this.grpEmailAccetped);
            this.Controls.Add(this.grpEmailLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsEntryForm";
            this.ShowIcon = false;
            this.Text = "Edit Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsEntryForm_FormClosing);
            this.grpEmailLogin.ResumeLayout(false);
            this.grpEmailLogin.PerformLayout();
            this.grpEmailAccetped.ResumeLayout(false);
            this.grpEmailAccetped.PerformLayout();
            this.grpEmailRejected.ResumeLayout(false);
            this.grpEmailRejected.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmailLogin;
        private System.Windows.Forms.GroupBox grpEmailAccetped;
        private System.Windows.Forms.Button btnSaveAllSettings;
        private System.Windows.Forms.Button btnEmailTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.TextBox txtEmailEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcceptedSubject;
        private System.Windows.Forms.TextBox txtAcceptedBody;
        private System.Windows.Forms.GroupBox grpEmailRejected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRejectedSubject;
        private System.Windows.Forms.TextBox txtRejectedBody;
    }
}