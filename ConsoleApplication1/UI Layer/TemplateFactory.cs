using ConsoleApplication1.Core;

namespace ConsoleApplication1 {
    class TemplateFactory {
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
