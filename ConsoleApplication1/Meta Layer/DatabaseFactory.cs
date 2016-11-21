using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO;

namespace ConsoleApplication1 {
    public class DatabaseFactory {
        private static DatabaseConnection m_instance = null;

        Dictionary<string, string> m_properties;
        private static string propfile = "properties.dat";

        private DatabaseFactory() {
            m_properties = new Dictionary<string, string>();
        }
        public static DatabaseConnection instance() {
            if (null == m_instance) {
                DatabaseFactory factory = new DatabaseFactory();
                m_instance = factory.getConection();
            }
            return m_instance;
        }
        private DatabaseConnection getConection() {
            DatabaseConnection connection = null;

            try {
                m_properties = getProperties();
                string provider = m_properties["Provider"];
                if (provider.Equals("MySQL"))
                    connection = new MySQLCon(m_properties);
                else if (provider.Equals("Microsoft.ACE.OLEDB.15.0"))
                    connection = new OleDatabaseConnection(m_properties);
                else {
                    // should throw unsupport exception here
                    throw new DatabaseException("Not supported provider '" + provider + "'");
                }
            } catch (FileNotFoundException e) {
                Debug.WriteLine("Error file not found" + e.Message);
                connection = null;
                throw e;
            } catch (Exception e) {
                Debug.WriteLine("Property file parsing exception thrown : " + e.Message);
                connection = null;
                throw e;
            }
            return connection;
        }

        private Dictionary<string, string> getProperties() {
            string fileData = "";
            using (StreamReader sr = new StreamReader(propfile)) {
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
