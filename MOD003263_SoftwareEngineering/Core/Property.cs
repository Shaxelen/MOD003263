using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class Property {
        private string _connectionString;
        private string _emailEmail;
        private string _emailPassword;
        private string _accBody;
        private string _rejBody;
        private string _accSubject;
        private string _rejSubject;
        private static Property _instance;

        private Property() {
            _connectionString = Properties.Settings.Default.ConnectionString;
        }

        private Property(string email, string password) : this() {
            _emailEmail = email;
            _emailPassword = password;
        }

        public static Property Instance(string email, string password) {
            if (null == _instance) {
                _instance = new Property(email, password);
            }
            return _instance;
        }

        public string ConnectionString {
            get { return _connectionString; }
        }

        public string AcceptedBody {
            get { return _accBody; }
            set { _accBody = value; }
        }

        public string RejectedBody {
            get { return _rejBody; }
            set { _rejBody = value; }
        }

        public string AcceptedSubject {
            get { return _accSubject; }
            set { _accSubject = value; }
        }

        public string RejectedSubject {
            get { return _rejSubject; }
            set { _rejSubject = value; }
        }

        public System.Net.NetworkCredential Credentials {
            get { return new System.Net.NetworkCredential(_emailEmail, _emailPassword); }
        }
    }
}