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
    }
}
