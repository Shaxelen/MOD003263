using System.IO;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using MOD003263_SoftwareEngineering.Core;
using MOD003263_SoftwareEngineering.Debug;

namespace MOD003263_SoftwareEngineering.Meta {
    public class TemplateSerialization {
        private const string _BankFile = "Templates.bin";
        Logger _logger = Logger.Instance();

        public Bank LoadTemplateBank() {
            Bank bank = null;
            try {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(_BankFile, FileMode.Open, FileAccess.Read, FileShare.None);
                bank = (Bank)formatter.Deserialize(stream);
                stream.Close();
                stream.Dispose();
            } catch (Exception e) {
                _logger.WriteLine(e.Message);
            }
            return bank;
        }

        public bool SaveTemplateBank(Bank bank) {
            try {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(_BankFile, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, bank);
                stream.Close();
                stream.Dispose();
                return true;
            } catch (Exception e) {
                _logger.WriteLine(e.Message);
            }
            return false;
        }
    }
}
