using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartOOP.ClassConcept
{
    class Person {

        #region data  or attributes

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public bool Gender;

        #endregion

        #region Behaviours or Functions or Methods

        public void Walk() {
            Console.WriteLine(FirstName + " is walking.");
        }

        public void Eat() {
            Console.WriteLine(FirstName + " is eating.");
        }

        public void Talk() {
            Console.WriteLine(FirstName + " is talking.");
        }

        #endregion

    }
}
