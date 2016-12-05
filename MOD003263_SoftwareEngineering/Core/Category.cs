using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class Category {
        private string _title;
        private List<Question> _questions = new List<Question>();

        public Category(string title) {
            _title = title;
        }

        public string Title {
            get { return _title; }
        }

        public List<Question> Questions {
            get { return _questions; }
        }

        public void Add(Question question) {
            _questions.Add(question);
        }

        public Question Find(int id) {
            foreach (Question q in _questions) {
                if (q.ID == id) {
                    return q;
                }
            }
            return null;
        }

        public void Delete(int id) {
            _questions.Remove(Find(id));
        }
    }
}