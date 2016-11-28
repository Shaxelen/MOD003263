using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    public abstract class Template : ComponentManager {
        protected string _templateName;
        protected string _templateType;

        /// <summary>
        /// Template constructor
        /// </summary>
        public Template() { }

        /// <summary>
        /// Gets and sets the name of the template
        /// </summary>
        public string TemplateName {
            get { return _templateName; }
            set { _templateName = value; }
        }

        /// <summary>
        /// Returns the type of template
        /// </summary>
        public string TemplateType {
            get { return _templateType; }
        }
    }

    public class CVTemplate : Template {
        /// <summary>
        /// CV Template constructor
        /// </summary>
        public CVTemplate() {
            _templateType = "CV";
        }
    }

    public class InterviewTemplate : Template {
        /// <summary>
        /// Interview template constructor
        /// </summary>
        public InterviewTemplate() {
            _templateType = "Interview";
        }
    }

    public class EmployeeTemplate : Template {
        /// <summary>
        /// Employee template constructor
        /// </summary>
        public EmployeeTemplate() {
            _templateType = "Employee";
        }
    }
}