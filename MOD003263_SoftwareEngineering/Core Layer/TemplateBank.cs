using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    public class TemplateBank {
        private static List<Template> _templateList = new List<Template>();
        private static TemplateBank _instance = null;

        /// <summary>
        /// Template bank constructor
        /// </summary>
        private TemplateBank() { }
        
        /// <summary>
        /// Singleton instance of Template Bank
        /// </summary>
        /// <returns></returns>
        public static TemplateBank Instance() {
            if (null == _instance) {
                _instance = new TemplateBank();
            }
            return _instance;
        }

        /// <summary>
        /// Add a template to the template bank
        /// </summary>
        /// <param name="templateName">The name of the template to add</param>
        /// <param name="template">The template to add</param>
        public void Add(string templateName, Template template) {
            // Add Template to bank
            template.TemplateName = templateName;
            _templateList.Add(template);
        }

        /// <summary>
        /// Load a template from the template bank
        /// </summary>
        /// <param name="templateName">The name of the template to load</param>
        /// <returns></returns>
        public Template Load(string templateName) {
            // Retrieve template from bank
            Template temp = null;

            for (int i = 0; i < _templateList.Count; i++) {
                if (_templateList[i].TemplateName == templateName) {
                    temp = _templateList[i];
                    return temp;
                }
            }
            return temp;
        }

        /// <summary>
        /// Delete a template from the template bank
        /// </summary>
        /// <param name="templateName">The name of the template to delete</param>
        public void Remove(string templateName) {
            // Delete template from bank
            Template temp = null;

            for (int i = 0; i < _templateList.Count; i++) {
                if (_templateList[i].TemplateName == templateName) {
                    temp = _templateList[i];
                    break;
                }
            }
            _templateList.Remove(temp);
        }

        /// <summary>
        /// Updates an existing template in the template bank
        /// </summary>
        /// <param name="templateName">The name of the template to update</param>
        /// <param name="template">The new template object to replace</param>
        public void Update(string templateName, Template template) {
            for (int i = 0; i < _templateList.Count; i++) {
                if (_templateList[i].TemplateName == templateName) {
                    _templateList[i] = template;
                    break;
                }
            }
        }

        /// <summary>
        /// Gets and sets the template list
        /// </summary>
        public List<Template> Templates {
            get { return _templateList; }
        }
    }
}
