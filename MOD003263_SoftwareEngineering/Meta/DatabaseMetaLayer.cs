using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD003263_SoftwareEngineering.Core;
using MOD003263_SoftwareEngineering.Debug;

namespace MOD003263_SoftwareEngineering.Meta {
    public class DatabaseMetaLayer {
        static private DatabaseMetaLayer m_instance = null;
        private OleDbConnection _connection = new OleDbConnection();
        private Logger _logger = Logger.Instance;
        private Property _property = Property.Instance;

        private DatabaseMetaLayer() {
            _connection.ConnectionString = _property.ConnectionString;
        }

        static public DatabaseMetaLayer Instance() {
            if (null == m_instance) {
                m_instance = new DatabaseMetaLayer();
            }
            return m_instance;
        }

        public List<Employee> GetEmployees() {
            List<Employee> employees = new List<Employee>();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Person WHERE PersonIsEmployee=true", _connection);
            _connection.Open();
            if (_connection.State == ConnectionState.Open) {
                try {
                    DataTable table = new DataTable();
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    short empp = 0;
                    foreach (DataRow r in table.Rows) {
                        Employee emp = (Employee)buildPerson(r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[6].ToString(), empp, true);
                        employees.Add(emp);
                        empp++;
                    }
                    _connection.Close();
                    table.Dispose();
                    adapter.Dispose();
                    return employees;
                } catch (OleDbException oleDb) {
                    _logger.WriteLine(oleDb.Message);
                }
            } else {
                _logger.WriteLine("Connection Failed!");
            }
            _connection.Close();
            return employees;
        }

        public List<Applicant> GetApplicants() {
            List<Applicant> applicants = new List<Applicant>();
            try {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Person WHERE PersonIsEmployee=false", _connection);
                _connection.Open();
                if (_connection.State == ConnectionState.Open) {
                    try {
                        DataTable table = new DataTable();
                        OleDbDataAdapter adapter = new OleDbDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                        short appp = 0;
                        foreach (DataRow r in table.Rows) {
                            Applicant app = (Applicant)buildPerson(r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), r[6].ToString(), appp, false);
                            applicants.Add(app);
                            appp++;
                        }
                        _connection.Close();
                        table.Dispose();
                        adapter.Dispose();
                        return applicants;
                    } catch (OleDbException oleDb) {
                        _logger.WriteLine(oleDb.Message);
                    }
                } else {
                    _logger.WriteLine("Connection Failed!");
                }
                _connection.Close();
            } catch (Exception e) {
                _logger.WriteLine(e.Message);
            }
            return applicants;
        }

        private Person buildPerson(string fName, string lName, string email, string phone, string position, short number, bool isEmployee) {
            if (isEmployee) {
                Employee emp = new Employee();
                emp.EmployeeID = number;
                emp.FirstName = fName;
                emp.LastName = lName;
                emp.EmailAddress = email;
                emp.PhoneNumber = phone;
                emp.EmployeePosition = position;
                return emp;
            }
            else {
                Applicant app = new Applicant();
                app.ApplicantID = number;
                app.FirstName = fName;
                app.LastName = lName;
                app.EmailAddress = email;
                app.PhoneNumber = phone;
                app.ApplicantPosition = position;
                return app;
            }
        }

        /// <summary>
        /// Inserts A Person into the Database
        /// </summary>
        /// <param name="p">The Person to Insert</param>
        /// <param name="position">The Position the Person holds/is going for</param>
        /// <param name="isEmployee">If True, then they are an Employee, else they are an Applicant</param>
        /// <returns>Returns True if Insert was Successful, Returns False if Insert was not Successful</returns>
        public bool InsertPerson(Person p, string position, bool isEmployee) {
            try {
                OleDbCommand cmd = new OleDbCommand("INSERT INTO Person (PersonFirstName, PersonLastName, PersonEmailAddress, PersonPhoneNumber, PersonIsEmployee, PersonPosition)" +
                    " VALUES ('" + p.FirstName + "', '" + p.LastName + "', '" + p.EmailAddress + "', '" + p.PhoneNumber + "', " + isEmployee + ", '" + position + "');", _connection);
                _connection.Open();
                if (_connection.State == ConnectionState.Open) {
                    try {
                        cmd.ExecuteNonQuery();
                        _logger.WriteLine("Inserted Person Data into Database");
                        _connection.Close();
                        return true;
                    } catch (Exception e) {
                        _logger.WriteLine(e.Message);
                        _connection.Close();
                        return false;
                    }
                } else {
                    _logger.WriteLine("Connection Failed!");
                }
            } catch (Exception e) {
                _logger.WriteLine(e.Message);
            }
            _connection.Close();
            return false;
        }

        public bool UpdatePerson(Person old, Person knew) {
            try {
                OleDbCommand cmd = new OleDbCommand("UPDATE Person SET Person.PersonFirstName='" + knew.FirstName +
                    "', Person.PersonLastName='" + knew.LastName + "', Person.PersonEmailAddress='" + knew.EmailAddress +
                    "', Person.PersonPhoneNumber='" + knew.PhoneNumber + "' WHERE Person.PersonFirstName='" + old.FirstName +
                    "' AND Person.PersonLastName='" + old.LastName + "';", _connection);
                _connection.Open();
                if (_connection.State == ConnectionState.Open) {
                    try {
                        cmd.ExecuteNonQuery();
                        _logger.WriteLine("Updated Person Data in Database");
                        _connection.Close();
                        return true;
                    } catch (Exception e) {
                        _logger.WriteLine(e.Message);
                        _connection.Close();
                        return false;
                    }
                } else {
                    _logger.WriteLine("Connection Failed!");
                }
            } catch (Exception e) {
                _logger.WriteLine(e.Message);
            }
            _connection.Close();
            return false;
        }

        public bool DeletePerson(Person toDelete) {
            try { 
                OleDbCommand cmd = new OleDbCommand("DELETE FROM Person WHERE PersonFirstName='" + toDelete.FirstName + 
                    "' AND PersonLastName='" + toDelete.LastName + "' AND PersonEmailAddress='" + toDelete.EmailAddress + 
                    "' AND PersonPhoneNumber='" + toDelete.PhoneNumber + "';", _connection);
                _connection.Open();
                if (_connection.State == ConnectionState.Open) {
                    try {
                        cmd.ExecuteNonQuery();
                        _logger.WriteLine("Deleted Person Data from Database");
                        _connection.Close();
                        return true;
                    } catch (Exception e) {
                        _logger.WriteLine(e.Message);
                        _connection.Close();
                        return false;
                    }
                } else {
                    _logger.WriteLine("Connection Failed!");
                }
            } catch (Exception e) {
                _logger.WriteLine(e.Message);
            }
            _connection.Close();
            return false;
        }
    }
}
