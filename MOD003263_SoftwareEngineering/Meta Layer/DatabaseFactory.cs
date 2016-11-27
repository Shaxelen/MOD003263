using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Data.Common;
using MOD003263_SoftwareEngineering.Debug;

namespace MOD003263_SoftwareEngineering.Meta {
    public class DatabaseFactory {
        private static DatabaseConnection _instance = null;
        private Logger logger = Logger.getInstance();
        private Dictionary<string, string> _properties;
        private static string _propfile = "properties.dat";

        private DatabaseFactory() {
            _properties = new Dictionary<string, string>();
        }

        public static DatabaseConnection Instance() {
            if (null == _instance) {
                DatabaseFactory factory = new DatabaseFactory();
                _instance = factory.getConection();
            }
            return _instance;
        }

        private DatabaseConnection getConection() {
            DatabaseConnection connection = null;

            try {
                _properties = getProperties();
                string provider = _properties["Provider"];
                if (provider.Equals("MySQL"))
                    connection = new MySQLCon(_properties);
                else if (provider.Equals("Microsoft.ACE.OLEDB.15.0"))
                    connection = new OleDatabaseConnection(_properties);
                else {
                    // should throw unsupport exception here
                    throw new DatabaseException("Not supported provider '" + provider + "'");
                }
            } catch (FileNotFoundException e) {
                logger.WriteLine("Error file not found" + e.Message);
                connection = null;
                throw e;
            } catch (Exception e) {
                logger.WriteLine("Property file parsing exception thrown : " + e.Message);
                connection = null;
                throw e;
            }
            return connection;
        }

        private Dictionary<string, string> getProperties() {
            string fileData = "";
            using (StreamReader sr = new StreamReader(_propfile)) {
                fileData = sr.ReadToEnd().Replace("\r", "");
            }
            Dictionary<string, string> properties = new Dictionary<string, string>();
            string[] kvp;
            string[] records = fileData.Split("\n".ToCharArray());
            foreach (string record in records) {
                kvp = record.Split("=".ToCharArray());
                properties.Add(kvp[0], kvp[1]);
            }
            return properties;
        }
    }
    public class DatabaseException : System.Exception {
        public DatabaseException(string message) : base(message) { }
    }
    public interface DatabaseConnection {
        bool OpenConnection();

        bool CloseConnection();

        //Insert statement
        void Insert();

        //Update statement
        void Update();

        //Delete statement
        void Delete();

        //Select statement
        DbDataReader Select(String query);

        DataSet getDataSet(string sqlStatement);
    }
}
