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
        private Bank _bank = Bank.Instance();
        private List<Category> _selectedCategories = new List<Category>();
        private int id = 0;

        public QuestionCreatorForm() {
            InitializeComponent();
            _bank.LoadBank();
            _bank = Bank.Instance();
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
                } else {
                    if (txtQuestion.Text != "") {
                        Question q = new Question();
                        q.Title = txtQuestion.Text;
                        q.ID = id;
                        q.FeedbackList = new string[5] { txtGenericOne.Text, txtGenericTwo.Text, txtGenericThree.Text, txtGenericFour.Text, txtGenericFive.Text };
                        id++;
                        foreach (Category c in _selectedCategories) {
                            c.Add(q);
                        }
                        MessageBox.Show("Question " + q.Title + " created", "Success");
                        updateQuestionBoxes();
                    }
                    else {
                        MessageBox.Show("You need to give the Question a Title.", "Error");
                    }
                }
            } else {
                MessageBox.Show("You need to pick at least one Category.", "Error");
            }
            _bank.SaveBank();
        }

        private void btnAddCategory_Click(object sender, EventArgs e) {
            Category c = new Category(txtCategory.Text);
            _bank.Categories.Add(c);
            updateCategoryBoxes();
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
    }
}