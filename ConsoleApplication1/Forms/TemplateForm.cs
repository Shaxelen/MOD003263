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
        private TestSaveForm _saveForm;
        private TestLoadForm _loadForm;

        private TemplateFactory _templateFactory;
        private TemplateEditor _tempEditor;
        private Template _template;
        private TemplateBank _templateBank;

        private QuestionCreator _questionCreator;
        private Question _question;

        private int _tempRemQuestionIndex = -1;

        public TemplateForm() {
            _templateFactory = new TemplateFactory();
            _tempEditor = new TemplateEditor(_templateFactory);
            _templateBank= TemplateBank.Instance();
            _questionCreator = QuestionCreator.Instance();
            InitializeComponent();
        }

        private void cVToolStripMenuItem_Click(object sender, EventArgs e) {
            TemplateRequest("CV");
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e) {
            TemplateRequest("Employee");
        }

        private void interviewToolStripMenuItem_Click(object sender, EventArgs e) {
            TemplateRequest("Interview");
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            _saveForm = new TestSaveForm(_templateBank);
            _saveForm.DisplayTemplates();
            _saveForm.Parent = this;
            _saveForm.ShowDialog();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            _loadForm = new TestLoadForm();
            _loadForm.DisplayTemplates();
            _loadForm.Parent = this;
            _loadForm.ShowDialog();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e) {
            string question = txtAddQuestion.Text;
            txtAddQuestion.Clear();

        }
        private void btnRemoveQuestion_Click(object sender, EventArgs e) {
            _template.RemoveAt(_tempRemQuestionIndex);
        }

        public void TemplateRequest(string type) {
            grbFeedbackTemplate.Visible = true;
            _template = _tempEditor.RequestTemplate(type);
            Text = _template.TemplateName;
        }

        public Template RetrieveTemplate() {
            return _template;
        }

        public void RetrieveTemplate(string template) {
            _template = _templateBank.Load(template);
            Text = _template.TemplateName;
            grbFeedbackTemplate.Visible = true;
        }
    }
}
