using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public abstract class Template {
        protected string _templateName;
        protected string _templateType;
        private List<Question> _questions = new List<Question>();

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

        public void AddQuestion(Question question) {
            _questions.Add(question);
        }

        public Question GetQuestion(int id) {
            foreach (Question q in _questions) {
                if (q.ID == id) {
                    return q;
                }
            }
            return null;
        }

        public void RemoveQuestion(int id) {
            _questions.Remove(GetQuestion(id));
        }

        public List<Question> Questions {
            get { return _questions; }
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