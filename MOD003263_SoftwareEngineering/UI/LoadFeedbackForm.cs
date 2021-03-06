﻿using System;
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
    public partial class LoadFeedbackForm : Form {
        private Bank _bank = Bank.Instance;
        private int _index = -1;
        private FeedbackCreatorForm _parent;
        private InterviewForm _interviewParent;

        public FeedbackCreatorForm FeedbackParent { get { return _parent; } set { _parent = value; } }
        public InterviewForm InterviewParent { get { return _interviewParent; } set { _interviewParent = value; } }

        public LoadFeedbackForm() {
            InitializeComponent();
            addDataList();
        }

        private void addDataList() {
            if (null != _bank.Feedbacks.FeedbackList) {
                foreach (Feedback f in _bank.Feedbacks.FeedbackList) {
                    lstTest.Items.Add(f.Title);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            if (_index != -1 && _index < lstTest.Items.Count) {
                string title = lstTest.Items[_index].ToString();
                if (null != _parent) {
                    _parent.CurrentFeedback = _bank.Feedbacks.FindFeedback(title);
                }
                else if (null != _interviewParent) {
                    _interviewParent.CurrentFeedback = _bank.Feedbacks.FindFeedback(title);
                }
                else {
                    MessageBox.Show("Cannot Load Feedback, Unknown Destination", "Error");
                }
                _bank.SaveBank();
                this.Close();
            }
        }

        private void lstTest_SelectedIndexChanged(object sender, EventArgs e) {
            _index = lstTest.SelectedIndex;
        }
    }
}
