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

namespace MOD003263_SoftwareEngineering.Forms {
    public partial class TestSaveForm : Form {
        private TemplateBank _tempBank = TemplateBank.Instance();
        private TemplateForm _parent;

        public new TemplateForm Parent { get { return _parent; } set { _parent = value; } }

        public TestSaveForm() {
            InitializeComponent();
        }

        public void addDataList(TemplateBank data) {
            _tempBank = data;
            foreach (Template s in data.Templates) {
                lstData.Items.Add(s.TemplateName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            lstData.Items.Add(txtName.Text);
        }
    }
}