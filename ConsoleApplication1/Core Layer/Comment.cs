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
            set { _comment = value; }
        }

        // Not used
        public override void Add(Component component) {
            throw new NotImplementedException();
        }

        // Not used
        public override void Remove(Component component) {
            throw new NotImplementedException();
        }

        // Not used
        public override void RemoveAt(int index) {
            throw new NotImplementedException();
        }

        // Not used
        public override Component GetChild(int index) {
            throw new NotImplementedException();
        }
        
    }
}
