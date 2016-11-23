using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    public class FeedbackBank {
        private static List<Feedback> _feedbackList = new List<Feedback>();
        private static FeedbackBank _instance = null;

        private FeedbackBank() { }

        public static FeedbackBank Instance() {
            if (null == _instance) {
                _instance = new FeedbackBank();
            }
            return _instance;
        }

        public void Add(Feedback feedback) {
            _feedbackList.Add(feedback);
        }

        public List<Feedback> FeedbackList {
            get { return _feedbackList; }
        }
    }
}
