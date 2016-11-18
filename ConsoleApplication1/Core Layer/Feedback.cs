using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class Feedback {
        private TemplateBank _templateBank = TemplateBank.Instance();
        private Template _template;

        public Feedback() { }

        public  void ProduceFeedback(Template _template) {

        }

        public Template LoadTemplate(string templateName) {
            _template = _templateBank.Load(templateName);
            return _template;
        }

        /// <summary>
        /// Adds a Person to the template 
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson(Person person) {
            _template.AddPerson(person);
        }
    }
}
