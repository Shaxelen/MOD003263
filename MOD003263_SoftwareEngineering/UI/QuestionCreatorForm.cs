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
    public partial class QuestionCreatorForm : Form {
        private Bank _bank = Bank.Instance;
        private List<Category> _selectedCategories = new List<Category>();
        private Question _question;
        private int id = 0;

        public QuestionCreatorForm() {
            InitializeComponent();
            _bank.LoadBank();
            _bank = Bank.Instance;
            loadCategories();
        }

        private void loadCategories() {
            lstCategoryList.Items.Clear();
            foreach (Category c in _bank.Categories.Categories) {
                lstCategoryList.Items.Add(c.Title);
            }
            _bank.SaveBank();
        }

        private void loadQuestions(string selectedCategory) {
            lstQuestions.Items.Clear();
            List<Question> questions;
            Category cat;

            foreach (Category c in _selectedCategories) {
                if (selectedCategory == c.Title) {
                    cat = c;
                    questions = cat.Questions;
                    foreach (Question q in questions) {
                        lstQuestions.Items.Add(q.Title);
                    }
                }
            }
        }

        private void updateCategoryBoxes() {
            loadCategories();
            txtCategory.Text = "";
        }

        private void updateQuestionBoxes() {
            txtGenericOne.Text = "";
            txtGenericTwo.Text = "";
            txtGenericThree.Text = "";
            txtGenericFour.Text = "";
            txtGenericFive.Text = "";
            txtQuestion.Text = "";
            deselectListbox();
        }

        private void populateQuestionBoxes(Question question) {
            txtGenericOne.Text = question.FeedbackList[0];
            txtGenericTwo.Text = question.FeedbackList[1];
            txtGenericThree.Text = question.FeedbackList[2];
            txtGenericFour.Text = question.FeedbackList[3];
            txtGenericFive.Text = question.FeedbackList[4];
            txtQuestion.Text = question.Title;
        }

        private void editQuestion(Question question) {
            question.FeedbackList[0] = txtGenericOne.Text;
            question.FeedbackList[1] = txtGenericTwo.Text;
            question.FeedbackList[2] = txtGenericThree.Text;
            question.FeedbackList[3] = txtGenericFour.Text;
            question.FeedbackList[4] = txtGenericFive.Text;
            question.Title = txtQuestion.Text = question.Title;
        }

        private void deselectListbox() {
            for (int i = 0; i < lstCategoryList.Items.Count; i++) {
                lstCategoryList.SetSelected(i, false);
            }
        }

        private bool checkQuestionFields() {
            if (txtGenericOne.Text == "" || txtGenericTwo.Text == "" || txtGenericThree.Text == "" || txtGenericFour.Text == "" || txtGenericFive.Text == "") {
                MessageBox.Show("You need to fill in all the Feedback Boxes.", "Error");
                txtGenericOne.Focus();
                return false;
            } else if (txtQuestion.Text == "") {
                MessageBox.Show("You need to give the Question a Title.", "Error");
                txtQuestion.Focus();
                return false;
            }
            else {
                return true;
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e) {
            if (_selectedCategories.Count != 0) {
                if (checkQuestionFields()) {
                    _question = new Question();
                    _question.Title = txtQuestion.Text;
                    _question.FeedbackList = new string[5] {
                        txtGenericOne.Text,
                        txtGenericTwo.Text,
                        txtGenericThree.Text,
                        txtGenericFour.Text,
                        txtGenericFive.Text
                    };
                    foreach (Category c in _selectedCategories) {
                        id = c.Questions.Count + 1;
                        _question.ID = id;
                        c.Add(_question);
                    }
                    MessageBox.Show("Question " + _question.Title + " created", "Success");
                    updateQuestionBoxes();
                }
            } else {
                MessageBox.Show("You need to pick at least one Category.", "Error");
                lstCategoryList.Focus();
            }
            _bank.SaveBank();
        }

        private void btnAddCategory_Click(object sender, EventArgs e) {
            if (txtCategory.Text != "") {
                Category c = new Category(txtCategory.Text);
                _bank.Categories.Add(c);
                updateCategoryBoxes();
            } else {
                MessageBox.Show("You need to give the Category a Name.", "Error");
                txtCategory.Focus();
            }
            _bank.SaveBank();
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e) {

        }

        private void lstCategoryList_SelectedIndexChanged(object sender, EventArgs e) {
            btnAddQuestion.Visible = true;
            btnSaveQuestion.Visible = false;

            if (lstCategoryList.SelectedIndices.Count != 0) {
                _selectedCategories.Clear();
                foreach (Category c in _bank.Categories.Categories) {
                    foreach (string item in lstCategoryList.SelectedItems) {
                        if (c.Title == item) {
                            _selectedCategories.Add(c);
                            loadQuestions(c.Title);
                        }
                    }
                }
            }
            _bank.SaveBank();
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e) {
            btnAddQuestion.Visible = false;
            btnSaveQuestion.Visible = true;
            foreach (Question q in _selectedCategories[0].Questions) {
                if (q.Title == lstQuestions.SelectedItem.ToString()) {
                    _question = q;
                }
            }
            populateQuestionBoxes(_question);
        }

        private void QuestionCreatorForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm pf = (ParentForm)MdiParent;
            pf.QuestionCreatorForm = null;
        }

        private void saveOver(Question old, Question toSave) {

        }
    }
}