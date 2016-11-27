using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD003263_SoftwareEngineering.Core;

namespace MOD003263_SoftwareEngineering.UI {
    public class QuestionCreator {
        private static QuestionCreator _instance;
        private Question _question;
        private Title _title;
        private Comment _comment;
        private Score _score;

        private QuestionCreator() { }

        public static QuestionCreator Instance() {
            if (_instance == null) {
                _instance = new QuestionCreator();
            }
            return _instance;
        }

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

        private Question Question() {
            return _question = new Question();
        }

        private Title Title(string title) {
            return _title = new Title(title);
        }

        private Comment Comment() {
            return _comment = new Comment();
        }

        private Score Score() {
            return _score = new Score();
        }
    }
}
