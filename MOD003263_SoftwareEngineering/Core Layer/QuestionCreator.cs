using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD003263_SoftwareEngineering.Core;

namespace MOD003263_SoftwareEngineering.Core {
    public class QuestionCreator {
        private static QuestionCreator _instance;
        private Question _question;
        private Title _title;
        private Comment _comment;
        private Score _score;

        /// <summary>
        /// QuestionCreator Constructor
        /// </summary>
        private QuestionCreator() { }

        /// <summary>
        /// The static instance of QuestionCreator
        /// </summary>
        /// <returns>QuestionCreator instance</returns>
        public static QuestionCreator Instance() {
            if (_instance == null) {
                _instance = new QuestionCreator();
            }
            return _instance;
        }

        /// <summary>
        /// Creates a question
        /// </summary>
        /// <param name="id">The question id</param>
        /// <param name="question">The question</param>
        /// <returns></returns>
        public Question CreateQuestion(int id, string question) {
            _question = Question();
            _title = Title(question);
            _comment = Comment();
            _score = Score();

            _question.Add(_title);
            _question.Add(_comment);
            _question.Add(_score);

            _question.ID = id;

            return _question;
        }

        /// <summary>
        /// Returns a Question
        /// </summary>
        /// <returns>A new Question</returns>
        private Question Question() {
            return _question = new Question();
        }

        /// <summary>
        /// Returns a Title
        /// </summary>
        /// <param name="title">The title of the question</param>
        /// <returns>A new Title</returns>
        private Title Title(string title) {
            return _title = new Title(title);
        }

        /// <summary>
        /// Returns a Comment
        /// </summary>
        /// <returns>A new Comment</returns>
        private Comment Comment() {
            return _comment = new Comment();
        }

        /// <summary>
        /// Returns a Score
        /// </summary>
        /// <returns>a new Score</returns>
        private Score Score() {
            return _score = new Score();
        }
    }
}
