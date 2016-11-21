using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ConsoleApplication1.Core;

namespace ConsoleApplication1.Meta {
    public class TemplateSerialization {
        private const string _BankFile = "Templates.bin";

        public TemplateBank LoadTemplateBank() {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(_BankFile, FileMode.Open, FileAccess.Read, FileShare.None);
            TemplateBank tb = (TemplateBank)formatter.Deserialize(stream);
            stream.Close();
            stream.Dispose();
            return tb;
        }

        public void SaveTemplateBank(TemplateBank tb) {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(_BankFile, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, tb);
            stream.Close();
            stream.Dispose();
        }
    }
}
