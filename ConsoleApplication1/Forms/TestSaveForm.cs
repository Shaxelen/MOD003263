using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1 {
    public partial class TestSaveForm : Form {
        private TemplateBank _tempBank = TemplateBank.getInstance();
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
            //generate new Template
            lstData.Items.Add(txtName.Text);

            _parent.retrieveDataList(_tempBank.Templates);
        }
    }
}