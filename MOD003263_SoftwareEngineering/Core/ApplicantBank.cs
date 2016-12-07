using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class ApplicantBank {
        private List<Applicant> _applicants = new List<Applicant>();

        public ApplicantBank() { }


        public void Add(Applicant applicant) {
            _applicants.Add(applicant);
        }

        public Applicant FindApplicant(int id) {
            foreach (Applicant a in _applicants) {
                if (a.ApplicantID == id) {
                    return a;
                }
            }
            return null;
        }

        public List<Applicant> Applicants {
            get { return _applicants; }
        }

        public void Remove(int id) {
            Applicant temp = null;
            for (int i = 0; i < _applicants.Count; i++) {
                if (_applicants[i].ApplicantID == id) {
                    temp = _applicants[i];
                    break;
                }
            }
            _applicants.Remove(temp);
        }

        public void Update(int id, Applicant applicant) {
            for (int i = 0; i < _applicants.Count; i++) {
                if (_applicants[i].ApplicantID == id) {
                    _applicants[i] = applicant;
                    break;
                }
            }
        }
    }
}