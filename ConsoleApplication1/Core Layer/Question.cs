using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class Question {
        private string _questionTitle;
        private string _feedback;
        private string _additionalFeedback;
        private int _score;

        /// <summary>
        /// Question Constructor
        /// </summary>
        public Question () { }

        /// <summary>
        /// Question Constructor
        /// </summary>
        /// <param name="questionTitle">The title of the question</param>
        public Question(string questionTitle) {
            _questionTitle = questionTitle;
        }

        /// <summary>
        /// Question Constructor
        /// </summary>
        /// <param name="questionTitle">The title of the question</param>
        /// <param name="feedback">The question feedback</param>
        public Question(string questionTitle, string feedback) {
            _questionTitle = questionTitle;
            _feedback = feedback;
        }

        /// <summary>
        /// Question Constructor
        /// </summary>
        /// <param name="questionTitle">The title of the question</param>
        /// <param name="feedback">The question feedback</param>
        /// <param name="score">The score of the question</param>
        public Question(string questionTitle, string feedback, int score) {
            _questionTitle = questionTitle;
            _feedback = feedback;
            _score = score;
        }

        /// <summary>
        /// Question Constructor
        /// </summary>
        /// <param name="questionTitle">The title of the question</param>
        /// <param name="feedback">The question feedback</param>
        /// <param name="additionalFeedback">The questions additional feedback</param>
        /// <param name="score">The score of the question</param>
        public Question(string questionTitle, string feedback, string additionalFeedback, int score) {
            _questionTitle = questionTitle;
            _feedback = feedback;
            _additionalFeedback = additionalFeedback;
            _score = score;
        }

        public override string ToString() {
            return _questionTitle + " " + _feedback + " " + _additionalFeedback + " " + _score;
        }
        /// <summary>
        /// Gets and sets the Question Title
        /// </summary>
        public string QuestionTitle {
            get { return _questionTitle; }
            set { _questionTitle = value; }
        }
        /// <summary>
        /// Gets and sets the Feedback
        /// </summary>
        public string Feedback {
            get { return _feedback; }
            set { _feedback = value; }
        }
        /// <summary>
        /// Gets and sets the Additonal Feedback
        /// </summary>
        public string AdditionalFeedback {
            get { return _additionalFeedback; }
            set { _additionalFeedback = value; }
        }
        /// <summary>
        /// Gets and sets the score
        /// </summary>
        public int Score {
            get { return _score; }
            set { _score = value; }
        }
    }
}
