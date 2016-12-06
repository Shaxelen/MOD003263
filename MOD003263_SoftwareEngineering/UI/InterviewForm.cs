using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD003263_SoftwareEngineering.UI {
    public partial class InterviewForm : Form {
        public InterviewForm() {
            InitializeComponent();
        }

        private void menuLoadApplicant_Click(object sender, EventArgs e) {
            // Get Applicant
            // Add Applicant Data to Feedback
            // Show on Header
        }

        private void menuLoadEmployee_Click(object sender, EventArgs e) {
            // Get Employee
            // Add Employee Data to Feedback
            // Show on Header
        }

        private void menuLoadTemp_Click(object sender, EventArgs e) {
            // Get Template
            // Add Template to Feedback
            // Add Template Data to Form
        }

        private void menuSave_Click(object sender, EventArgs e) {
            // Handles Saving 
            // If New, Save As, else, Save
        }

        private void menuSaveAs_Click(object sender, EventArgs e) {
            // Handles Saving as
            // Saves as New Feedback File
        }

        private void menuClearHeader_Click(object sender, EventArgs e) {

        }

        private void menuClearFeedback_Click(object sender, EventArgs e) {

        }

        private void FeedbackForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm sf = (ParentForm)MdiParent;
            sf.FeedbackForm = null;
        }
    }
}
