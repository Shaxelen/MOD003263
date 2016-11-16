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
        private TemplateBank _templateBank = new TemplateBank();
        private int _tempRemQuestionIndex = -1;

        public TemplateForm() {
            InitializeComponent();

        }

        private void btnCreateTemplate_Click(object sender, EventArgs e) {
            grbFeedbackTemplate.Visible = true;
            string request = txtCreateTemplate.Text;
            _tempEditor = new TemplateEditor(_templateFactory);
            _template = _tempEditor.RequestTemplate(request);
            lblTemplateName.Text = _template.GetTemplateName();
            UpdateListBox();
            txtCreateTemplate.Clear();
        }


        private void btnLoadTemplate_Click(object sender, EventArgs e) {
            string loadTemplate = txtLoadTemplate.Text;
            _template = _templateBank.Load(loadTemplate);
            lblTemplateName.Text = _template.GetTemplateName();
            UpdateListBox();
            txtLoadTemplate.Clear();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e) {
            string question = txtAddQuestion.Text;
            _template.Add(question);
            UpdateListBox();
            txtAddQuestion.Clear();
        }

        private void UpdateListBox() {
            lstTemplateQuestions.DataSource = null;
            lstTemplateQuestions.DataSource = _template.GetTemplateQuestions;
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e) {
            _template.RemoveAt(_tempRemQuestionIndex);
            UpdateListBox();
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e) {
            string saveName = txtSaveTemplate.Text;
            _templateBank.Add(saveName, _template);
            txtSaveTemplate.Clear();
        }

        private void lstTemplateQuestions_SelectedIndexChanged(object sender, EventArgs e) {
            _tempRemQuestionIndex = lstTemplateQuestions.SelectedIndex;
        }
    }
}
