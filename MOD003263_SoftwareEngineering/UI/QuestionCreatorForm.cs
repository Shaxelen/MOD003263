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

        private void deselectListbox() {
            for (int i = 0; i < lstCategoryList.Items.Count; i++) {
                lstCategoryList.SetSelected(i, false);
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e) {
            if (_selectedCategories.Count != 0) {
                if (txtGenericOne.Text == "" || txtGenericTwo.Text == "" || txtGenericThree.Text == "" || txtGenericFour.Text == "" || txtGenericFive.Text == "") {
                    MessageBox.Show("You need to Fill in all Feedback Boxes.", "Error");
                    txtGenericOne.Focus();
                } else {
                    if (txtQuestion.Text != "") {
                        Question q = new Question();
                        q.Title = txtQuestion.Text;
                        q.FeedbackList = new string[5] { txtGenericOne.Text, txtGenericTwo.Text, txtGenericThree.Text, txtGenericFour.Text, txtGenericFive.Text };
                        foreach (Category c in _selectedCategories) {
                            id = c.Questions.Count + 1;
                            q.ID = id;
                            c.Add(q);
                        }
                        MessageBox.Show("Question " + q.Title + " created", "Success");
                        updateQuestionBoxes();
                    }
                    else {
                        MessageBox.Show("You need to give the Question a Title.", "Error");
                        txtQuestion.Focus();
                    }
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

        private void lstCategoryList_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstCategoryList.SelectedIndices.Count != 0) {
                _selectedCategories.Clear();
                foreach (Category c in _bank.Categories.Categories) {
                    foreach (string item in lstCategoryList.SelectedItems) {
                        if (c.Title == item) {
                            _selectedCategories.Add(c);
                        }
                    }
                }
            }
            _bank.SaveBank();
        }

        private void QuestionCreatorForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm pf = (ParentForm)MdiParent;
            pf.QuestionCreatorForm = null;
        }
    }
}