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
    public partial class ParentForm : Form {
        private Bank _bank = Bank.Instance;
        private FeedbackCreatorForm _templateForm;
        private InterviewForm _feedbackForm;
        private FilterApplicantsForm _filterForm;
        private QuestionCreatorForm _questionForm;
        private ApplicantEntryForm _applicantForm;
        private SettingsEntryForm _settingsForm;

        public ParentForm() {
            InitializeComponent();
            Property p = Property.Instance("softwareengineeringcwatest@outlook.com", "thisPasswordIsDumb");
            _bank.LoadBank();
            _bank = Bank.Instance;
        }

        private void templatesToolStripMenuItem_Click(object sender, EventArgs e) {
            if (null == _templateForm) {
                _templateForm = new FeedbackCreatorForm();
                _templateForm.MdiParent = this;
                _templateForm.WindowState = FormWindowState.Maximized;
                showScreenMenu(false);
                _templateForm.Show();
            }
            _templateForm = null;
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e) {
            if (null == _feedbackForm) {
                _feedbackForm = new InterviewForm();
                _feedbackForm.MdiParent = this;
                _feedbackForm.WindowState = FormWindowState.Maximized;
                showScreenMenu(false);
                _feedbackForm.Show();
            }
            _feedbackForm = null;
        }

        private void filterApplicantsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (null == _filterForm) {
                _filterForm = new FilterApplicantsForm();
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
            menuItemQuestion.Visible = value;
            menuItemSettings.Visible = value;
            menuItemApplicants.Visible = value;
            btnCreateFeedback.Visible = value;
            btnCreateQuestions.Visible = value;
            btnFilterApplicants.Visible = value;
            btnConductInterview.Visible = value;
            btnAddApplicants.Visible = value;
            btnEditSettings.Visible = value;
        }

        public FeedbackCreatorForm FeedbackCreatorForm {
            set { _templateForm = value;
                if (null == _templateForm) {
                    showScreenMenu(true);
                }
            }
        }

        public InterviewForm InterviewForm {
            set { _feedbackForm = value;
                if (null == _feedbackForm) {
                    showScreenMenu(true);
                }
            }
        }

        public FilterApplicantsForm FilterApplicantsForm {
            set { _filterForm = value;
                if (null == _filterForm) {
                    showScreenMenu(true);
                }
            }
        }

        public QuestionCreatorForm QuestionCreatorForm {
            set {
                _questionForm = value;
                if (null == _questionForm) {
                    showScreenMenu(true);
                }
            }
        }

        public ApplicantEntryForm ApplicantEntryForm {
            set {
                _applicantForm = value;
                if (null == _applicantForm) {
                    showScreenMenu(true);
                }
            }
        }

        public SettingsEntryForm SettingsEntryForm {
            set {
                _settingsForm = value;
                if (null == _settingsForm) {
                    showScreenMenu(true);
                }
            }
        }

        private void menuItemQuestion_Click(object sender, EventArgs e) {
            if (null == _questionForm) {
                _questionForm = new QuestionCreatorForm();
                _questionForm.MdiParent = this;
                _questionForm.WindowState = FormWindowState.Maximized;
                showScreenMenu(false);
                _questionForm.Show();
            }
        }

        private void menuItemSettings_Click(object sender, EventArgs e) {
            if (null == _settingsForm) {
                _settingsForm = new SettingsEntryForm();
                _settingsForm.MdiParent = this;
                _settingsForm.WindowState = FormWindowState.Maximized;
                showScreenMenu(false);
                _settingsForm.Show();
            }
        }

        private void menuItemApplicants_Click(object sender, EventArgs e) {
            if (null == _applicantForm) {
                _applicantForm = new ApplicantEntryForm();
                _applicantForm.MdiParent = this;
                _applicantForm.WindowState = FormWindowState.Maximized;
                showScreenMenu(false);
                _applicantForm.Show();
            }
        }
    }
}
