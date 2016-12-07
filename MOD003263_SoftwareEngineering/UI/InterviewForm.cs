using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOD003263_SoftwareEngineering.Core;

namespace MOD003263_SoftwareEngineering.UI {
    public partial class InterviewForm : Form {
        private Feedback _feedback;

        public InterviewForm() {
            InitializeComponent();
        }

        public Feedback CurrentFeedback {
            get { return _feedback; }
            set { _feedback = value; }
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
            ParentForm pf = (ParentForm)MdiParent;
            pf.InterviewForm = null;
        }

        private void InterviewForm_Load(object sender, EventArgs e)
        {
            LoadFeedbackForm lff = new LoadFeedbackForm();
            lff.InterviewParent = this;
            lff.ShowDialog();
            if (null == _feedback)
            {
                MessageBox.Show("Feedback Not Loaded", "Error");
            }
        }
    }
}
