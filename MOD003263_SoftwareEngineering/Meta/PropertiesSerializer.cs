using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using MOD003263_SoftwareEngineering.Debug;
using MOD003263_SoftwareEngineering.Core;

namespace MOD003263_SoftwareEngineering.Meta {
    public class PropertiesSerializer : IMetaSerializer<Property> {
        private const string _propertyFile = "properties.bin";
        Logger _logger = Logger.Instance;

        public Property Load() {
            Property prop = null;
            try {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(_propertyFile, FileMode.Open, FileAccess.Read, FileShare.None);
                prop = (Property)formatter.Deserialize(stream);
                stream.Close();
                stream.Dispose();
            } catch (Exception e) {
                _logger.WriteLine(e.Message);
            }
            return prop;
        }

        public bool Save(Property prop) {
            try {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(_propertyFile, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, prop);
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
