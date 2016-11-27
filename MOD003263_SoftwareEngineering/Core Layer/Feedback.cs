using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class Feedback {
        private string _title;
        private string _fileLocation;
        private Template _template;
        private Person _person;

        /// <summary>
        /// Feedback Constructor
        /// </summary>
        /// <param name="title">The title of the feedback</param>
        /// <param name="person">The person to add to the feedback</param>
        public Feedback(string title, Person person) {
            _title = title;
            _person = person;
        }

        /// <summary>
        /// Load a template to use
        /// </summary>
        /// <param name="template">The selected template to load</param>
        /// <returns></returns>
        public Template LoadTemplate(Template template) {
            return _template = template;
        }

        /// <summary>
        /// Sets the location of the file
        /// </summary>
        public string SetFileName {
            set { _fileLocation = value; }
        }

        /// <summary>
        /// Returns the title of the feedback
        /// </summary>
        public string GetTitle {
            get { return _title; }
        }
    }
}
