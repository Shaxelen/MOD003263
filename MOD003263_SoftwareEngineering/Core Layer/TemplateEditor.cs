using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD003263_SoftwareEngineering.Core;

namespace MOD003263_SoftwareEngineering.Core {
    class TemplateEditor {
        private TemplateFactory templateFactory;

        /// <summary>
        /// Template editor contructor
        /// </summary>
        /// <param name="templateFactory">The template factory to access</param>
        public TemplateEditor(TemplateFactory templateFactory) {
            this.templateFactory = templateFactory;
        }
        /// <summary>
        /// Request a template to create
        /// </summary>
        /// <param name="templateType">The template type to create</param>
        /// <returns></returns>
        public Template RequestTemplate(string templateType) {
            Template template = templateFactory.CreateTemplate(templateType);
            return template; 
        }
    }
}
