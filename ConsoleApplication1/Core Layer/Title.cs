using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class Title : Component {
        private string _title;

        public Title(string title) {
            _title = title;
        }

        public string QTitle {
            get { return _title; }
        }
    }
}
