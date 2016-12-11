﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOD003263_SoftwareEngineering.Meta;
using MOD003263_SoftwareEngineering.Debug;
using MOD003263_SoftwareEngineering.Core;
using System.Collections.Generic;
using System.Net;

namespace MetaUnitTests {
    [TestClass]
    public class MetaUnitTest {
        [TestMethod]
        public void TestProperties() {
            Assert.AreEqual(true, Properties.Settings.Default.Properties.Count == 0);
        }
        [TestMethod]
        public void TemplateSerializationTest() {
            FeedbackSerializer fs = new FeedbackSerializer();
            Bank bank = Bank.Instance;
            Feedback feedback = new Feedback();
            feedback.Title = "Test";
            Question q = new Question();
            q.Score = 3;
            q.Title = "Test";
            q.PickedFeedback = "Test Comment";
            feedback.AddQuestion(q);
            bank.Feedbacks.Add(feedback);

            bool test = fs.Save(bank);
            Assert.AreEqual(true, test);

            Bank b = fs.Load();
            Assert.AreEqual(bank.Feedbacks.FeedbackList, b.Feedbacks.FeedbackList);
        }
        [TestMethod]
        public void PDFConvertTest() {
            PDFConvert pdf = new PDFConvert();
            //Make Template to Save
            Feedback feedback = new Feedback();
            Question q = new Question();
            q.Score = 3;
            q.Title = "Test";
            q.PickedFeedback = "Test Comment";
            for (int i = 0; i < 5; i++) {
                feedback.AddQuestion(q);
            }

            //Make Employee
            Employee emp = new Employee();
            emp.EmployeeID = 0; emp.EmployeePosition = "Sales"; emp.EmailAddress = "DCundy@outlook.com"; emp.FirstName = "David"; emp.LastName = "Cundy"; emp.PhoneNumber = "07000000001";

            //Make Applicants
            Applicant app = new Applicant();
            app.ApplicantID = 0; app.ApplicantPosition = "Sales"; app.EmailAddress = "AWyke@gmail.com"; app.FirstName = "Alex"; app.LastName = "Wyke"; app.PhoneNumber = "07000000000";
            Applicant aip = new Applicant();
            aip.ApplicantID = 1; aip.ApplicantPosition = "Sales"; aip.EmailAddress = "NThurlow@outlook.com"; aip.FirstName = "Nathaniel"; aip.LastName = "Thurlow"; aip.PhoneNumber = "07000000002";

            bool test = pdf.ConvertApplicantTemplateToPDF(feedback, app);
            Assert.AreEqual(true, test);

            test = pdf.ConvertApplicantTemplateToPDF(feedback, aip);
            Assert.AreEqual(true, test);

            test = pdf.ConvertEmployeeTemplateToPDF(feedback, emp);
            Assert.AreEqual(true, test);

            test = pdf.ConvertApplicantTemplateToPDF(null, null);
            Assert.AreEqual(false, test);

            test = pdf.ConvertEmployeeTemplateToPDF(null, null);
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void EmailHandlerTest() {
            NetworkCredential nc = new NetworkCredential("softwareengineeringcwatest@outlook.com", "thisPasswordIsDumb");
            EmailHandler eh = new EmailHandler(nc);

            bool test = eh.SendEmail("skydriveshax@hotmail.co.uk", "Test", "This is Test Text", "test.pdf");
            Assert.AreEqual(true, test);

            test = eh.SendEmail("a", "Test", "This is Test Text", "");
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void DatabaseMetaLayerTest() {
            DatabaseMetaLayer dm = DatabaseMetaLayer.Instance;

            //GetApplicants
            List<Applicant> myApps = new List<Applicant>();
            Applicant app = new Applicant();
            app.ApplicantID = 0; app.ApplicantPosition = "Sales"; app.EmailAddress = "AWyke@gmail.com"; app.FirstName = "Alex"; app.LastName = "Wyke"; app.PhoneNumber = "07000000000";
            myApps.Add(app);
            List<Applicant> DBApps = dm.GetApplicants();
            Assert.AreEqual(myApps[0].FirstName, DBApps[0].FirstName);

            //GetEmployees
            List<Employee> myEmps = new List<Employee>();
            Employee emp = new Employee();
            emp.EmployeeID = 0; emp.EmployeePosition = "Sales"; emp.EmailAddress = "DCundy@outlook.com"; emp.FirstName = "David"; emp.LastName = "Cundy"; emp.PhoneNumber = "07000000001";
            myEmps.Add(emp);
            List<Employee> DBEmps = dm.GetEmployees();
            Assert.AreEqual(myEmps[0].FirstName, DBEmps[0].FirstName);

            //InsertPerson
            Applicant aip = new Applicant();
            aip.ApplicantID = 0; aip.ApplicantPosition = "Sales"; aip.EmailAddress = "NThurlow@outlook.com"; aip.FirstName = "Nathaniel"; aip.LastName = "Thurlow"; aip.PhoneNumber = "07000000002";
            bool test = dm.InsertPerson(aip, "Sales", false);
            Assert.AreEqual(true, test);

            test = dm.InsertPerson(null, "Sales", false);
            Assert.AreEqual(false, test);

            //UpdatePerson
            Applicant air = aip; air.EmailAddress = "HowdyHo@gmail.com";
            test = dm.UpdatePerson(aip, air);
            Assert.AreEqual(true, test);

            test = dm.UpdatePerson(null, null);
            Assert.AreEqual(false, test);

            //Delete Person
            test = dm.DeletePerson(air);
            Assert.AreEqual(true, test);

            test = dm.DeletePerson(null);
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void BankTest() {
            Bank bank = Bank.Instance;
            bank.LoadBank();
            FeedbackBank fb = Bank.Instance.Feedbacks;
            CategoryBank cb = Bank.Instance.Categories;
            ApplicantBank ab = Bank.Instance.Applicants;

            Assert.AreEqual(fb, bank.Feedbacks);
            Assert.AreEqual(cb, bank.Categories);
            Assert.AreEqual(ab, bank.Applicants);
        }
        [TestMethod]
        public void DebugLoggerTest() {
            Logger log = Logger.Instance;
            bool test = log.WriteLine("Testing Message from the Unit Test : " + DateTime.Now.ToLongTimeString());
            Assert.AreEqual(true, test);
        }
    }
}
