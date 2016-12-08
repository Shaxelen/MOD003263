using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class TemplateBank {
        private static List<Template> _templateList = new List<Template>();
        private static TemplateBank _instance = null;
        /// <summary>
        /// Template bank constructor
        /// </summary>
        private TemplateBank() { }
        
        public static TemplateBank getInstance() {
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
            foreach (Template t in _templateList) {
                if (t.TemplateName == templateName) {
                    return t;
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
            foreach (Template t in _templateList) {
                if (t.TemplateName == templateName) {
                    temp = t;
                }
            }
            _templateList.Remove(temp);
        }

        public List<Template> Templates {
            get { return _templateList; }
            set { _templateList = value; }
        }
    }
}
