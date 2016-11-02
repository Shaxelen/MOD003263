using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringTemplate {
    class FeedbackBank {
        private List<FeedbackTemplate> m_feedbackTemplateList = new List<FeedbackTemplate>();

        private static FeedbackBank m_feedbackBankInstance = null;
        private FeedbackBank() { }

        public static FeedbackBank FeedbackBankInstance() {
            if (m_feedbackBankInstance == null) {
                m_feedbackBankInstance = new FeedbackBank();
            }
            return m_feedbackBankInstance;
        }

        public void AddFeedbackTemplate() { }

        public void RemoveFeedbackTemplate() { }

        public FeedbackTemplate FindFeedbackTemplate() {
            // Return a template if found

            // Else null
            return null;
        }
    }
}
