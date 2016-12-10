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
    public partial class SaveFeedbackForm : Form {
        private Bank _bank = Bank.Instance;
        private FeedbackCreatorForm _parent;

        public new FeedbackCreatorForm Parent { get { return _parent; } set { _parent = value; } }

        public SaveFeedbackForm() {
            InitializeComponent();
            addDataList();
        }

        private void addDataList() {
            lstData.Items.Clear();
            if (null != _bank.Feedbacks.FeedbackList) {
                foreach (Feedback f in _bank.Feedbacks.FeedbackList) {
                    lstData.Items.Add(f.Title);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            lstData.Items.Add(txtName.Text);
            Feedback feedback = Parent.CurrentFeedback;
            feedback.Title = txtName.Text;
            if (null != _bank.Feedbacks.FindFeedback(txtName.Text)) {
                if (_bank.Feedbacks.FindFeedback(txtName.Text).Title == feedback.Title) {
                    Feedback old = _bank.Feedbacks.FindFeedback(txtName.Text);
                    if (null != old) { saveOver(old, feedback); } else { MessageBox.Show("Unable to Save as Name: " + txtName.Text); }
                }
            } else {
                _bank.Feedbacks.Add(feedback);
            }
            _bank.SaveBank();
            this.Close();
        }

        private void saveOver(Feedback old, Feedback neww) {
            _bank.Feedbacks.Remove(old.Title);
            _bank.Feedbacks.Add(neww);
            addDataList();
        }
    }
}