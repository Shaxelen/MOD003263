namespace MOD003263_SoftwareEngineering.Forms {
    partial class FeedbackForm {
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
            this.lblTemplateName = new System.Windows.Forms.Label();
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.grbFeedbackTemplate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppImage)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
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
            this.menuLoadTemp.Size = new System.Drawing.Size(152, 22);
            this.menuLoadTemp.Text = "Template";
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoadApplicant,
            this.menuLoadEmployee});
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personToolStripMenuItem.Text = "Person";
            // 
            // menuLoadApplicant
            // 
            this.menuLoadApplicant.Name = "menuLoadApplicant";
            this.menuLoadApplicant.Size = new System.Drawing.Size(152, 22);
            this.menuLoadApplicant.Text = "Applicant";
            // 
            // menuLoadEmployee
            // 
            this.menuLoadEmployee.Name = "menuLoadEmployee";
            this.menuLoadEmployee.Size = new System.Drawing.Size(152, 22);
            this.menuLoadEmployee.Text = "Employee";
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
            this.menuSave.Size = new System.Drawing.Size(152, 22);
            this.menuSave.Text = "Save";
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(152, 22);
            this.menuSaveAs.Text = "Save As";
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
            this.menuClearHeader.Size = new System.Drawing.Size(152, 22);
            this.menuClearHeader.Text = "Header";
            // 
            // menuClearFeedback
            // 
            this.menuClearFeedback.Name = "menuClearFeedback";
            this.menuClearFeedback.Size = new System.Drawing.Size(152, 22);
            this.menuClearFeedback.Text = "Feedback";
            // 
            // grbFeedbackTemplate
            // 
            this.grbFeedbackTemplate.AutoSize = true;
            this.grbFeedbackTemplate.Controls.Add(this.panelQuestions);
            this.grbFeedbackTemplate.Controls.Add(this.groupBox1);
            this.grbFeedbackTemplate.Location = new System.Drawing.Point(4, 60);
            this.grbFeedbackTemplate.Name = "grbFeedbackTemplate";
            this.grbFeedbackTemplate.Size = new System.Drawing.Size(588, 601);
            this.grbFeedbackTemplate.TabIndex = 6;
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
            this.groupBox1.Size = new System.Drawing.Size(575, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            // 
            // txtFeedbacker
            // 
            this.txtFeedbacker.Location = new System.Drawing.Point(215, 97);
            this.txtFeedbacker.Name = "txtFeedbacker";
            this.txtFeedbacker.Size = new System.Drawing.Size(182, 20);
            this.txtFeedbacker.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(442, 97);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(428, 71);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(141, 20);
            this.txtPosition.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(215, 71);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(154, 20);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(215, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(354, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(430, 19);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(139, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(215, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(139, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(403, 100);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // lblFeedbacker
            // 
            this.lblFeedbacker.AutoSize = true;
            this.lblFeedbacker.Location = new System.Drawing.Point(142, 106);
            this.lblFeedbacker.Name = "lblFeedbacker";
            this.lblFeedbacker.Size = new System.Drawing.Size(67, 13);
            this.lblFeedbacker.TabIndex = 1;
            this.lblFeedbacker.Text = "Feedbacker:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(375, 78);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Position:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(128, 78);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(174, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(360, 26);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(149, 26);
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
            // lblTemplateName
            // 
            this.lblTemplateName.AutoSize = true;
            this.lblTemplateName.Location = new System.Drawing.Point(4, 35);
            this.lblTemplateName.Name = "lblTemplateName";
            this.lblTemplateName.Size = new System.Drawing.Size(82, 13);
            this.lblTemplateName.TabIndex = 5;
            this.lblTemplateName.Text = "Template Name";
            // 
            // panelQuestions
            // 
            this.panelQuestions.Location = new System.Drawing.Point(8, 178);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(574, 404);
            this.panelQuestions.TabIndex = 2;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 654);
            this.Controls.Add(this.grbFeedbackTemplate);
            this.Controls.Add(this.lblTemplateName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbFeedbackTemplate.ResumeLayout(false);
            this.grbFeedbackTemplate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppImage)).EndInit();
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
        private System.Windows.Forms.Label lblTemplateName;
        private System.Windows.Forms.Panel panelQuestions;
    }
}