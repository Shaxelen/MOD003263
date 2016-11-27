using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD003263_SoftwareEngineering.Forms {
    public partial class MainMenuForm : Form {
        private TemplateForm _templateForm;
        private FeedbackForm _feedbackForm;
        private FilterForm _filterForm;
        private EmailForm _emailForm;

        public MainMenuForm() {
            InitializeComponent();
        }

        private void btnTemplateForm_Click(object sender, EventArgs e) {
            if (_templateForm == null) {
                _templateForm = new TemplateForm();
            }
            _templateForm.Show();
        }

        private void btnFeedbackForm_Click(object sender, EventArgs e) {
            if (_feedbackForm == null) {
                _feedbackForm = new FeedbackForm();
            }
            _feedbackForm.Show();
        }

        private void btnFilterForm_Click(object sender, EventArgs e) {
            if (_filterForm == null) {
                _filterForm = new FilterForm();
            }
            _filterForm.Show();
        }

        private void btnEmail_Click(object sender, EventArgs e) {
            if (_emailForm == null) {
                _emailForm = new EmailForm();
            }
            _emailForm.Show();
        }
    }
}
