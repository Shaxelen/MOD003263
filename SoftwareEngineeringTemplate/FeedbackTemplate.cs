using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringTemplate {
    class FeedbackTemplate {
        private List<QuestionTemplate> m_questionList = new List<QuestionTemplate>();
        private Applicant m_applicant;
        private string m_feedbackerName;
        private DateTime m_dateFeedbacked;

        public  FeedbackTemplate() {

        }
        public void LoadApplicant(Applicant applicant) {
            m_applicant = applicant;
        }

        public void AddQuestion() {

        }
        public void EditQuestion() {

        }
        public void RemoveQuestion() {

        }
        public QuestionTemplate FindQuestion() {
            return null;
        }

        public string FeedbackerName {
            get { return m_feedbackerName; }
            set { m_feedbackerName = value; }
        }
        public DateTime DateFeedbacked {
            get { return m_dateFeedbacked; }
            set { m_dateFeedbacked = value; }
        }

        public Applicant CurrentApplicant {
            get { return m_applicant; }
        }
    }
}
