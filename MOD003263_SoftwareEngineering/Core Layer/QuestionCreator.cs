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
        /// <param name="title">The question</param>
        /// <returns></returns>
        public Question CreateQuestion(int id, string title, string comment, int score) {
            _question = new Question();
            _question.Title = title;
            _question.Comment = comment;
            _question.Score = score;
            _question.ID = id;
            return _question;
        }
    }
}
