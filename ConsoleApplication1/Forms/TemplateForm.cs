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
    public partial class TemplateForm : Form {
        private TemplateFactory _templateFactory = new TemplateFactory();
        private TemplateEditor _tempEditor;
        private Template _template;
        private TemplateBank _templateBank = TemplateBank.getInstance();
        private int _tempRemQuestionIndex = -1;

        public TemplateForm() {
            InitializeComponent();
            //_templateBank.Add("N", new CVTemplate());
        }

        private void btnCreateTemplate_Click(object sender, EventArgs e) {
            grbFeedbackTemplate.Visible = true;
            string request = txtCreateTemplate.Text;
            _tempEditor = new TemplateEditor(_templateFactory);
            _template = _tempEditor.RequestTemplate(request);
            lblTemplateName.Text = _template.TemplateName;
            UpdateListBox();
            txtCreateTemplate.Clear();
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            TestSaveForm tsf = new TestSaveForm(_templateBank);
            tsf.DisplayTemplates();
            tsf.Parent = this;
            tsf.ShowDialog();
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e) {
            TestLoadForm tlf = new TestLoadForm();
            tlf.DisplayTemplates();
            tlf.Parent = this;
            tlf.ShowDialog();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e) {
            string question = txtAddQuestion.Text;
            _template.Add(question);
            UpdateListBox();
            txtAddQuestion.Clear();
        }
        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            _template.RemoveAt(_tempRemQuestionIndex);
            UpdateListBox();
        }

        private void lstTemplateQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tempRemQuestionIndex = lstTemplateQuestions.SelectedIndex;
        }

        public void RetrieveTemplate(string template)
        {
            _template = _templateBank.Load(template);
            lblTemplateName.Text = _template.TemplateName;
            grbFeedbackTemplate.Visible = true;
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            lstTemplateQuestions.DataSource = null;
            lstTemplateQuestions.DataSource = _template.TemplateQuestions;
        }

        public Template RetrieveTemplate()
        {
            return _template;
        }

        public void retrieveDataList(List<Template> dataList) {
            _templateBank.Templates = dataList;
            lstTest.Items.Clear();
            foreach (Template t in dataList) {
                lstTest.Items.Add(t.TemplateName);
            }
        }
    }
}
