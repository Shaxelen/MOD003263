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
        private Bank _bank = Bank.Instance;
        private Feedback _feedback;
        private Question _question;
        private Applicant _applicant;

        public InterviewForm() {
            InitializeComponent();
            load();
        }

        public Feedback CurrentFeedback {
            get { return _feedback; }
            set { _feedback = value; }
        }

        private void inputFeedbackQuestions() {
            foreach (Question q in _feedback.Questions) {
                lstQuestions.Items.Add(q.Title);
            }
        }

        private void loadInApplicants() {
            foreach (Applicant a in _bank.Applicants.Applicants) {
                cmbApplicant.Items.Add(a.FullName);
            }
        }

        private void FeedbackForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm pf = (ParentForm)MdiParent;
            pf.InterviewForm = null;
        }

        private void load() {
            LoadFeedbackForm lff = new LoadFeedbackForm();
            lff.InterviewParent = this;
            lff.ShowDialog();
            if (null == _feedback)
            {
                MessageBox.Show("Feedback Not Loaded", "Error");
            }
            else
            {
                inputFeedbackQuestions();
                loadInApplicants();
            }
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e) {
            _question = _bank.Feedbacks.FindFeedback(_feedback.Title).FindQuestion(lstQuestions.SelectedItem.ToString());
            txtAnswerOne.Text = _question.FeedbackList[0];
            txtAnswerTwo.Text = _question.FeedbackList[1];
            txtAnswerThree.Text = _question.FeedbackList[2];
            txtAnswerFour.Text = _question.FeedbackList[3];
            txtAnswerFive.Text = _question.FeedbackList[4];
        }

        private void btnOpenCV_Click(object sender, EventArgs e) {
            if (null != _applicant) {
                try {
                    System.Diagnostics.Process.Start(_applicant.CVLocation);
                } catch (Exception) {
                    MessageBox.Show("No CV For Applicant", "Error");
                }
            } else {
                MessageBox.Show("No Applicant Loaded in", "Error");
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e) {
            //question saving over as selected feedback
        }

        private void btnFinishInterview_Click(object sender, EventArgs e) {
            // finish off interview and make feedback pdf
        }

        private void btnLoadApplicant_Click(object sender, EventArgs e) {

        }
    }
}
