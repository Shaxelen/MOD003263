using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class Score : Component {
        private int _score;

        /// <summary>
        /// Score Constructor
        /// </summary>
        public Score() { }

        /// <summary>
        /// Get and set the score
        /// </summary>
        public int QuestionScore {
            get { return _score; }
            set { _score = value; }
        }

        // Not used
        public override void Add(Component component) {
            throw new NotImplementedException();
        }

        // Not used
        public override void Remove(Component component) {
            throw new NotImplementedException();
        }

        // Not used
        public override void RemoveAt(int index) {
            throw new NotImplementedException();
        }

        // Not used
        public override Component GetChild(int index) {
            throw new NotImplementedException();
        }
    }
}
