using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Meta_Layer {
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
        public List<Applicant> getApplicants() {
            List<Applicant> apps = new List<Applicant>();

            DatabaseConnection con = DatabaseFactory.Instance();
            if (con.OpenConnection()) {
                DbDataReader dr = con.Select("SELECT ID, cust_name, cust_address, cust_city FROM customers;");

                //Read the data and store them in the list
                while (dr.Read()) {
                    Applicant app = new Applicant();
                    app.Name = dr.GetString(1);

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
