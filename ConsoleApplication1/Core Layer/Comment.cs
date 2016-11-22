using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
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
            set { _comment = value;
                if (_comment == null) {
                    _comment = "Enter Comment";
                } else {
                    _comment = value;
                }
            }
        }      
    }
}
