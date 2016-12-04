using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class Score : Component {
        private int _score;

        /// <summary>
        /// Score Constructor
        /// </summary>
        public Score() { }

        /// <summary>
        /// Get and set the score
        /// </summary>
        public int QScore {
            get { return _score; }
            set { _score = value;
                if (_score <= 1) {
                    _score = 1;
                } else if (_score >= 5) {
                    _score = 5;
                }
            }
        }
    }
}
