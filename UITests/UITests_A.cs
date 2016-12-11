using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            a.ImageFileLocation = "file.png";
            a.CVLocation = "file.png";
            a.TotalScore = 2;

            Assert.AreEqual(111, a.ApplicantID);
            Assert.AreEqual("Alex", a.FirstName);
            Assert.AreEqual("Wyke", a.LastName);
            Assert.AreEqual("alexwyke@icloud.com", a.EmailAddress);
            Assert.AreEqual("07456679770", a.PhoneNumber);
            Assert.AreEqual("Website Developer", a.ApplicantPosition);
            Assert.AreEqual("file.png", a.ImageFileLocation);
            Assert.AreEqual("file.png", a.CVLocation);
            Assert.AreEqual(2, a.TotalScore);
            Assert.AreEqual(a.FirstName + " " + a.LastName, a.FullName);
        }

        [TestMethod]
        public void EmployeeTest() {
            Employee e = new Employee();

            e.EmployeeID = 222;
            e.FirstName = "David";
            e.LastName = "Cundy";
            e.EmailAddress = "d.cundy@hotmail.com";
            e.PhoneNumber = "07345678900";
            e.EmployeePosition = "IT Supervisor";
            e.ImageFileLocation = null;

            Assert.AreEqual(222, e.EmployeeID);
            Assert.AreEqual("David", e.FirstName);
            Assert.AreEqual("Cundy", e.LastName);
            Assert.AreEqual("d.cundy@hotmail.com", e.EmailAddress);
            Assert.AreEqual("07345678900", e.PhoneNumber);
            Assert.AreEqual("IT Supervisor", e.EmployeePosition);
            Assert.AreEqual("default.png", e.ImageFileLocation);
        }
    }
}
