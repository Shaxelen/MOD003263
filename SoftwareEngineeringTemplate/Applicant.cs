using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringTemplate {
    class Applicant {
        private string m_applicantImageFile;
        private string m_applicantFirstName;
        private string m_applicantLastName;
        private string m_applicantEmailAddress;
        private string m_applicantPhoneNumber;
        private string m_position;

        private string m_defaultImageFile;

        public Applicant() {

        }

        public string ApplicantImageLocation {
            get {
                return m_applicantImageFile;
            }
            set {
                if (m_applicantImageFile == null) {
                    m_applicantImageFile = m_defaultImageFile;
                }
                m_applicantImageFile = value;
            }
        }
        public string ApplicantFirstName {
            get {
                return m_applicantFirstName;
            }
            set {
                m_applicantFirstName = value;
            }
        }
        public string ApplicantLasttName {
            get {
                return m_applicantLastName;
            }
            set {
                m_applicantLastName = value;
            }
        }
        public string ApplicantEmailAddress {
            get {
                return m_applicantEmailAddress;
            }
            set {
                m_applicantEmailAddress = value;
            }
        }
        public string ApplicantPhoneNumber {
            get {
                return m_applicantPhoneNumber;
            }
            set {
                m_applicantPhoneNumber = value;
            }
        }
        public string Position {
            get {
                return m_position;
            }
            set {
                m_position = value;
            }
        }
    }
}
