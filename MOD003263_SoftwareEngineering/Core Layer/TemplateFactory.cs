using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD003263_SoftwareEngineering.Core;

namespace MOD003263_SoftwareEngineering.Core {
    public class TemplateFactory {
        /// <summary>
        /// Create a template
        /// </summary>
        /// <param name="templateType">The template type to create</param>
        /// <returns>The type of template to create</returns>
        public Template CreateTemplate(string templateType) {
            Template template = null;
            templateType = templateType.ToLower();
            if (templateType == "cv") {
                return new CVTemplate();
            }
            else if (templateType == "interview") {
                return new InterviewTemplate();
            }
            else if (templateType == "employee") {
                return new EmployeeTemplate();
            }
            return template;
        }
    }
}
