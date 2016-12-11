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
    public partial class SettingsEntryForm : Form {
        private Bank _bank = Bank.Instance;
        private Property _property = Property.CurrentInstance;
        private bool _emailTest = false;
        private bool _emailSucceed = false;

        public SettingsEntryForm() {
            InitializeComponent();
            loadProperty();
        }

        private void loadProperty() {
            txtAcceptedBody.Text = _property.AcceptedBody;
            txtAcceptedSubject.Text = _property.AcceptedSubject;
            txtRejectedBody.Text = _property.RejectedBody;
            txtRejectedSubject.Text = _property.RejectedSubject;
            txtEmailEmail.Text = _property.Credentials.UserName;
            txtEmailPassword.Text = "";
        }

        private void SettingsEntryForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm pf = (ParentForm)MdiParent;
            pf.SettingsEntryForm = null;
            _bank.SaveBank();
        }

        private void btnEmailTest_Click(object sender, EventArgs e) {
            Meta.EmailHandler eh = new Meta.EmailHandler(_property.Credentials);
            try {
                eh.SendEmail(_property.Credentials.UserName, "Test", "Body", "");
                MessageBox.Show("Test Passed", "Success");
                _emailSucceed = true;
            } catch (Exception) {
                MessageBox.Show("Test Failed, Please Check Credentials and Account", "Error");
                _emailSucceed = false;
            }
            _emailTest = true;
        }

        private void btnSaveAllSettings_Click(object sender, EventArgs e) {
            if (_emailSucceed && _emailTest) {
                _property.AcceptedBody = txtAcceptedBody.Text;
                _property.AcceptedSubject = txtAcceptedSubject.Text;
                _property.RejectedBody = txtRejectedBody.Text;
                _property.RejectedSubject = txtRejectedSubject.Text;
                _property.Credentials.UserName = txtEmailEmail.Text;
                _property.Credentials.Password = txtEmailPassword.Text;
                MessageBox.Show("Settings Saved!", "Success");
            } else {
                MessageBox.Show("Please Test Email Connection", "Error");
            }
        }
    }
}
