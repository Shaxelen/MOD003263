using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    public class Feedback {
        private TemplateBank _templateBank = TemplateBank.Instance();
        private Template _template;
        private Person _person;

        public Feedback(Person person) {
            _person = person;
        }

        public Template LoadTemplate(string templateName) {
            return _template = _templateBank.Load(templateName);
        }

        public void LoadPerson() {
            // Fake data to help with code
            _person = new Applicant();
            _person.FirstName = "Bill";
            _person.LastName = "Ben";
        }
    }
}
