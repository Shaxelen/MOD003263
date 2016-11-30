using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class Bank {
        private FeedbackBank _feedbackBank = FeedbackBank.Instance();
        private TemplateBank _templateBank = TemplateBank.Instance();
        private static Bank _instance = null;

        /// <summary>
        /// Bank Constructor
        /// </summary>
        private Bank() { }

        /// <summary>
        /// A static instance of Bank
        /// </summary>
        /// <returns>Bank instance</returns>
        public static Bank Instance() {
            if (null == _instance) {
                _instance = new Bank();
            }
            return _instance;
        }

        /// <summary>
        /// Returns FeedbackBank
        /// </summary>
        public FeedbackBank Feedbacks {
            get { return _feedbackBank; }
        }

        /// <summary>
        /// Returns TemplateBank
        /// </summary>
        public TemplateBank Templates {
            get { return _templateBank; }
        }
    }
}
