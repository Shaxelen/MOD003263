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

        /// <summary>
        /// FeedbackFilter Constructor
        /// </summary>
        public FeedbackFilter() { }

        /// <summary>
        /// Adds a feedback to the accept list
        /// </summary>
        /// <param name="feedback">The feedback to accept</param>
        public void Accept(Feedback feedback) {
            _acceptList.Add(feedback);
        }

        /// <summary>
        /// Adds a feedback to the reject list
        /// </summary>
        /// <param name="feedback">The feedback to reject</param>
        public void Reject(Feedback feedback) {
            _rejectList.Add(feedback);
        }

        /// <summary>
        /// Returns the list of accepted feedbacks
        /// </summary>
        public List<Feedback> AcceptList {
            get { return _acceptList; }
        }

        /// <summary>
        /// Returns the list of rejected feedbacks
        /// </summary>
        public List<Feedback> RejectList {
            get { return _rejectList; }
        }
    }
}
