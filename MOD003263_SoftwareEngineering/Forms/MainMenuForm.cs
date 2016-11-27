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
                OpenForm(_templateForm);
            }
        }

        private void btnFeedbackForm_Click(object sender, EventArgs e) {
            if (_feedbackForm == null) {
                OpenForm(_feedbackForm);
            } 
        }

        private void btnFilterForm_Click(object sender, EventArgs e) {
            if (_filterForm == null) {
                OpenForm(_filterForm);
            }
        }

        private void btnEmail_Click(object sender, EventArgs e) {
            if (_emailForm == null) {
                OpenForm(_emailForm);
            }
        }

        private void OpenForm(Form formToOpen) {
            if (formToOpen == _templateForm) {
                _templateForm = new TemplateForm();
                _templateForm.ShowDialog(this);
            }
            else if (formToOpen == _feedbackForm) {
                _feedbackForm = new FeedbackForm();
                _feedbackForm.ShowDialog(this);
            }
            else if (formToOpen == _filterForm) {
                _filterForm = new FilterForm();
                _filterForm.ShowDialog(this);
            }
            else if (formToOpen == _emailForm) {
                _emailForm = new EmailForm();
                _emailForm.ShowDialog(this);
            }
        }
    }
}
