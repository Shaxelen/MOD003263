using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Core {
    [Serializable]
    public class CategoryBank {
        private List<Category> _categories = new List<Category>();

        public CategoryBank() { }


        public void Add(Category category) {
            _categories.Add(category);
        }

        public Category FindCategory(string title) {
            foreach (Category c in _categories) {
                if (c.Title == title) {
                    return c;
                }
            }
            return null;
        }

        public List<Category> Categories {
            get { return _categories; }
        }

        public void Remove(string title) {
            Category temp = null;
            for (int i = 0; i < _categories.Count; i++) {
                if (_categories[i].Title == title) {
                    temp = _categories[i];
                    break;
                }
            }
            _categories.Remove(temp);
        }

        public void Update(string title, Category category) {
            for (int i = 0; i < _categories.Count; i++) {
                if (_categories[i].Title == title) {
                    _categories[i] = category;
                    break;
                }
            }
        }
    }
}
