using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    public class FeedbackFilter {
        private FeedbackBank _feedbackBank = FeedbackBank.Instance();
        private List<Feedback> _acceptList = new List<Feedback>();
        private List<Feedback> _rejectList = new List<Feedback>();

        public FeedbackFilter() { } 

        public List<Feedback> FilterList {
            get { return _feedbackBank.FeedbackList; }
        }

        public void Accept(Feedback feedback) {
            _acceptList.Add(feedback);
        }

        public void Reject(Feedback feedback) {
            _rejectList.Add(feedback);
        }

        public List<Feedback> AcceptList {
            get { return _acceptList; }
        }

        public List<Feedback> RejectList {
            get { return _rejectList; }
        }
    }
}
