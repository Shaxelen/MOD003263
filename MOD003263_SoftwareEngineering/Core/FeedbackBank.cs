using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class FeedbackBank {
        private static List<Feedback> _feedbackList = new List<Feedback>();

        public FeedbackBank() { }

        public void Add(Feedback feedback) {
            _feedbackList.Add(feedback);
        }

        public List<Feedback> FeedbackList {
            get { return _feedbackList; }
        }

        public Feedback FindFeedback(string title) {
            foreach (Feedback f in _feedbackList) {
                if (f.Title == title) {
                    return f;
                }
            }
            return null;
        }

        public void Remove(string title) {
            Feedback temp = null;
            for (int i = 0; i < _feedbackList.Count; i++) {
                if (_feedbackList[i].Title == title) {
                    temp = _feedbackList[i];
                    break;
                }
            }
            _feedbackList.Remove(temp);
        }

        public void Update(string title, Feedback feedback) {
            for (int i = 0; i < _feedbackList.Count; i++) {
                if (_feedbackList[i].Title == title) {
                    _feedbackList[i] = feedback;
                    break;
                }
            }
        }
    }
}
