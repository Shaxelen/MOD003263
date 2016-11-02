using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringTemplate {
    class QuestionTemplate {
        private string m_questionTitle;
        private string m_feedback;
        private string m_additionalFeedback;
        private byte m_score;

        public QuestionTemplate(string questionTitle) {
            m_questionTitle = questionTitle;
        }

        public QuestionTemplate(string title, string feedback, string additionalFeedback, byte score) : this(title) {
            m_feedback = feedback;
            m_additionalFeedback = additionalFeedback;
            m_score = score;
        }

        public string QuestionTitle {
            get { return m_questionTitle; }
            set { m_questionTitle = value; }
        }
        public string Feedback {
            get { return m_feedback; }
            set { m_feedback = value; }
        }
        public string AdditionalFeedback {
            get { return m_additionalFeedback; }
            set { m_additionalFeedback = value; }
        }
        public byte Score {
            get { return m_score; }
            // Min/Max score
            set { m_score = value; }
        }
    }
}
