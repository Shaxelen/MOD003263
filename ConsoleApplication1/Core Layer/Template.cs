using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public abstract class Template : Component {
        protected string _templateName;
        protected string _templateType;
        protected Person _person;
        protected List<Component> _componentList = new List<Component>();

        /// <summary>
        /// Template constructor
        /// </summary>
        public Template() { }

        /// <summary>
        /// Add a Person to the template
        /// </summary>
        /// <param name="person">The person object to add</param>
        public void AddPerson(Person person) {
            _person = person;
        }

        /// <summary>
        /// Add a component to the template
        /// </summary>
        /// <param name="component">The component to add</param>
        public override void Add(Component component) {
            _componentList.Add(component);
        }

        /// <summary>
        /// Remove a component from the template
        /// </summary>
        /// <param name="component">The component to remove</param>
        public override void Remove(Component component) {
            _componentList.Remove(component);
        }

        /// <summary>
        /// Remove a component at a certain index
        /// </summary>
        /// <param name="index">The index of the component to remove</param>
        public override void RemoveAt(int index) {
            _componentList.RemoveAt(index);
        }

        /// <summary>
        /// Return an attached component from the component list by its index
        /// </summary>
        /// <param name="index">The index of the component</param>
        /// <returns></returns>
        public override Component GetChild(int index) {
            Component comp = _componentList[index];
            return comp;
        }

        /// <summary>
        /// Get and Set the Template Name
        /// </summary>
        public string TemplateName {
            get { return _templateName; }
            set { _templateName = value; }
        }

        /// <summary>
        /// Get and Set a person class
        /// </summary>
        public Person Person {
            get { return _person; }
            set { _person = value; }
        }

        /// <summary>
        /// Return all attached components
        /// </summary>
        public List<Component> ComponentList {
            get { return _componentList; }
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