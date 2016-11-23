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
        private Title _quetionTitle;
        private Comment _questionComment;
        private Score _questionScore;

        private QuestionCreator() { }

        public static QuestionCreator Instance() {
            if (_instance == null) {
                _instance = new QuestionCreator();
            }
            return _instance;
        }

        public Question CreateQuestion(string question, bool hasComment, bool hasScore) {
            _question = Question();
            _quetionTitle = Title(question);
            _question.Add(_quetionTitle);

            if (hasComment) AddComment();
            if (hasScore) AddScore();

            return _question;
        }

        private Question Question() {
            return new Question();
        }

        private Title Title(string title) {
            return new Title(title);
        }

        private void AddComment() {
            _questionComment = new Comment();
            _question.Add(_questionComment);
        }

        private void AddScore() {
            _questionScore = new Score();
            _question.Add(_questionScore);
        }
        
        private void RemoveComment() {
            _question.Remove(_questionComment);
        }

        private void RemoveScore() {
            _question.Remove(_questionScore);
        }
    }
}
