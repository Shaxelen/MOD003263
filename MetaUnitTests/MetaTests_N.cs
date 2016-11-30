using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOD003263_SoftwareEngineering.Meta;
using MOD003263_SoftwareEngineering.Debug;
using MOD003263_SoftwareEngineering.Core;

namespace MetaUnitTests {
    [TestClass]
    public class MetaUnitTest {
        [TestMethod]
        public void TemplateSerializationTest() {

        }
        [TestMethod]
        public void PDFConvertTest() {

        }
        [TestMethod]
        public void OleDbConnectionTest() {

        }
        [TestMethod]
        public void DatabaseMetaLayerTest() {

        }
        [TestMethod]
        public void DatabaseFactoryTest() {

        }
        [TestMethod]
        public void BankTest() {
            Bank bank = Bank.Instance();
            FeedbackBank fb = FeedbackBank.Instance();
            TemplateBank tb = TemplateBank.Instance();

            Assert.AreEqual(fb, bank.Feedbacks);
            Assert.AreEqual(tb, bank.Templates);
        }
        [TestMethod]
        public void DebugLoggerTest() {

        }
    }
}
