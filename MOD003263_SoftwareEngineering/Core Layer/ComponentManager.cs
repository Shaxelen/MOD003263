using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    public abstract class ComponentManager : Component {
        protected List<Component> _components = new List<Component>();

        public ComponentManager() { }

        public void Add(Component component) {
            _components.Add(component);
        }

        public void Remove(Component component) {
            _components.Remove(component);
        }

        public void RemoveAt(int index) {
            _components.RemoveAt(index);
        }

        public Component GetComponent(Component component) {
            if (_components.Contains(component)) {
                return component;
            }
            return null;
        }

        public List<Component> AttachedComponents {
            get { return _components; }
        }
    }
}
