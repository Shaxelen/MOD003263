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
    public partial class FilterApplicantsForm : Form {
        private Property _property = Property.Instance("softwareengineeringcwatest@outlook.com", "thisPasswordIsDumb");
        private Bank _bank = Bank.Instance;
        private ApplicantBank _appBank = Bank.Instance.Applicants;
        private List<Applicant> _applicants = Bank.Instance.Applicants.Applicants;
        private List<Applicant> _accepted = new List<Applicant>();
        private List<Applicant> _rejected = new List<Applicant>();
        private FeedbackFilter _feedbackFilter = new FeedbackFilter();
        private string _position = "";
        private bool _canAccRej = false;

        public FilterApplicantsForm() {
            InitializeComponent();
            loadPropertyData();
            loadPosition();
            orderApplicants();
            loadApplicants();
        }

        private void orderApplicants() {
            _applicants = _applicants.OrderBy(a => a.ApplicantID).ToList();
        }

        private void dummyData() {
            for (int i = 0; i < 200; i++) {
                lstFeedbackList.Items.Add(i);
            }
        }

        private void loadPosition() {
            List<Applicant> app = _appBank.Applicants;
            for (int i = 0; i < app.Count; i++) {
                _position = app[i].ApplicantPosition;
                if (checkPositionExist(_position)) {
                    cmbPosition.Items.Add(_position);
                }
            }
        }

        private bool checkPositionExist(string position) {
            if (cmbPosition.Items.Contains(position)) {
                return false;
            } else {
                return true;
            }
        }

        private void loadApplicants() {
            foreach (Applicant a in _applicants) {
                if (a.ApplicantPosition == _position) {
                    lstFeedbackList.Items.Add(a.TotalScore + ":" + a.FullName);
                }
            }
            List<string> list = new List<string>(lstFeedbackList.Items.Cast<string>());
            list = list.OrderByDescending(li => li.ToString()).ToList<string>();
            lstFeedbackList.Items.Clear();
            lstFeedbackList.Items.AddRange(list.ToArray<string>());
        }

        private void loadPropertyData() {
            if (_property.AcceptedSubject != "") {
                txtAccSubject.Text = _property.AcceptedSubject;
            }
            if (_property.RejectedSubject != "") {
                txtRejSubject.Text = _property.RejectedSubject;
            }
            if (_property.RejectedBody != "") {
                txtRejBody.Text = _property.RejectedBody;
            }
            if (_property.AcceptedBody != "") {
                txtAccBody.Text = _property.AcceptedBody;
            }
        }

        private void btnAcceptSelected_Click(object sender, EventArgs e) {
            if (_canAccRej) {
                List<int> ints = new List<int>();
                foreach (int i in lstFeedbackList.SelectedIndices) {
                    string app = lstFeedbackList.Items[i].ToString().Split(':')[1];
                    lstAccepted.Items.Add(app);
                    _accepted.Add(_appBank.FindApplicant(app));
                    ints.Add(i);
                }
                ints.Reverse();
                foreach (int i in ints) {
                    lstFeedbackList.Items.RemoveAt(i);
                }
            } else {
                MessageBox.Show("Select an Applicant First");
            }
        }

        private void btnRejectSelected_Click(object sender, EventArgs e) {
            if (_canAccRej) {
                List<int> ints = new List<int>();
                foreach (int i in lstFeedbackList.SelectedIndices) {
                    string app = lstFeedbackList.Items[i].ToString().Split(':')[1];
                    lstRejected.Items.Add(app);
                    _rejected.Add(_appBank.FindApplicant(app));
                    ints.Add(i);
                }
                ints.Reverse();
                foreach (int i in ints) {
                    lstFeedbackList.Items.RemoveAt(i);
                }
            } else {
                MessageBox.Show("Select an Applicant First");
            }
        }

        private void lstFeedbackList_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstFeedbackList.SelectedIndex == -1) {
                _canAccRej = false;
            }
            else {
                _canAccRej = true;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e) {
            if (btnSelectAll.Text == "Select All") {
                for (int i = 0; i < lstFeedbackList.Items.Count; i++) {
                    lstFeedbackList.SetSelected(i, true);
                }
                btnSelectAll.Text = "Deselect All";
            }
            else if (btnSelectAll.Text == "Deselect All") {
                for (int i = 0; i < lstFeedbackList.Items.Count; i++) {
                    lstFeedbackList.SetSelected(i, false);
                }
                btnSelectAll.Text = "Select All";
            }
        }

        private void btnEmailAccepted_Click(object sender, EventArgs e) {
            Meta.EmailHandler eh = new Meta.EmailHandler(_property.Credentials);
            foreach (Applicant a in _accepted) {
                eh.SendEmail(a.EmailAddress, txtAccSubject.Text, txtAccBody.Text, "A" + a.ApplicantID + ".pdf");
                lstAccepted.Items.Remove(a.FullName);
            }
        }

        private void btnEmailRejected_Click(object sender, EventArgs e) {
            Meta.EmailHandler eh = new Meta.EmailHandler(_property.Credentials);
            foreach (Applicant a in _rejected) {
                eh.SendEmail(a.EmailAddress, txtRejSubject.Text, txtRejBody.Text, "A" + a.ApplicantID + ".pdf");
                lstRejected.Items.Remove(a.FullName);
            }
        }

        private void FilterApplicantsForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm pf = (ParentForm)MdiParent;
            pf.FilterApplicantsForm = null;
            _bank.SaveBank();
        }
    }
}
