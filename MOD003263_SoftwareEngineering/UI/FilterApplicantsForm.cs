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
        private Property _property = Property.Instance;
        private Bank _bank = Bank.Instance;
        private ApplicantBank _appBank = Bank.Instance.Applicants;
        private string _position = "";
        private bool _canAccRej = false;

        public FilterApplicantsForm() {
            InitializeComponent();
            loadPropertyData();
            loadApplicants();
        }

        private void loadApplicants() {
            foreach (Applicant a in _appBank.Applicants) {
                if (a.ApplicantPosition == _position) {
                    lstFeedbackList.Items.Add(a);
                }
            }
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
                    lstAccepted.Items.Add(lstFeedbackList.Items[i]);
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
                    lstRejected.Items.Add(lstFeedbackList.Items[i]);
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

        private void DummyData() {
            for (int i = 0; i < 200; i++) {
                lstFeedbackList.Items.Add(i);
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

        }

        private void btnEmailRejected_Click(object sender, EventArgs e) {

        }

        private void FilterApplicantsForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm pf = (ParentForm)MdiParent;
            pf.FilterApplicantsForm = null;
            _bank.SaveBank();
        }
    }
}
