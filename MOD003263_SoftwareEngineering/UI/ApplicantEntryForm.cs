using MOD003263_SoftwareEngineering.Core;
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
    public partial class ApplicantEntryForm : Form {
        private Bank _bank = Bank.Instance;

        public ApplicantEntryForm() {
            InitializeComponent();
        }

        private void ApplicantEntryForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm pf = (ParentForm)MdiParent;
            pf.ApplicantEntryForm = null;
            _bank.SaveBank();
        }

        private void btnAddCV_Click(object sender, EventArgs e) {

        }

        private void btnAddAppImage_Click(object sender, EventArgs e) {

        }

        private void btnAddApplicant_Click(object sender, EventArgs e) {

        }

        private void btnSaveApplicant_Click(object sender, EventArgs e) {

        }

        private void btnNextApplicant_Click(object sender, EventArgs e) {

        }

        private void btnPrevApplicant_Click(object sender, EventArgs e) {

        }
    }
}
