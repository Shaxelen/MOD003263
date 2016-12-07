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
    public partial class SettingsEntryForm : Form {
        public SettingsEntryForm() {
            InitializeComponent();
        }

        private void SettingsEntryForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm pf = (ParentForm)MdiParent;
            pf.SettingsEntryForm = null;
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
