using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class FeedbackBank {
        private static List<Feedback> _feedbackList = new List<Feedback>();
        private static FeedbackBank _instance = null;

        /// <summary>
        /// FeedbackBank Constructor
        /// </summary>
        private FeedbackBank() { }

        /// <summary>
        /// The static instance of FeedbackBank
        /// </summary>
        /// <returns>FeedbackBank instance</returns>
        public static FeedbackBank Instance() {
            if (null == _instance) {
                _instance = new FeedbackBank();
            }
            return _instance;
        }

        /// <summary>
        /// Adds a feedback to the feedbackBank
        /// </summary>
        /// <param name="feedback">The feedback to add</param>
        public void Add(Feedback feedback) {
            _feedbackList.Add(feedback);
        }

        /// <summary>
        /// Returns the list of feedbacks
        /// </summary>
        public List<Feedback> FeedbackList {
            get { return _feedbackList; }
        }

        /// <summary>
        /// Finds a feedback by the title
        /// </summary>
        /// <param name="title">The title of thee feedback to find</param>
        /// <returns></returns>
        public Feedback FindFeedback(string title) {
            Feedback temp = null;
            foreach (Feedback f in _feedbackList) {
                if (f.GetTitle == title) {
                    temp = f;
                    break;
                }
            }
            return temp;
        }
    }
}
