using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class Header : Component {
        Person _person;

        public Header() { }

        public Person Person {
            get { return _person; }
            set { _person = value; }
        }
    }
}
