using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD003263_SoftwareEngineering.Meta;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class Bank {
        private static FeedbackSerializer _serializer = new FeedbackSerializer();
        private static DatabaseMetaLayer _databaseMetaLayer = DatabaseMetaLayer.Instance;
        private FeedbackBank _feedbackBank = new FeedbackBank();
        private CategoryBank _categoryBank = new CategoryBank();
        private ApplicantBank _applicantBank = new ApplicantBank();
        private static Bank _instance = null;

        /// <summary>
        /// The Constructor for Bank
        /// </summary>
        private Bank() { }

        /// <summary>
        /// Returns the Current instance of Bank if it exists, if it doesnt, it makes a new instance and returns that.
        /// </summary>
        /// <returns>Returns the current Instance of Bank</returns>
        public static Bank Instance {
            get {
                if (null == _instance) {
                    _instance = new Bank();
                }
                return _instance;
            }
        }

        public void SaveBank() {
            _serializer.Save(Bank.Instance);
            List<Applicant> LoadedApplicants = _databaseMetaLayer.GetApplicants();
            foreach (Applicant app in LoadedApplicants) {
                _databaseMetaLayer.DeletePerson(app);
            }
            _applicantBank.Applicants = combineLists(LoadedApplicants, _applicantBank.Applicants);
            foreach (Applicant aip in _applicantBank.Applicants) {
                _databaseMetaLayer.InsertPerson(aip, aip.ApplicantPosition, false);
            }
        }

        private List<Applicant> combineLists(List<Applicant> appOne, List<Applicant> appTwo) {
            List<Applicant> newApp = new List<Applicant>(appOne);
            foreach (Applicant a in appTwo) {
                if (!newApp.Contains(a)) {
                    newApp.Add(a);
                }
            }
            return newApp;
        }

        public void LoadBank() {
            _instance = _serializer.Load();
            if (null != _instance) {
                _instance.Applicants.Applicants = DatabaseMetaLayer.Instance.GetApplicants();
            }
        }

        /// <summary>
        /// Returns the Feedback Bank
        /// </summary>
        public FeedbackBank Feedbacks {
            get {
                return _feedbackBank;
            }
        }

        /// <summary>
        /// Returns the Category Bank
        /// </summary>
        public CategoryBank Categories {
            get {
                return _categoryBank;
            }
        }

        /// <summary>
        /// Returns the Applicant Bank
        /// </summary>
        public ApplicantBank Applicants {
            get {
                return _applicantBank;
            }
        }
    }
}
