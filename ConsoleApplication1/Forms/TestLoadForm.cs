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
    public partial class TestLoadForm : Form {
        private List<Template> _templateList = new List<Template>();
        private TemplateBank _templateBank = TemplateBank.Instance();
        private int _index = -1;
        private TemplateForm _parent;


        /// <summary>
        /// TestLoadForm Constructor
        /// </summary>
        public TestLoadForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Load a selected template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e) {
            if (_index != -1) {
                string templateName = lstTemplates.Items[_index].ToString();
                _parent.RetrieveTemplate(templateName);
                this.Close();
            }
        }

        /// <summary>
        /// Selected template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTest_SelectedIndexChanged(object sender, EventArgs e) {
            _index = lstTemplates.SelectedIndex;
        }

        /// <summary>
        /// Displays a list of templates from the template bank
        /// </summary>
        /// <param name="templates"></param>
        public void DisplayTemplates()
        {
            foreach (Template t in _templateBank.Templates)
            {
                lstTemplates.Items.Add(t.TemplateName);
            }
        }

        public new TemplateForm Parent {
            get { return _parent; }
            set { _parent = value; }
        }
    }
}
