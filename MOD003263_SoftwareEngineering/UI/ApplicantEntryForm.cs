using MOD003263_SoftwareEngineering.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MOD003263_SoftwareEngineering.UI {
    public partial class ApplicantEntryForm : Form {
        private int i = 0;
        private Bank _bank = Bank.Instance;
        private Applicant _applicant = new Applicant();

        public ApplicantEntryForm() {
            InitializeComponent();
            loadApplicantZero();
        }

        private void loadApplicantZero() {
            if (_bank.Applicants.Applicants.Count != 0) {
                txtID.Text = _bank.Applicants.Applicants[0].ApplicantID.ToString();
                txtFName.Text = _bank.Applicants.Applicants[0].FirstName;
                txtLName.Text = _bank.Applicants.Applicants[0].LastName;
                txtEmail.Text = _bank.Applicants.Applicants[0].EmailAddress;
                txtPhone.Text = _bank.Applicants.Applicants[0].PhoneNumber;
                txtPosition.Text = _bank.Applicants.Applicants[0].ApplicantPosition;
            }
            else {
                txtID.Text = "0";
                i = 0;
            }
        }

        private void wrapNewApplicant() {
            txtID.Text = (i + 1).ToString();
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPosition.Text = "";
        }

        private void ApplicantEntryForm_FormClosing(object sender, FormClosingEventArgs e) {
            ParentForm pf = (ParentForm)MdiParent;
            pf.ApplicantEntryForm = null;
            _bank.SaveBank();
        }

        private void btnAddCV_Click(object sender, EventArgs e) {
            string cv = openDialog("pdf files (*.pdf)|*.pdf|All files (*.*)|*.*");
            _applicant.CVLocation = cv;
            MessageBox.Show(cv);
        }

        private string openDialog(string filter) {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = "c:\\";
            openDialog.Filter = filter;

            if (openDialog.ShowDialog() != DialogResult.OK) {

            }

            FileInfo fInfo = new FileInfo(openDialog.FileName);

            string _strFileName = fInfo.Name;
            string _strFilePath = fInfo.DirectoryName;
            string _fullPath = _strFilePath + _strFileName;

            return _fullPath;
        }

        private void btnAddAppImage_Click(object sender, EventArgs e) {
            string image = openDialog("jpeg images (*.jpg)|*.jpg|png images (*.png)|*.png|bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*");
            _applicant.ImageFileLocation = image;
            MessageBox.Show(image);
        }

        private bool checkApplicant() {
            return (_applicant.FirstName == "" || _applicant.EmailAddress == "" || _applicant.LastName == "" || _applicant.PhoneNumber == ""
                || _applicant.ImageFileLocation == "" || _applicant.CVLocation == "" || _applicant.ApplicantPosition == "");
        }

        private void btnAddApplicant_Click(object sender, EventArgs e) {
            if (!checkApplicant()) {
                _applicant.ApplicantID = (short)i;
                _applicant.ApplicantPosition = txtPosition.Text;
                _applicant.EmailAddress = txtEmail.Text;
                _applicant.FirstName = txtFName.Text;
                _applicant.LastName = txtLName.Text;
                _applicant.PhoneNumber = txtPhone.Text;
                _bank.Applicants.Add(_applicant);
            } else {
                MessageBox.Show("Some Applicant Data is Empty", "Error");
            }
        }

        private void btnSaveApplicant_Click(object sender, EventArgs e) {
            if (_bank.Applicants.Applicants.Contains(_bank.Applicants.FindApplicant(_applicant.FullName))) {
                Applicant a = _bank.Applicants.FindApplicant(_applicant.FullName);
                a.ApplicantPosition = txtPosition.Text;
                a.EmailAddress = txtEmail.Text;
                a.FirstName = txtFName.Text;
                a.LastName = txtLName.Text;
                a.PhoneNumber = txtPhone.Text;
                _bank.Applicants.Update(a.ApplicantID, a);
            } else {
                _bank.Applicants.Add(_applicant);
            }
        }

        private void btnNextApplicant_Click(object sender, EventArgs e)  {
            try {
                if (i == _bank.Applicants.Applicants.Count - 1) {
                    wrapNewApplicant();
                } else if (i < _bank.Applicants.Applicants.Count - 1) {
                    i += 1;
                    txtID.Text = _bank.Applicants.Applicants[i].ApplicantID.ToString();
                    txtFName.Text = _bank.Applicants.Applicants[i].FirstName;
                    txtLName.Text = _bank.Applicants.Applicants[i].LastName;
                    txtEmail.Text = _bank.Applicants.Applicants[i].EmailAddress;
                    txtPhone.Text = _bank.Applicants.Applicants[i].PhoneNumber;
                    txtPosition.Text = _bank.Applicants.Applicants[i].ApplicantPosition;
                } else {
                    loadApplicantZero();
                }
            } catch (Exception) {
                MessageBox.Show("Unable to load next applicant", "Error");
            }
        }

        private void btnPrevApplicant_Click(object sender, EventArgs e) {
            try {
                if (i < _bank.Applicants.Applicants.Count - 1 && i > 0) {
                    i -= 1;
                    txtID.Text = _bank.Applicants.Applicants[i].ApplicantID.ToString();
                    txtFName.Text = _bank.Applicants.Applicants[i].FirstName;
                    txtLName.Text = _bank.Applicants.Applicants[i].LastName;
                    txtEmail.Text = _bank.Applicants.Applicants[i].EmailAddress;
                    txtPhone.Text = _bank.Applicants.Applicants[i].PhoneNumber;
                    txtPosition.Text = _bank.Applicants.Applicants[i].ApplicantPosition;
                } else {
                    i = _bank.Applicants.Applicants.Count - 1;
                    txtID.Text = _bank.Applicants.Applicants[i].ApplicantID.ToString();
                    txtFName.Text = _bank.Applicants.Applicants[i].FirstName;
                    txtLName.Text = _bank.Applicants.Applicants[i].LastName;
                    txtEmail.Text = _bank.Applicants.Applicants[i].EmailAddress;
                    txtPhone.Text = _bank.Applicants.Applicants[i].PhoneNumber;
                    txtPosition.Text = _bank.Applicants.Applicants[i].ApplicantPosition;
                }
            } catch (Exception) {
                MessageBox.Show("Unable to load previous applicant", "Error");
            }
        }
    }
}