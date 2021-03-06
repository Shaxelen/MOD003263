﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public abstract class Person {
        protected short _personID;
        protected string _personImageFile;
        protected string _personFirstName;
        protected string _personLastName;
        protected string _personEmailAddress;
        protected string _personPhoneNumber;
        protected string _position;

        private string _defaultImageFile;

        /// <summary>
        /// Person constructor
        /// </summary>
        public Person() { }

        /// <summary>
        /// Get and Set Person Image File Location, if no image is found display a default image
        /// </summary>
        public string ImageFileLocation {
            get { return _personImageFile; }
            set {
                if (null == _personImageFile) {
                    _personImageFile = _defaultImageFile;
                }
                else {
                    _personImageFile = value;
                }
            }
        }

        /// <summary>
        /// Get and Set the Person First Name
        /// </summary>
        public string FirstName {
            get { return _personFirstName; }
            set { _personFirstName = value; }
        }

        /// <summary>
        /// Get and Set the Person Last Name
        /// </summary>
        public string LastName {
            get { return _personLastName; }
            set { _personLastName = value; }
        }

        /// <summary>
        /// Get and Set the Person Email Address
        /// </summary>
        public string EmailAddress {
            get { return _personEmailAddress; }
            set { _personEmailAddress = value; }
        }

        /// <summary>
        /// Get and Set the Person Phone Number
        /// </summary>
        public string PhoneNumber {
            get { return _personPhoneNumber; }
            set { _personPhoneNumber = value; }
        }
    }

    class Applicant : Person {

        /// <summary>
        /// Get and Set Applicant ID
        /// </summary>
        public short ApplicantID {
            get { return _personID; }
            set { _personID = value; }
        }

        /// <summary>
        /// Get and Set Applicant Applied Position
        /// </summary>
        public string ApplicantPosition {
            get { return _position; }
            set { _position = value; }
        }
    }
    class Employee : Person {

        /// <summary>
        /// Get and Set Employee ID
        /// </summary>
        public short EmployeeID {
            get { return _personID; }
            set { _personID = value; }
        }

        /// <summary>
        /// Get and Set Employee Position
        /// </summary>
        public string EmployeePosition {
            get { return _position; }
            set { _position = value; }
        }
    }
}
