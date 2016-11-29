namespace MOD003263_SoftwareEngineering.UI {
    partial class MainMenuForm {
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
            this.btnTemplateForm = new System.Windows.Forms.Button();
            this.btnFeedbackForm = new System.Windows.Forms.Button();
            this.btnFilterForm = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTemplateForm
            // 
            this.btnTemplateForm.Location = new System.Drawing.Point(12, 12);
            this.btnTemplateForm.Name = "btnTemplateForm";
            this.btnTemplateForm.Size = new System.Drawing.Size(269, 23);
            this.btnTemplateForm.TabIndex = 0;
            this.btnTemplateForm.Text = "Template";
            this.btnTemplateForm.UseVisualStyleBackColor = true;
            this.btnTemplateForm.Click += new System.EventHandler(this.btnTemplateForm_Click);
            // 
            // btnFeedbackForm
            // 
            this.btnFeedbackForm.Location = new System.Drawing.Point(12, 41);
            this.btnFeedbackForm.Name = "btnFeedbackForm";
            this.btnFeedbackForm.Size = new System.Drawing.Size(269, 23);
            this.btnFeedbackForm.TabIndex = 1;
            this.btnFeedbackForm.Text = "Feedback";
            this.btnFeedbackForm.UseVisualStyleBackColor = true;
            this.btnFeedbackForm.Click += new System.EventHandler(this.btnFeedbackForm_Click);
            // 
            // btnFilterForm
            // 
            this.btnFilterForm.Location = new System.Drawing.Point(12, 70);
            this.btnFilterForm.Name = "btnFilterForm";
            this.btnFilterForm.Size = new System.Drawing.Size(269, 23);
            this.btnFilterForm.TabIndex = 2;
            this.btnFilterForm.Text = "Filter";
            this.btnFilterForm.UseVisualStyleBackColor = true;
            this.btnFilterForm.Click += new System.EventHandler(this.btnFilterForm_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(12, 99);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(269, 23);
            this.btnEmail.TabIndex = 3;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 131);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnFilterForm);
            this.Controls.Add(this.btnFeedbackForm);
            this.Controls.Add(this.btnTemplateForm);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTemplateForm;
        private System.Windows.Forms.Button btnFeedbackForm;
        private System.Windows.Forms.Button btnFilterForm;
        private System.Windows.Forms.Button btnEmail;
    }
}