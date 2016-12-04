using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOD003263_SoftwareEngineering.Core;

namespace CoreTests {
    [TestClass]
    public class CoreTest {
        [TestMethod]
        public void TemplateTest() {
            Template template = new CVTemplate();
            template.TemplateName = "TestName";

            Assert.AreEqual("TestName", template.TemplateName);
            Assert.AreEqual("CV", template.TemplateType);

            template = new InterviewTemplate();
            Assert.AreEqual("Interview", template.TemplateType);

            template = new EmployeeTemplate();
            Assert.AreEqual("Employee", template.TemplateType);

            Template template1 = new CVTemplate();
            Template template2 = new CVTemplate();

            Question question = new Question();
            question.Title = "Hello";
            question.Comment = "";
            question.Score = 1;

            Question question2 = new Question();
            question2.Title = "Hello";

            template1.AddQuestion(question);
            template2.AddQuestion(question);
            template2.AddQuestion(question2);
            Assert.AreNotEqual(template1, template2);

            template2.RemoveQuestion(question2.ID);
            Assert.AreNotEqual(template1, template2);

            Question testQuestion = template2.GetQuestion(2);
            Assert.AreEqual(null, testQuestion);
        }

        [TestMethod]
        public void TemplateFactoryTest() {
            TemplateFactory tFactory = new TemplateFactory();

            Template tCV = tFactory.CreateTemplate("CV");
            Template tIw = tFactory.CreateTemplate("Interview");
            Template tEe = tFactory.CreateTemplate("Employee");

            Assert.AreNotSame(tCV, tIw);
            Assert.AreEqual("CV", tCV.TemplateType);
            Template tNull = tFactory.CreateTemplate("Bla");

            Assert.AreEqual(null, tNull);
        }

        [TestMethod]
        public void TemplateEditor() {
            TemplateFactory tFactory = new TemplateFactory();
            TemplateEditor tEditor = new TemplateEditor(tFactory);

            Template tCV = tEditor.RequestTemplate("CV");
            Template tIw = tEditor.RequestTemplate("Interview");
            Template tEe = tEditor.RequestTemplate("Employee");

            Assert.AreNotSame(tCV, tIw);
            Assert.AreEqual("CV", tCV.TemplateType);
            Template tNull = tEditor.RequestTemplate("Bla");

            Assert.AreEqual(null, tNull);
        }

        [TestMethod]
        public void TemplateBankTest() {
            Template cv = new CVTemplate();
            Template inter = new InterviewTemplate();

            // Add
            TemplateBank tBank = TemplateBank.Instance();
            tBank.Add("Interview Template", inter);
            tBank.Add("CV Template", cv);

            Assert.AreEqual(cv, tBank.Load("CV Template"));
            Assert.AreNotEqual(cv, tBank.Load("blablabla"));

            // Update
            Template s = new CVTemplate();
            s.TemplateName = "New CV Template";
            tBank.Update("CV Template", s);
            cv = tBank.Load("New CV Template");
            Assert.AreEqual(s, cv);

            // Load
            Template loadT = tBank.Load("New CV Template");
            Assert.AreEqual(cv, loadT);

            // Remove
            tBank.Remove("New CV Template");
            Assert.AreEqual(null, tBank.Load("New CV Template"));

            // Templates
            TemplateBank anotherBank = TemplateBank.Instance();
            Assert.AreSame(tBank, anotherBank);
            Assert.AreSame(tBank.Templates, anotherBank.Templates);
        }
        [TestMethod]
        public void QuestionTest() {
            Question question = new Question();
            question.Title = "Hello";
            question.Comment = "";
            question.Score = 1;

            Assert.AreEqual("Hello", question.Title);
            Assert.AreEqual("", question.Comment);
            Assert.AreEqual(1, question.Score);

            question.Score = -1;
            Assert.AreEqual(1, question.Score);

            question.Score = 6;
            Assert.AreEqual(5, question.Score);

            question.ID = 1;
            Assert.AreEqual(1, question.ID);
        }

        [TestMethod]
        public void QuestionCreatorTest() {
            QuestionCreator qCreator = QuestionCreator.Instance();
            QuestionCreator qCreator2 = QuestionCreator.Instance();

            ReferenceEquals(qCreator, qCreator2);

            Question q1 = qCreator.CreateQuestion(1, "Question 1", "", 0);
            Question q2 = qCreator.CreateQuestion(2, "Question 2", "", 0);

            Assert.AreNotSame(q2, q1);
        }

        [TestMethod]
        public void FeedbackTest() {
            Person employee = new Employee();
            employee.FirstName = "Bill";

            Person applicant = new Applicant();
            applicant.FirstName = "Ben";

            Template t = new CVTemplate();

            Feedback feedback1 = new Feedback("Feedback 1", employee);
            Feedback feedback2 = new Feedback("Feedback 2", applicant);

            feedback1.LoadTemplate(t);
            feedback2.LoadTemplate(t);

            Assert.AreNotEqual(feedback1, feedback2);
            feedback1.SetFileName = "File";
            Assert.AreEqual("File", feedback1.SetFileName = "File");

            Assert.AreEqual("Feedback 1", feedback1.GetTitle);
            Assert.AreNotEqual("Feedback 2", feedback1.GetTitle);
        }

        [TestMethod]
        public void FeedbackBankTest() {
            Person e = new Employee();
            e.FirstName = "Bill";

            Person a = new Applicant();
            a.FirstName = "Ben";

            Feedback f1 = new Feedback("F1", e);
            Feedback f2 = new Feedback("F2", a);

            FeedbackBank fBank = FeedbackBank.Instance();
            fBank.Add(f1);
            fBank.Add(f2);

            Assert.AreSame(f1, fBank.FindFeedback("F1"));
            Assert.AreNotSame(f1, fBank.FindFeedback("F2"));

            FeedbackBank anotherBank = FeedbackBank.Instance();
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
