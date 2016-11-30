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
            Title title = new Title("Hello");
            Comment comment = new Comment();
            Score score = new Score();

            question.Add(title);
            question.Add(comment);
            question.Add(score);

            Question question2 = new Question();
            Title title2 = new Title("Hello");

            question2.Add(title2);

            template1.Add(question);
            template2.Add(question);
            template2.Add(question2);
            Assert.AreNotEqual(template1, template2);

            template2.Remove(question2);
            Assert.AreNotEqual(template1, template2);
            Assert.AreEqual(null, template2.GetComponent(question2));
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
        public void TitleTest() {
            Title title = new Title("Hello");
            Assert.AreEqual("Hello", title.QTitle);
        }

        [TestMethod]
        public void CommentTest() {
            Comment comment = new Comment();
            comment.Comments = "Comment";

            Assert.AreEqual("Comment", comment.Comments);
        }

        [TestMethod]
        public void ScoreTest() {
            Score score = new Score();
            score.QScore = 6;

            Assert.AreEqual(5, score.QScore);

            score.QScore = 0;
            Assert.AreEqual(1, score.QScore);

            score.QScore = 3;
            Assert.AreEqual(3, score.QScore);
        }

        [TestMethod]
        public void QuestionTest() {
            Question question = new Question();
            Title title = new Title("Hello");
            Comment comment = new Comment();
            Score score = new Score();

            question.Add(title);
            question.Add(comment);
            question.Add(score);

            Assert.AreEqual(title, question.GetComponent(title));
            Assert.AreEqual(comment, question.GetComponent(comment));
            Assert.AreEqual(score, question.GetComponent(score));

            question.Remove(score);
            Assert.AreEqual(null, question.GetComponent(score));

            List<Component> compList = question.AttachedComponents;
            Assert.AreSame(compList, question.AttachedComponents);

            question.ID = 1;
            Assert.AreEqual(1, question.ID);
        }

        [TestMethod]
        public void QuestionCreatorTest() {
            QuestionCreator qCreator = QuestionCreator.Instance();
            QuestionCreator qCreator2 = QuestionCreator.Instance();

            ReferenceEquals(qCreator, qCreator2);

            Question q1 = qCreator.CreateQuestion(1, "Question 1");
            Question q2 = qCreator.CreateQuestion(2, "Question 2");

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
