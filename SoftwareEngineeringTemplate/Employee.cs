using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringTemplate {
    class Employee : Applicant {
        private string m_employeeNumber;

        public Employee() : base() {

        }

        public string EmployeeNumber {
            get {
                return m_employeeNumber;
            }
            set {
                m_employeeNumber = value;
            }
        }

    }
}
