using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class Feedback {
        private TemplateBank _templateBank = TemplateBank.Instance();
        private Template _template;
        private Header _header;
        private Person _person;

        public Feedback() {
            _header = new Header();
            _header.Person = _person;
            _template.Add(_header);
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
