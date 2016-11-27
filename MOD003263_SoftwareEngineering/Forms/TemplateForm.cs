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
using MOD003263_SoftwareEngineering.UI;

namespace MOD003263_SoftwareEngineering.Forms {
    public partial class TemplateForm : Form {
        // Template Objects
        private TemplateFactory _templateFactory;
        private TemplateEditor _tempEditor;
        private Template _template;
        private TemplateBank _templateBank;

        // Question Objects
        private Question _question;
        private QuestionCreator _questionCreator;
        private GroupBox _grbQuestion;
        private TextBox _txtComment;
        private RadioButton _radScore1;
        private RadioButton _radScore2;
        private RadioButton _radScore3;
        private RadioButton _radScore4;
        private RadioButton _radScore5;
        private int _id = 1;

        // Form Objects
        private TestSaveForm _saveForm;
        private TestLoadForm _loadForm;

        public TemplateForm() {
            InitializeComponent();
            Start();
        }

        private void Start() {
            _templateFactory = new TemplateFactory();
            _tempEditor = new TemplateEditor(_templateFactory);
            _templateBank = TemplateBank.Instance();
            _questionCreator = QuestionCreator.Instance();
        }
        #region Requesting Template

        private void menuCVTemplate_Click(object sender, EventArgs e) { TemplateRequest("CV"); }

        private void menuInterviewTemplate_Click(object sender, EventArgs e) { TemplateRequest("Interview"); }

        private void menuEmployeeTemplate_Click(object sender, EventArgs e) { TemplateRequest("Employee"); }

        private void menuClearTemplate_Click(object sender, EventArgs e) { flwQuestions.Controls.Clear(); }

        public void TemplateRequest(string type) {
            grbFeedbackTemplate.Visible = true;
            _template = _tempEditor.RequestTemplate(type);
            Text = _template.TemplateName;
        }
        #endregion

        #region Saving/Loading Templates

        private void menuSaveTemplate_Click(object sender, EventArgs e) {
            _saveForm = new TestSaveForm();
            _saveForm.addDataList(_templateBank);
            _saveForm.Parent = this;
            _saveForm.ShowDialog();
        }

        private void menuLoadTemplate_Click(object sender, EventArgs e) {
            _loadForm = new TestLoadForm();
            _loadForm.addDataList(_templateBank.Templates);
            _loadForm.Parent = this;
            _loadForm.ShowDialog();
        }

        public void RetrieveTemplate(string template) {
            _template = _templateBank.Load(template);
            lblTemplateName.Text = _template.TemplateName;
            grbFeedbackTemplate.Visible = true;
        }

        #endregion

        #region Creating and adding Questions

        private void btnAddQuestion_Click(object sender, EventArgs e) {
            _question = _questionCreator.CreateQuestion(_id, txtAddQuestion.Text);
            _grbQuestion = TestGroupBox(_id, txtAddQuestion.Text);
            _txtComment = TestTextBox(_id);
            _radScore1 = TestScore(_id, 1, 6, 81);
            _radScore2 = TestScore(_id, 2, 43, 81);
            _radScore3 = TestScore(_id, 3, 80, 81);
            _radScore4 = TestScore(_id, 4, 117, 81);
            _radScore5 = TestScore(_id, 5, 154, 81);

            _grbQuestion.Controls.Add(_txtComment);
            _grbQuestion.Controls.Add(_radScore1);
            _grbQuestion.Controls.Add(_radScore2);
            _grbQuestion.Controls.Add(_radScore3);
            _grbQuestion.Controls.Add(_radScore4);
            _grbQuestion.Controls.Add(_radScore5);

            flwQuestions.Controls.Add(_grbQuestion);
            _id++;
            txtAddQuestion.Clear();
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e) {
        }

        private void lstTemplateQuestions_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private GroupBox TestGroupBox(int id, string text) {
            GroupBox grbBox = new GroupBox();
            grbBox.Location = new Point(3, 3);
            grbBox.Name = "grbQuestion " + id;
            grbBox.Size = new Size(195, 120);
            grbBox.TabIndex = 1;
            grbBox.TabStop = false;
            grbBox.Text = text;
            return grbBox;
        }

        private TextBox TestTextBox(int id) {
            TextBox txtBox = new TextBox();
            txtBox.Location = new Point(6, 19);
            txtBox.Multiline = true;
            txtBox.Name = "txtComment " + id;
            txtBox.Size = new Size(179, 56);
            txtBox.TabIndex = 1;
            return txtBox;
        }

        private RadioButton TestScore(int id, int score, int x, int y) {
            RadioButton radBtn = new RadioButton();
            radBtn.AutoSize = true;
            radBtn.Location = new Point(x, y);
            radBtn.Name = "radioScore " + id;
            radBtn.Size = new Size(31, 17);
            radBtn.TabIndex = 2;
            radBtn.TabStop = true;
            radBtn.Text = " " + score;
            radBtn.UseVisualStyleBackColor = true;
            return radBtn;
        }

        #endregion
    }
}
