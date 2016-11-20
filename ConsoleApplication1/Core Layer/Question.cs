using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class Question : Component {
        private string _questionTitle;
        private List<Component> _componentList = new List<Component>();

        /// <summary>
        /// Question Constructor
        /// </summary>
        /// <param name="questionTitle">The question title </param>
        public Question (string questionTitle) {
            _questionTitle = questionTitle;
        }

        /// <summary>
        /// Add a component to the question
        /// </summary>
        /// <param name="component">The component to add</param>
        public override void Add(Component component) {
            _componentList.Add(component);
        }

        /// <summary>
        /// Remove a component from the question
        /// </summary>
        /// <param name="component">The component to remove</param>
        public override void Remove(Component component) {
            _componentList.Remove(component);
        }

        /// <summary>
        /// Remove a component at a certian index
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
        /// Displays the object as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return QuestionTitle;
        }

        /// <summary>
        /// Get and set the Question Title
        /// </summary>
        public string QuestionTitle {
            get { return _questionTitle; }
            set { _questionTitle = value; }
        }
    }
}
