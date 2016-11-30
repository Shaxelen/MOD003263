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
        private List<Template> _dataList = TemplateBank.Instance().Templates;
        private int _index = -1;
        private TemplateForm _parent;

        public new TemplateForm Parent { get { return _parent; } set { _parent = value; } }

        public TestLoadForm() {
            InitializeComponent();
        }

        public void addDataList(List<Template> datas) {
            _dataList = datas;
            foreach (Template s in datas) {
                lstTest.Items.Add(s.TemplateName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            if (_index != -1) {
                string a = lstTest.Items[_index].ToString();
                _parent.RetrieveTemplate(a);
                this.Close();
            }
        }

        private void lstTest_SelectedIndexChanged(object sender, EventArgs e) {
            _index = lstTest.SelectedIndex;
        }
    }
}
