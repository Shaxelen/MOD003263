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
    public partial class FeedbackCreatorForm : Form {
        // Bank Objects
        private Bank _bank = Bank.Instance;

        // Feedback Objects
        private Feedback _feedback = new Feedback();

        // Question Objects
        private int _id = 0;
        private List<Question> _selectedQuestions = new List<Question>();
        private Category _selectedCategory;

        //Counter Object
        private int _questionCount = 0;

        public FeedbackCreatorForm() {
            InitializeComponent();
            Start();
        }

        private void Start() {
            foreach (Category c in _bank.Categories.Categories) {
                cmbCategory.Items.Add(c.Title);
            }
        }

        private void menuSaveTemplate_Click(object sender, EventArgs e) {
            SaveFeedbackForm saveForm = new SaveFeedbackForm();
            saveForm.Parent = this;
            saveForm.ShowDialog();
        }

        private void menuLoadTemplate_Click(object sender, EventArgs e) {
            LoadFeedbackForm loadForm = new LoadFeedbackForm();
            loadForm.Parent = this;
            loadForm.ShowDialog();
        }

        private void addQuestionToForm(Question question) {
            GroupBox grbQuestion = QuestionGroupBox(_id, question.Title);
            for (int i = 0; i < 5; i++) {
                RadioButton radScore = Score(_id, i + 1, 6 + (i * 37), 16);
                grbQuestion.Controls.Add(radScore);
            }
            question.ID = _id;
            flwQuestions.Controls.Add(grbQuestion);
            cmbQuestionID.Items.Add((_id + 1));
            _id++;
            _questionCount++;
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

        private void reOrderQuestions() {
            _feedback.Questions = _feedback.Questions.OrderBy(q => q.ID).ToList();
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e) {
            if (!inputCheckForLetter(cmbQuestionID.Text)) {
                int index = int.Parse(cmbQuestionID.Text) - 1;
                string app = cmbQuestionID.Text + ":";
                _questionCount--;

                foreach (GroupBox g in flwQuestions.Controls) {
                    if (g.Name.Contains(Convert.ToString(index)) && g.Text.Contains(app)) {
                        app = g.Text.Split(':')[1].TrimStart(' ');
                        flwQuestions.Controls.Remove(g);
                        break;
                    }
                }
                Question compToRemove = null;
                foreach (Question q in _feedback.Questions) {
                    if (q.Title == app) {
                        compToRemove = q;
                        break;
                    }
                }
                _feedback.RemoveQuestion(compToRemove.ID);
                cmbQuestionID.Items.Remove(index);
                reOrderQuestions();
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
            foreach(Question q in _feedback.Questions) {
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

        private void btnClearQuestions_Click(object sender, EventArgs e) {
            flwQuestions.Controls.Clear();
            _feedback.Questions.Clear();
            _questionCount = 0;
            _id = 0;
        }

        public Feedback CurrentFeedback {
            get { return _feedback; }
            set { _feedback = value; }
        }

        private Category findCategory(string title) {
            foreach (Category c in _bank.Categories.Categories) {
                if (c.Title == title) {
                    return c;
                }
            }
            return null;
        }

        private void btnSelectCategory_Click(object sender, EventArgs e) {
            if (cmbCategory.Text != "") {
                Category cat = findCategory(cmbCategory.Text);
                if (null != cat) {
                    lstQuestions.Items.Clear();
                    foreach (Question q in cat.Questions) {
                        lstQuestions.Items.Add(q.Title);
                    }
                    _selectedCategory = cat;
                } else {
                    MessageBox.Show("Invalid Category, Please Select Another", "Error");
                }
                
            } else {
                MessageBox.Show("You need to select a category first.", "Error");
            }
        }

        private void btnAddQuestions_Click(object sender, EventArgs e) {
            if (_selectedQuestions.Count != 0) {
                foreach (Question q in _selectedQuestions) {
                    addQuestionToForm(q);
                    _feedback.AddQuestion(q);
                }
            } else {
                MessageBox.Show("You need to pick at least one Question to Add.", "Error");
            }
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstQuestions.SelectedIndices.Count != 0) {
                _selectedQuestions.Clear();
                foreach (Question q in _selectedCategory.Questions) {
                    foreach (string item in lstQuestions.SelectedItems) {
                        if (q.Title == item) {
                            _selectedQuestions.Add(q);
                        }
                    }
                }
            }
        }
    }
}