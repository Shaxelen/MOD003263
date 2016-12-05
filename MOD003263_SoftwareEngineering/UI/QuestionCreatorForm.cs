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
    public partial class QuestionCreatorForm : Form {
        public QuestionCreatorForm() {
            InitializeComponent();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e) {

        }

        private void btnAddCategory_Click(object sender, EventArgs e) {

        }

        private void lstCategoryList_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstCategoryList.SelectedIndex != -1) {
                MessageBox.Show(lstCategoryList.SelectedIndex.ToString());
            }
        }
    }
}
