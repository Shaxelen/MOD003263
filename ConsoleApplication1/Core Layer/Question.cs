using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
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
