using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    public class Question : ComponentManager {
        private int _questionID;

        /// <summary>
        /// Question Constructor
        /// </summary>
        public Question () { }

        public int ID {
            get { return _questionID; }
            set { _questionID = value; }
        }
    }
}
