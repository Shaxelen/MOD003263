using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class Title : Component {
        private string _title;

        /// <summary>
        /// Title Constructor
        /// </summary>
        /// <param name="title">The title of the Title</param>
        public Title(string title) {
            _title = title;
        }

        /// <summary>
        /// Returns the title
        /// </summary>
        public string QTitle {
            get { return _title; }
        }
    }
}
