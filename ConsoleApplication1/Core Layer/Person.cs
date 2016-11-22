using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public abstract class Person {
        private byte _id;
        private string _imageFile;
        private string _defaultImageFile;
        private string _firstName;
        private string _lastName;
        private string _emailAddress;
        private string _phoneNumber;
        private string _position;


        public Person() { }

        public byte ID {
            get { return _id; }
            set { _id = value; }
        }

        public string ImageFileLocation {
            get { return _imageFile; }
            set { _imageFile = value;
                if (_imageFile == null) {
                    _imageFile = _defaultImageFile;
                }
            }
        }

        public string DefaultImage {
            get { return _defaultImageFile; }
            set { _defaultImageFile = value; }
        }

        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        public string PhoneNumber {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Position {
            get { return _position; }
            set { _position = value; }
        }
    }

    class Applicant : Person {
        public Applicant() { }

    }

    class Employee : Person {
        public Employee() { }
    }
}
