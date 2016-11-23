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

        private Bank() { }

        public static Bank Instance() {
            if (null == _instance) {
                _instance = new Bank();
            }
            return _instance;
        }
    }
}
