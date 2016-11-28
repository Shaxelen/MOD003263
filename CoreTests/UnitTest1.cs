using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOD003263_SoftwareEngineering.Core;

namespace CoreTests {
    [TestClass]
    public class CoreTest {
        [TestMethod]
        public void TemplateTest() {
            Template t = new CVTemplate();
            t.TemplateName = "TestName";
            Assert.AreEqual("TestName", t.TemplateName);
            Assert.AreEqual("CV", t.TemplateType);
            t = new InterviewTemplate();
            Assert.AreEqual("Interview", t.TemplateType);
            t = new EmployeeTemplate();
            Assert.AreEqual("Employee", t.TemplateType);
        }

        [TestMethod]
        public void TemplateBankTest() {
            Template t = new CVTemplate();
            Template i = new InterviewTemplate();

            // Add
            TemplateBank tBank = TemplateBank.Instance();
            tBank.Add("Interview Template", i);
            tBank.Add("CV Template", t);

            Assert.AreEqual(t, tBank.Load("CV Template"));
            Assert.AreNotEqual(t, tBank.Load("blablabla"));

            // Update
            Template s = new CVTemplate();
            s.TemplateName = "New CV Template";
            tBank.Update("CV Template", s);
            t = tBank.Load("New CV Template");
            Assert.AreEqual(s, t);

            // Load
            Template loadT = tBank.Load("New CV Template");
            Assert.AreEqual(t, loadT);

            // Remove
            tBank.Remove("New CV Template");
            Assert.AreEqual(null, tBank.Load("New CV Template"));

            // Templates
            TemplateBank anotherBank = TemplateBank.Instance();
            Assert.AreSame(tBank, anotherBank);
            Assert.AreSame(tBank.Templates, anotherBank.Templates);
        }
    }
}
