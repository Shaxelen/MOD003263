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
    public partial class TestSaveForm : Form {
        private Bank _bank = Bank.Instance;
        private TemplateForm _parent;

        public new TemplateForm Parent { get { return _parent; } set { _parent = value; } }

        public TestSaveForm() {
            InitializeComponent();
            addDataList();
        }

        private void addDataList() {
            foreach (Feedback f in _bank.Feedbacks.FeedbackList) {
                lstData.Items.Add(f.Title);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            lstData.Items.Add(txtName.Text);
            Feedback tem = Parent.CurrentFeedback;
            tem.Title = txtName.Text;
            if (_bank.Templates.Load(txtName.Text).TemplateName == tem.Title) {
                Feedback old = _bank.Feedbacks.FindFeedback(txtName.Text);
                if (null != old) { saveOver(old, tem); }
                else { MessageBox.Show("Unable to Save as Name: " + txtName.Text); }
            }
            _bank.Feedbacks.Add(tem);
        }

        private void saveOver(Feedback old, Feedback neww) {

        }
    }
}