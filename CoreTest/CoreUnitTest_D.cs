using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOD003263_SoftwareEngineering.Core;

namespace CoreTests {
    [TestClass]
    public class CoreTest {
        [TestMethod]
        public void QuestionTest() {
            Question question = new Question();
            question.Title = "Hello";
            question.PickedFeedback = "";
            question.Score = 1;

            Assert.AreEqual("Hello", question.Title);
            Assert.AreEqual("", question.PickedFeedback);
            Assert.AreEqual(1, question.Score);

            question.Score = -1;
            Assert.AreEqual(1, question.Score);

            question.Score = 6;
            Assert.AreEqual(5, question.Score);

            question.ID = 1;
            Assert.AreEqual(1, question.ID);

            string[] set = question.FeedbackList;
            Assert.AreEqual(question.FeedbackList, set);

            question.pickFeedback(3);
            Assert.AreEqual(question.PickedFeedback, question.FeedbackList[3]);
        }

        [TestMethod]
        public void FeedbackTest() {
            Person employee = new Employee();
            employee.FirstName = "Bill";

            Person applicant = new Applicant();
            applicant.FirstName = "Ben";

            Feedback feedback1 = new Feedback("Feedback 1", employee);
            Feedback feedback2 = new Feedback("Feedback 2", applicant);

            Assert.AreNotEqual(feedback1, feedback2);
            feedback1.SetFileName = "File";
            Assert.AreEqual("File", feedback1.SetFileName = "File");

            List<Question> questions = new List<Question>();

            Question question = new Question();
            question.ID = 0;
            question.Title = "TestQuestion";
            feedback1.AddQuestion(question);
            questions.Add(question);
            question.Title = "TestQuestion2";
            feedback2.AddQuestion(question);
            questions.Add(question);

            feedback1.EditQuestion(0, feedback1.FindQuestion(0));
            Assert.AreEqual(question, feedback2.FindQuestion("TestQuestion2"));

            feedback2.Questions = questions;

            Assert.AreEqual("Feedback 1", feedback1.Title);
            Assert.AreNotEqual("Feedback 2", feedback1.Title);
        }

        [TestMethod]
        public void FeedbackBankTest() {
            Person e = new Employee();
            e.FirstName = "Bill";

            Person a = new Applicant();
            a.FirstName = "Ben";

            Feedback f1 = new Feedback("F1", e);
            Feedback f2 = new Feedback("F2", a);

            FeedbackBank fBank = Bank.Instance.Feedbacks;
            fBank.Add(f1);
            fBank.Add(f2);

            Assert.AreSame(f1, fBank.FindFeedback("F1"));
            Assert.AreNotSame(f1, fBank.FindFeedback("F2"));

            fBank.Update("F1", f2);
            fBank.Remove("F1");

            FeedbackBank anotherBank = Bank.Instance.Feedbacks;
            Assert.AreSame(fBank, anotherBank);
            Assert.AreSame(fBank.FeedbackList, anotherBank.FeedbackList);
        }

        [TestMethod]
        public void FeedbackFilterTest() {
            Person e = new Employee();
            e.FirstName = "Bill";

            Person a = new Employee();
            a.FirstName = "Ben";

            Feedback f1 = new Feedback("f1", e);
            Feedback f2 = new Feedback("f2", a);

            FeedbackFilter fFilter = new FeedbackFilter();

            fFilter.Accept(f1);
            fFilter.Reject(f2);

            Assert.AreNotSame(fFilter.AcceptList, fFilter.RejectList);
        }
        [TestMethod]
        private void CategoryTest() {
            Category c = new Category("C1");
            Assert.AreEqual("C1", c.Title);
            Assert.AreEqual(new List<Question>(), c.Questions);

            Question q1 = new Question();
            q1.ID = 0;
            q1.Title = "Hello";
            c.Add(q1);

            Assert.AreNotEqual(new List<Question>(), c.Questions);

            Assert.AreEqual("Hello", c.Find(0));

            Question q2 = c.Find(0);
            q2.Title = "Nope";
            q2.ID = 1;
            c.Delete(0);

            Assert.AreEqual(new List<Question>(), c.Questions);
            
            c.Add(q1);
            c.Add(q2);

            Assert.AreEqual("Nope", c.Find(1));
        }
        [TestMethod]
        private void CategoryBankTest() {
            CategoryBank cb = new CategoryBank();
            Category c = new Category("C1");
            Category d = new Category("C2");
            Question q1 = new Question();

            q1.ID = 0;
            q1.Title = "Hello";
            c.Add(q1);
            cb.Add(c);

            Assert.AreEqual(c, cb.FindCategory("C1"));

            cb.Update("C1", d);
            cb.Remove("C2");

            List<Category> cats = cb.Categories;

            Assert.AreEqual(cats, cb.Categories);
        }
        [TestMethod]
        private void PropertyTest() {
            Property p = Property.Instance("abc@def.ghi", "password");
            Assert.AreEqual(Property.CurrentInstance, p);
            Assert.AreEqual("abc@def.ghi", p.Credentials.UserName);
            Assert.AreEqual("password", p.Credentials.Password);

            p.AcceptedBody = "Test1";
            p.AcceptedSubject = "Test2";
            p.RejectedBody = "Test3";
            p.RejectedSubject = "Test4";
            
            Assert.AreEqual("Test1", p.AcceptedBody);
            Assert.AreEqual("Test2", p.AcceptedSubject);
            Assert.AreEqual("Test3", p.RejectedBody);
            Assert.AreEqual("Test4", p.RejectedSubject);
        }
        [TestMethod]
        private void ApplicantBankTest() {
            Applicant a = new Applicant();
            a.FirstName = "Test";
            a.LastName = "Name";
            a.ApplicantID = 0;

            Applicant b = a;
            b.LastName = "Neam";

            ApplicantBank ab = new ApplicantBank();
            ab.Add(a);
            Assert.AreEqual(a, ab.FindApplicant(0));
            Assert.AreEqual(a.FullName, ab.FindApplicant(a.FullName));
            ab.Update(0, b);
            Assert.AreNotEqual(a, ab.FindApplicant(0));
            ab.Remove(0);

            List<Applicant> apps = ab.Applicants;
            apps.Clear();
            ab.Applicants = apps;

            Assert.AreEqual(new List<Applicant>(), ab.Applicants);
        }
    }
}
