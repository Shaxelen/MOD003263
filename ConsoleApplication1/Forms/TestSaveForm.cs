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
        private TemplateBank _templateBank = TemplateBank.Instance();
        private TemplateForm _parent;
        private Template _template;

       /// <summary>
       /// TestSaveForm Constructor
       /// </summary>
       /// <param name="templateBank">The TemplateBank to access</param>
        public TestSaveForm(TemplateBank templateBank) {
            InitializeComponent();
            _templateBank = templateBank;
        }

        /// <summary>
        /// Saves a template to the template bank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e) {
            //generate new Template
            string templateName = txtName.Text;

            if (lstTemplates.Items.Contains(templateName)) {
                _template = _parent.RetrieveTemplate();
                _templateBank.Update(templateName, _template);
                _parent.retrieveDataList(_templateBank.Templates);
            } else {
                lstTemplates.Items.Add(txtName.Text);
                _template = _parent.RetrieveTemplate();
                _templateBank.Add(templateName, _template);
                _parent.retrieveDataList(_templateBank.Templates);
            }

            
        }

        /// <summary>
        /// Display templates from template bank 
        /// </summary>
        /// <param name="templateBank">The TemplateBank to access</param>
        public void DisplayTemplates()
        {
            foreach (Template t in _templateBank.Templates)
            {
                lstTemplates.Items.Add(t.TemplateName);
            }
        }

        /// <summary>
        /// Gets and sets the parent form
        /// </summary>
        public new TemplateForm Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
    }
}