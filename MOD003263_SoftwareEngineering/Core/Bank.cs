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
        private FeedbackBank _feedbackBank = new FeedbackBank();
        private TemplateBank _templateBank = new TemplateBank();
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
        }

        public void LoadBank() {
            /*_instance = _serializer.Load();
            _instance.Applicants.Applicants = DatabaseMetaLayer.Instance().GetApplicants();*/
        }

        /// <summary>
        /// Returns the Feedback Bank
        /// </summary>
        public FeedbackBank Feedbacks {
            get {
                SaveBank();
                return _feedbackBank;
            }
        }

        /// <summary>
        /// Returns the Template Bank
        /// </summary>
        public TemplateBank Templates {
            get {
                SaveBank();
                return _templateBank;
            }
        }
        /// <summary>
        /// Returns the Category Bank
        /// </summary>
        public CategoryBank Categories {
            get {
                SaveBank();
                return _categoryBank;
            }
        }

        /// <summary>
        /// Returns the Applicant Bank
        /// </summary>
        public ApplicantBank Applicants {
            get {
                SaveBank();
                return _applicantBank;
            }
        }
    }
}
