using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    public abstract class ComponentManager : Component {
        protected List<Component> _components = new List<Component>();

        /// <summary>
        /// ComponentManager Constructor
        /// </summary>
        public ComponentManager() { }

        /// <summary>
        /// Adds a component to the component list
        /// </summary>
        /// <param name="component">The component to add</param>
        public void Add(Component component) {
            _components.Add(component);
        }

        /// <summary>
        /// Removes a component from the component list
        /// </summary>
        /// <param name="component">The component to remove</param>
        public void Remove(Component component) {
            _components.Remove(component);
        }

        /// <summary>
        /// Removes a component from the component list by its index
        /// </summary>
        /// <param name="index">The index of the component</param>
        public void RemoveAt(int index) {
            _components.RemoveAt(index);
        }

        /// <summary>
        /// Returns a component from the component list by its index
        /// </summary>
        /// <param name="index">The index of the component</param>
        /// <returns></returns>
        public Component GetComponent(int index) {
            return _components[index];
        }

        /// <summary>
        /// Returns the list of attached components
        /// </summary>
        public List<Component> AttachedComponents {
            get { return _components; }
        }
    }
}
