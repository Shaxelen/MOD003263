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

        public MainMenuForm() {
            InitializeComponent();
        }

        private void btnTemplateForm_Click(object sender, EventArgs e) {
            if (null == _templateForm) {
                _templateForm = new TemplateForm();
                _templateForm.ShowDialog();
            }
            _templateForm = null;
        }

        private void btnFeedbackForm_Click(object sender, EventArgs e) {
            if (null == _feedbackForm) {
                _feedbackForm = new FeedbackForm();
                _feedbackForm.ShowDialog();
            }
            _feedbackForm = null;
        }

        private void btnFilterForm_Click(object sender, EventArgs e) {
            if (null == _filterForm) {
                _filterForm = new FilterForm();
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
