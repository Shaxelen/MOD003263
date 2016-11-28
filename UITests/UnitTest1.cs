using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOD003263_SoftwareEngineering.Forms;
using MOD003263_SoftwareEngineering.UI;
using MOD003263_SoftwareEngineering.Core;

namespace UITests {
    [TestClass]
    public class UnitTest {
        [TestMethod]
        public void ApplicantTest() {
            Applicant a = new Applicant();

            a.ApplicantID = 111;
            a.FirstName = "Alex";
            a.LastName = "Wyke";
            a.EmailAddress = "alexwyke@icloud.com";
            a.PhoneNumber = "07456679770";
            a.ApplicantPosition = "Website Developer";
        }

        public void EmployeeTest() {
            Employee e = new Employee();

            e.EmployeeID = 222;
            e.FirstName = "David";
            e.LastName = "Cundy";
            e.EmailAddress = "d.cundy@hotmail.com";
            e.PhoneNumber = "07345678900";
            e.EmployeePosition = "IT Supervisor";
        }
    }
}
