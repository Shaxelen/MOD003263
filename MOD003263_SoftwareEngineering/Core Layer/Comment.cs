using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class Comment : Component {
        private string _comment;

        /// <summary>
        /// Comments Constructor
        /// </summary>
        public Comment() { }

        /// <summary>
        /// Get and set the comment
        /// </summary>
        public string Comments {
            get { return _comment; }
            set { _comment = value; }
        }
    }
}
