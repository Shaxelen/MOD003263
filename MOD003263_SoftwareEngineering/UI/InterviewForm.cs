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
            _bank.SaveBank();
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
            if (lstQuestions.Items.Count != 0) {
                addQuestionFeedbacks();
            }
        }

        private void addQuestionFeedbacks() {
            _question = _feedback.FindQuestion(lstQuestions.Items[0].ToString());
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

        private void saveQuestion() {
            int score = generateScore();
            _feedback.Questions.Find(x => x.Title == _question.Title).Score = score;
            _feedback.Questions.Find(x => x.Title == _question.Title).pickFeedback(score);
            _applicant.TotalScore = score;
        }

        private int generateScore() {
            if (radAnswerOne.Checked) { return 1; }
            else if (radAnswerOne.Checked) { return 2; }
            else if (radAnswerOne.Checked) { return 3; }
            else if (radAnswerOne.Checked) { return 4; }
            else { return 5; }
        }

        private void uncheckRads() {
            radAnswerOne.Checked = false;
            radAnswerTwo.Checked = false;
            radAnswerThree.Checked = false;
            radAnswerFour.Checked = false;
            radAnswerFive.Checked = false;
            txtAnswerOne.Text = "";
            txtAnswerTwo.Text = "";
            txtAnswerThree.Text = "";
            txtAnswerFour.Text = "";
            txtAnswerFive.Text = "";
        }

        private void btnNextQuestion_Click(object sender, EventArgs e) {
            if (lstQuestions.Items.Count > 1) {
                if (!(!radAnswerOne.Checked && !radAnswerTwo.Checked && !radAnswerThree.Checked && !radAnswerFour.Checked && !radAnswerFive.Checked)) {
                    saveQuestion();
                    uncheckRads();
                    lstQuestions.Items.RemoveAt(0);
                    lstQuestions.SelectedItem = lstQuestions.Items[0];
                } else {
                    MessageBox.Show("Please make sure an answer is selected", "Error");
                }
            } else {
                btnFinishInterview_Click(sender, e);
            }
        }

        private void btnFinishInterview_Click(object sender, EventArgs e) {
            if (!(!radAnswerOne.Checked && !radAnswerTwo.Checked && !radAnswerThree.Checked && !radAnswerFour.Checked && !radAnswerFive.Checked)) {
                saveQuestion();
                uncheckRads();
                lstQuestions.Items.RemoveAt(0);
                if (lstQuestions.Items.Count == 0) {
                    Meta.PDFConvert pdf = new Meta.PDFConvert();
                    pdf.ConvertApplicantTemplateToPDF(_feedback, _applicant);
                    this.Close();
                } else {
                    btnNextQuestion_Click(sender, e);
                }
            } else {
                MessageBox.Show("Please make sure an answer is selected", "Error");
            }
        }

        private void btnLoadApplicant_Click(object sender, EventArgs e) {
            if (cmbApplicant.Text != "") {
                if (null != _bank.Applicants.FindApplicant(cmbApplicant.Text)) {
                    _applicant = _bank.Applicants.FindApplicant(cmbApplicant.Text);
                    //picApplicantPicture.Image = Image.FromFile(_applicant.ImageFileLocation);
                } else {
                    MessageBox.Show("Applicant not found", "Error");
                }
            } else {
                MessageBox.Show("Please pick an applicant from the list to interview", "Error");
            }
        }
    }
}
