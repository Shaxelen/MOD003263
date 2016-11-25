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

        public Feedback(string title, Person person) {
            _title = title;
            _person = person;
        }

        public Template LoadTemplate(Template template) {
            return _template = template;
        }

        public string SetFileName {
            set { _fileLocation = value; }
        }

        public string GetTitle {
            get { return _title; }
        }
    }
}
