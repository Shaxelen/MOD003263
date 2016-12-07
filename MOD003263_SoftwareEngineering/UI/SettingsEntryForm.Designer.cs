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
            this.grpEmailAccetped = new System.Windows.Forms.GroupBox();
            this.grpEmailRejected = new System.Windows.Forms.GroupBox();
            this.btnSaveAllSettings = new System.Windows.Forms.Button();
            this.btnEmailTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpEmailLogin
            // 
            this.grpEmailLogin.Location = new System.Drawing.Point(12, 12);
            this.grpEmailLogin.Name = "grpEmailLogin";
            this.grpEmailLogin.Size = new System.Drawing.Size(510, 200);
            this.grpEmailLogin.TabIndex = 0;
            this.grpEmailLogin.TabStop = false;
            this.grpEmailLogin.Text = "Email Login";
            // 
            // grpEmailAccetped
            // 
            this.grpEmailAccetped.Location = new System.Drawing.Point(12, 218);
            this.grpEmailAccetped.Name = "grpEmailAccetped";
            this.grpEmailAccetped.Size = new System.Drawing.Size(510, 347);
            this.grpEmailAccetped.TabIndex = 1;
            this.grpEmailAccetped.TabStop = false;
            this.grpEmailAccetped.Text = "Accepted Auto Information";
            // 
            // grpEmailRejected
            // 
            this.grpEmailRejected.Location = new System.Drawing.Point(543, 218);
            this.grpEmailRejected.Name = "grpEmailRejected";
            this.grpEmailRejected.Size = new System.Drawing.Size(510, 347);
            this.grpEmailRejected.TabIndex = 2;
            this.grpEmailRejected.TabStop = false;
            this.grpEmailRejected.Text = "Rejected Auto Information";
            // 
            // btnSaveAllSettings
            // 
            this.btnSaveAllSettings.Location = new System.Drawing.Point(543, 189);
            this.btnSaveAllSettings.Name = "btnSaveAllSettings";
            this.btnSaveAllSettings.Size = new System.Drawing.Size(510, 23);
            this.btnSaveAllSettings.TabIndex = 3;
            this.btnSaveAllSettings.Text = "Save All Settings";
            this.btnSaveAllSettings.UseVisualStyleBackColor = true;
            // 
            // btnEmailTest
            // 
            this.btnEmailTest.Location = new System.Drawing.Point(543, 160);
            this.btnEmailTest.Name = "btnEmailTest";
            this.btnEmailTest.Size = new System.Drawing.Size(510, 23);
            this.btnEmailTest.TabIndex = 4;
            this.btnEmailTest.Text = "Test Email Connection";
            this.btnEmailTest.UseVisualStyleBackColor = true;
            // 
            // SettingsEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 606);
            this.Controls.Add(this.btnEmailTest);
            this.Controls.Add(this.btnSaveAllSettings);
            this.Controls.Add(this.grpEmailRejected);
            this.Controls.Add(this.grpEmailAccetped);
            this.Controls.Add(this.grpEmailLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsEntryForm";
            this.ShowIcon = false;
            this.Text = "Edit Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsEntryForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmailLogin;
        private System.Windows.Forms.GroupBox grpEmailAccetped;
        private System.Windows.Forms.GroupBox grpEmailRejected;
        private System.Windows.Forms.Button btnSaveAllSettings;
        private System.Windows.Forms.Button btnEmailTest;
    }
}