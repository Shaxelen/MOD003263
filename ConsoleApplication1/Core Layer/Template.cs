using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public abstract class Template {
        protected string _templateName;
        protected string _templateType;
        protected List<string> _templateQuestions = new List<string>();
        protected Person _person;

        /// <summary>
        /// Template constructor
        /// </summary>
        public Template() { }

        /// <summary>
        /// Add a question to the template
        /// </summary>
        /// <param name="question">The question to add</param>
        public void Add(string question) {
            _templateQuestions.Add(question);
        }

        /// <summary>
        /// Remove a question from the template
        /// </summary>
        /// <param name="question">The question to remove</param>
        public void Remove(string question) {
            _templateQuestions.Remove(question);
        }

        /// <summary>
        /// Removes a Question at a certain index
        /// </summary>
        /// <param name="index">The index to Remove the question at</param>
        public void RemoveAt(int index) {
            _templateQuestions.RemoveAt(index);
        }


        /// <summary>
        /// Adds a Person to the template
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson(Person person) {
            _person = person;
        }

        /// <summary>
        /// Gets and Sets the Template Name
        /// </summary>
        public string TemplateName {
            get { return _templateName; }
            set { _templateName = value; }
        }

        /// <summary>
        /// Gets and Sets a person class
        /// </summary>
        public Person Person {
            get { return _person; }
            set { _person = value; }
        }

        /// <summary>
        /// Returns the template question list
        /// </summary>
        public List<string> TemplateQuestions {
            get { return _templateQuestions; }
        }
    }

    class CVTemplate : Template {
        /// <summary>
        /// CV Template constructor
        /// </summary>
        public CVTemplate() {
            _templateType = "CV";
        }
    }

    class InterviewTemplate : Template {
        /// <summary>
        /// Interview template constructor
        /// </summary>
        public InterviewTemplate() {
            _templateType = "Interview";
        }
    }

    class EmployeeTemplate : Template {
        /// <summary>
        /// Employee template constructor
        /// </summary>
        public EmployeeTemplate() {
            _templateType = "Employee";
        }
    }
}