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

        public SettingsEntryForm() {
            InitializeComponent();
        }

        private void SettingsEntryForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm pf = (ParentForm)MdiParent;
            pf.SettingsEntryForm = null;
            _bank.SaveBank();
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
