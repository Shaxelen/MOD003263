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
    public partial class TestLoadForm : Form {
        private Bank _bank = Bank.Instance;
        private int _index = -1;
        private TemplateForm _parent;

        public new TemplateForm Parent { get { return _parent; } set { _parent = value; } }

        public TestLoadForm() {
            InitializeComponent();
            addDataList();
        }

        private void addDataList() {
            foreach (Template s in _bank.Templates.Templates) {
                lstTest.Items.Add(s.TemplateName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            if (_index != -1 && _index < lstTest.Items.Count) {
                string a = lstTest.Items[_index].ToString();
                this.Close();
            }
        }

        private void lstTest_SelectedIndexChanged(object sender, EventArgs e) {
            _index = lstTest.SelectedIndex;
        }
    }
}
