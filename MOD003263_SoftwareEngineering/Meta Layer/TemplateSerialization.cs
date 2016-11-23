using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using MOD003263_SoftwareEngineering.Core;

namespace MOD003263_SoftwareEngineering.Meta {
    public class TemplateSerialization {
        private const string _BankFile = "Templates.bin";

        public Bank LoadTemplateBank() {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(_BankFile, FileMode.Open, FileAccess.Read, FileShare.None);
            Bank bank = (Bank)formatter.Deserialize(stream);
            stream.Close();
            stream.Dispose();
            return bank;
        }

        public void SaveTemplateBank(Bank bank) {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(_BankFile, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, bank);
            stream.Close();
            stream.Dispose();
        }
    }
}
