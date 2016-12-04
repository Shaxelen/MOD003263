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
    public partial class ScreenForm : Form {
        private TemplateForm _templateForm;
        private FeedbackForm _feedbackForm;
        private FilterForm _filterForm;

        public ScreenForm() {
            InitializeComponent();
        }

        private void templatesToolStripMenuItem_Click(object sender, EventArgs e) {
            if (null == _templateForm) {
                _templateForm = new TemplateForm();
                _templateForm.MdiParent = this;
                _templateForm.WindowState = FormWindowState.Maximized;
                showScreenMenu(false);
                _templateForm.Show();
            }
            _templateForm = null;
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e) {
            if (null == _feedbackForm) {
                _feedbackForm = new FeedbackForm();
                _feedbackForm.MdiParent = this;
                _feedbackForm.WindowState = FormWindowState.Maximized;
                showScreenMenu(false);
                _feedbackForm.Show();
            }
            _feedbackForm = null;
        }

        private void filterApplicantsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (null == _filterForm) {
                _filterForm = new FilterForm();
                _filterForm.MdiParent = this;
                _filterForm.WindowState = FormWindowState.Maximized;
                showScreenMenu(false);
                _filterForm.Show();
            }
        }
        
        private void showScreenMenu(bool value) {
            menuItemTemplate.Visible = value;
            menuItemFeedback.Visible = value;
            menuItemFilter.Visible = value;
        }

        public TemplateForm TemplateForm {
            set { _templateForm = value;
                if (null == _templateForm) {
                    showScreenMenu(true);
                }
            }
        }

        public FeedbackForm FeedbackForm {
            set { _feedbackForm = value;
                if (null == _feedbackForm) {
                    showScreenMenu(true);
                }
            }
        }

        public FilterForm FilterForm {
            set { _filterForm = value;
                if (null == _filterForm) {
                    showScreenMenu(true);
                }
            }
        }
    }
}
