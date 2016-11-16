using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class TemplateBank {
        private Dictionary<string, Template> _templateDict = new Dictionary<string, Template>();

        /// <summary>
        /// Template bank constructor
        /// </summary>
        public TemplateBank() {

        }
        /// <summary>
        /// Add a template to the template bank
        /// </summary>
        /// <param name="templateName">The name of the template to add</param>
        /// <param name="template">The template to add</param>
        public void Add(string templateName, Template template) {
            // Add Template to bank
            _templateDict.Add(templateName, template);
        }
        /// <summary>
        /// Load a template from the template bank
        /// </summary>
        /// <param name="templateName">The name of the template to load</param>
        /// <returns></returns>
        public Template Load(string templateName) {
            // Retrieve template from bank
            Template temp = null;
            if (_templateDict.ContainsKey(templateName)) {
                return temp = _templateDict[templateName];
            }
            return temp;
        }
        /// <summary>
        /// Delete a template from the template bank
        /// </summary>
        /// <param name="templateName">The name of the template to delete</param>
        public void Remove(string templateName) {
            // Delete template from bank
            _templateDict.Remove(templateName);
        }
    }
}
