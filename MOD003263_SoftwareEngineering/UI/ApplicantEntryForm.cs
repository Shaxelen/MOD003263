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

        private void btnNextApplicant_Click(object sender, EventArgs e) {
            //If at end of List<Applicant>, show (new applicant) OR (first applicant) {You decide on which one}
            //Else show next Applicant in List<Applicant> {use the [] on List for precise indexing}

            try {
                if (i < _bank.Applicants.Applicants.Count - 1) {
                    i += 1;
                    txtID.Text = _bank.Applicants.Applicants[i].ApplicantID.ToString();
                    txtFName.Text = _bank.Applicants.Applicants[i].FirstName;
                    txtLName.Text = _bank.Applicants.Applicants[i].LastName;
                    txtEmail.Text = _bank.Applicants.Applicants[i].EmailAddress;
                    txtPhone.Text = _bank.Applicants.Applicants[i].PhoneNumber;
                    txtPosition.Text = _bank.Applicants.Applicants[i].ApplicantPosition;
                } else {

                }
            } catch (Exception) {

            }
        }

        private void btnPrevApplicant_Click(object sender, EventArgs e) {
            //If at beginning of List<Applicant>, show (new applicant) OR (last applicant) {You decide on which one}
            //Else show previous Applicant in List<Applicant> {use the [] on List for precise indexing}

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

                }
            } catch (Exception) {

            }
        }
    }
}
