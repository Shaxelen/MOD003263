using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class Question {
        private int _questionID;
        private string _title;
        private int _score;
        private string _comment;

        /// <summary>
        /// Question Constructor
        /// </summary>
        public Question () { }

        /// <summary>
        /// Gets and sets the ID of the question
        /// </summary>
        public int ID {
            get { return _questionID; }
            set { _questionID = value; }
        }

        public string Title {
            get { return _title; }
            set { _title = value; }
        }

        public int Score {
            get { return _score; }
            set {
                _score = value;
                if (_score <= 1) {
                    _score = 1;
                } else if (_score >= 5) {
                    _score = 5;
                }
            }
        }

        public string Comment {
            get { return _comment; }
            set { _comment = value; }
        }
    }
}
