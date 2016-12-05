using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class Bank {
        private FeedbackBank _feedbackBank = new FeedbackBank();
        private TemplateBank _templateBank = new TemplateBank();
        private CategoryBank _categoryBank = new CategoryBank();
        private static Bank _instance = null;

        /// <summary>
        /// The Constructor for Bank
        /// </summary>
        private Bank() { }

        /// <summary>
        /// Returns the Current instance of Bank if it exists, if it doesnt, it makes a new instance and returns that.
        /// </summary>
        /// <returns>Returns the current Instance of Bank</returns>
        public static Bank Instance() {
            if (null == _instance) {
                _instance = new Bank();
            }
            return _instance;
        }

        /// <summary>
        /// Returns the Feedback Bank
        /// </summary>
        public FeedbackBank Feedbacks {
            get { return _feedbackBank; }
        }

        /// <summary>
        /// Returns the Template Bank
        /// </summary>
        public TemplateBank Templates {
            get { return _templateBank; }
        }
        /// <summary>
        /// Returns the Category Bank
        /// </summary>
        public CategoryBank Categories {
            get { return _categoryBank; }
        }
    }
}
