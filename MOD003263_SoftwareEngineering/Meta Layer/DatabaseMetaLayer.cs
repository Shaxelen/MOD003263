using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD003263_SoftwareEngineering.Core;

namespace MOD003263_SoftwareEngineering.Meta {
    public class DatabaseMetaLayer {
        static private DatabaseMetaLayer m_instance = null;

        private DatabaseMetaLayer() { }

        static public DatabaseMetaLayer instance() {
            if (null == m_instance) {
                m_instance = new DatabaseMetaLayer();
            }
            return m_instance;
        }

        // Could just have a set of static helper methods rather than a singleton!
        public List<Applicant> GetApplicants() {
            List<Applicant> apps = new List<Applicant>();

            DatabaseConnection con = DatabaseFactory.Instance();
            if (con.OpenConnection()) {
                DbDataReader dr = con.Select("SELECT ID, cust_name, cust_address, cust_city FROM customers;");

                //Read the data and store them in the list
                while (dr.Read()) {
                    Applicant app = new Applicant();
                    app.FirstName = dr.GetString(1);
                    app.LastName = dr.GetString(2);

                    apps.Add(app);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return apps;
        }
    }
}
