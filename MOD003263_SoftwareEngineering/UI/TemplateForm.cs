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
    public partial class TemplateForm : Form {
        // Template Objects
        private TemplateFactory _templateFactory;
        private TemplateEditor _tempEditor;
        private Template _template;
        private TemplateBank _templateBank;

        // Question Objects
        private Question _question;
        private int _id = 0;

        // Question Form Objects
        private GroupBox _grbQuestion;
        private TextBox _txtComment;
        private RadioButton[] _radScores = new RadioButton[5];

        // Form Objects
        private TestSaveForm _saveForm;
        private TestLoadForm _loadForm;

        //Counter Object
        private int _questionCount = 0;

        public TemplateForm() {
            InitializeComponent();
            Start();
        }

        private void Start() {
            _templateFactory = new TemplateFactory();
            _tempEditor = new TemplateEditor(_templateFactory);
            _templateBank = TemplateBank.Instance();
        }
        #region Requesting Template

        private void menuCVTemplate_Click(object sender, EventArgs e) {
            templateRequest("CV");
        }

        private void menuInterviewTemplate_Click(object sender, EventArgs e) {
            templateRequest("Interview");
        }

        private void menuEmployeeTemplate_Click(object sender, EventArgs e) {
            templateRequest("Employee");
        }

        private void templateRequest(string type) {
            grbFeedbackTemplate.Visible = true;
            _template = _tempEditor.RequestTemplate(type);
            Text = _template.TemplateName;
            grbFeedbackTemplate.Visible = true;
            grbAddQuestion.Visible = true;
            grbRemoveQuestion.Visible = true;
            grbClearQuestions.Visible = true;
        }
        #endregion

        #region Saving/Loading Templates

        private void menuSaveTemplate_Click(object sender, EventArgs e) {
            _saveForm = new TestSaveForm();
            _saveForm.Parent = this;
            _saveForm.ShowDialog();
        }

        private void menuLoadTemplate_Click(object sender, EventArgs e) {
            _loadForm = new TestLoadForm();
            _loadForm.Parent = this;
            _loadForm.ShowDialog();
        }

        public void RetrieveTemplate(string template) {
            _template = _templateBank.Load(template);
            Text = _template.TemplateName;
        }

        #endregion

        #region Creating, Adding and Removing Questions

        private void btnAddQuestion_Click(object sender, EventArgs e) {
            if (_questionCount < 12) {
                _question = new Question();
                _question.Title = txtAddQuestion.Text;
                _question.ID = _id;
                _question.Comment = "";
                _question.Score = 0;
                _grbQuestion = QuestionGroupBox(_id, txtAddQuestion.Text);
                _txtComment = CommentTextBox(_id);
                _grbQuestion.Controls.Add(_txtComment);
                for (int i = 0; i < 5; i++) {
                    _radScores[i] = Score(_id, i+1, 6 + (i * 37), 81);
                    _grbQuestion.Controls.Add(_radScores[i]);
                }
                flwQuestions.Controls.Add(_grbQuestion);
                _template.AddQuestion(_question);
                cmbQuestionID.Items.Add((_id + 1));
                _id++;
                _questionCount++;
            } else {
                MessageBox.Show("Cannot Fit anymore Questions on Template");
            }
            txtAddQuestion.Clear();
        }

        private bool inputCheckForLetter(string toCheck) {
            toCheck = toCheck.ToLower();
            return (toCheck.Contains("a") || toCheck.Contains("b") || toCheck.Contains("c") || toCheck.Contains("d") || toCheck.Contains("e")
                 || toCheck.Contains("f") || toCheck.Contains("g") || toCheck.Contains("h") || toCheck.Contains("i") || toCheck.Contains("j")
                  || toCheck.Contains("k") || toCheck.Contains("l") || toCheck.Contains("m") || toCheck.Contains("n") || toCheck.Contains("o")
                   || toCheck.Contains("p") || toCheck.Contains("q") || toCheck.Contains("r") || toCheck.Contains("s") || toCheck.Contains("t")
                    || toCheck.Contains("u") || toCheck.Contains("v") || toCheck.Contains("w") || toCheck.Contains("x") || toCheck.Contains("y")
                     || toCheck.Contains("z"));
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e) {
            if (!inputCheckForLetter(cmbQuestionID.Text)) {
                int index = int.Parse(cmbQuestionID.Text) - 1;
                _questionCount--;

                foreach (GroupBox g in flwQuestions.Controls) {
                    if (g.Name.Contains(Convert.ToString(index))) {
                        flwQuestions.Controls.Remove(g);
                    }
                }
                Question compToRemove = null;
                foreach (Question q in _template.Questions) {
                    if (q.ID == index) {
                        compToRemove = q;
                        break;
                    }
                }
                _template.RemoveQuestion(compToRemove.ID);
                cmbQuestionID.Items.Remove(index);
                updateComboBox();
            }
            else {
                MessageBox.Show("Question Number should not contain Letters!");
                cmbQuestionID.Text = "";
                cmbQuestionID.Focus();
            }
        }

        /// <summary>
        /// Finds all of the Groupboxes that are Question Groupboxes within the FlowPanel Control
        /// </summary>
        /// <returns> Returns a List of Groupboxes that are Question Groupboxes </returns>
        private List<GroupBox> findAllGrps() {
            List<GroupBox> grp = new List<GroupBox>();
            foreach (Control c in flwQuestions.Controls) {
                if ((c.GetType() == typeof(GroupBox)) && (c.Name.Contains("grbQuestion"))) {
                    grp.Add((GroupBox)c);
                }
            }
            return grp;
        }

        /// <summary>
        /// Updates the ComboBox and re-indexes all of the questions and their groupboxes
        /// </summary>
        private void updateComboBox() {
            List<GroupBox> grp = findAllGrps();
            int questIndex = 0;
            cmbQuestionID.Items.Clear();
            foreach(Question q in _template.Questions) {
                foreach (GroupBox g in grp) {
                    if (g.Name.Contains(q.ID.ToString())) {
                        g.Name = "grbQuestion " + questIndex;
                        g.Text = "Question " + (questIndex + 1) + ": " + q.Title;
                        break;
                    }
                }
                q.ID = questIndex;
                cmbQuestionID.Items.Add(q.ID + 1);
                questIndex++;
            }
            _id = questIndex;
            cmbQuestionID.Text = "";
        }

        /// <summary>
        /// Creates a GroupBox for Questions
        /// </summary>
        /// <param name="id">The id of the question</param>
        /// <param name="text">The question text</param>
        /// <returns>A GroupBox</returns>
        private GroupBox QuestionGroupBox(int id, string text) {
            GroupBox grbBox = new GroupBox();
            grbBox.Location = new Point(3, 3);
            grbBox.Name = "grbQuestion " + id;
            grbBox.Size = new Size(195, 120);
            grbBox.TabIndex = 1;
            grbBox.TabStop = false;
            grbBox.Text = "Question " + (id + 1) + ": " + text;
            return grbBox;
        }

        /// <summary>
        /// Creates a TextBox for question comments
        /// </summary>
        /// <param name="id">The id of the question</param>
        /// <returns>A TextBox</returns>
        private TextBox CommentTextBox(int id) {
            TextBox txtBox = new TextBox();
            txtBox.Location = new Point(6, 19);
            txtBox.Multiline = true;
            txtBox.Name = "txtComment " + id;
            txtBox.Size = new Size(179, 56);
            txtBox.TabIndex = 1;
            return txtBox;
        }

        /// <summary>
        /// Creates a RadioButton for question score
        /// </summary>
        /// <param name="id">The id of the question</param>
        /// <param name="score">The score of the question</param>
        /// <param name="x">Position X</param>
        /// <param name="y">Position Y</param>
        /// <returns></returns>
        private RadioButton Score(int id, int score, int x, int y) {
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

        private void TemplateForm_FormClosing(object sender, FormClosingEventArgs e) {
            ScreenForm sf = (ScreenForm)MdiParent;
            sf.TemplateForm = null;
        }

        private void btnClearQuestions_Click(object sender, EventArgs e) {
            flwQuestions.Controls.Clear();
            _template.Questions.Clear();
            _questionCount = 0;
            _id = 0;
        }

        public Template CurrentTemplate {
            get { return _template; }
            set { _template = value; }
        }
    }
}