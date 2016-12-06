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
    public partial class MainMenuSplashForm : Form {
        private FeedbackCreatorForm _templateForm;
        private InterviewForm _feedbackForm;
        private FilterApplicantsForm _filterForm;

        public MainMenuSplashForm() {
            InitializeComponent();
        }

        private void btnTemplateForm_Click(object sender, EventArgs e) {
            if (null == _templateForm) {
                _templateForm = new FeedbackCreatorForm();
                _templateForm.ShowDialog();
            }
            _templateForm = null;
        }

        private void btnFeedbackForm_Click(object sender, EventArgs e) {
            if (null == _feedbackForm) {
                _feedbackForm = new InterviewForm();
                _feedbackForm.ShowDialog();
            }
            _feedbackForm = null;
        }

        private void btnFilterForm_Click(object sender, EventArgs e) {
            if (null == _filterForm) {
                _filterForm = new FilterApplicantsForm();
                _filterForm.ShowDialog();
            }
            _filterForm = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
