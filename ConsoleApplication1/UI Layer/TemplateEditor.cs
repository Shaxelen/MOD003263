using ConsoleApplication1.Core;

namespace ConsoleApplication1 {
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
