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
        public void EmailTest() {
            EmailHandler eh = new EmailHandler("email", "password");
            bool test = eh.SendEmail("to", "from", "subject", "body", "", new System.Net.NetworkCredential("email", "password"));
            // Is supposed to come back false as "email" and "password" do not exist as email authentication.
            Assert.AreEqual(false, test);
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
            Logger log = Logger.getInstance();
            bool test = log.WriteLine("Testing Message from the Unit Test : " + DateTime.Now.ToLongTimeString());
            Assert.AreEqual(true, test);
        }
    }
}
