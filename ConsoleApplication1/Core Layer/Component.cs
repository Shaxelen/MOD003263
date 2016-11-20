using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public abstract class Component {
        
        public Component() { }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void RemoveAt(int index);
        public abstract Component GetChild(int index);
    }
}
