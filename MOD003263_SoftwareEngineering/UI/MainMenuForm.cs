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
    public partial class MainMenuForm : Form {
        private TemplateForm _templateForm;
        private FeedbackForm _feedbackForm;
        private FilterForm _filterForm;
        private EmailForm _emailForm;

        public MainMenuForm() {
            InitializeComponent();
        }

        private void btnTemplateForm_Click(object sender, EventArgs e) {
            if (null == _templateForm) {
                OpenForm(_templateForm);
            }
            _templateForm = null;
        }

        private void btnFeedbackForm_Click(object sender, EventArgs e) {
            if (null == _feedbackForm) {
                OpenForm(_feedbackForm);
            }
            _feedbackForm = null;
        }

        private void btnFilterForm_Click(object sender, EventArgs e) {
            if (null == _filterForm) {
                OpenForm(_filterForm);
            }
            _filterForm = null;
        }

        private void btnEmail_Click(object sender, EventArgs e) {
            if (null == _emailForm) {
                OpenForm(_emailForm);
            }
            _emailForm = null;
        }

        private void OpenForm(Form formToOpen) {
            if (formToOpen == _templateForm) {
                _templateForm = new TemplateForm();
                _templateForm.ShowDialog();
            }
            else if (formToOpen == _feedbackForm) {
                _feedbackForm = new FeedbackForm();
                _feedbackForm.ShowDialog();
            }
            else if (formToOpen == _filterForm) {
                _filterForm = new FilterForm();
                _filterForm.ShowDialog();
            }
            else if (formToOpen == _emailForm) {
                _emailForm = new EmailForm();
                _emailForm.ShowDialog();
            }
        }
    }
}
