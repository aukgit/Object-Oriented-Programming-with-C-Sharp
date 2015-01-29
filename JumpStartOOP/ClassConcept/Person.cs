using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartOOP.ClassConcept
{
    partial class Person {

        

        #region Constructors

        public Person() {
           Console.WriteLine("Person is created.");
        }

        public Person(string FirstName) {
            this.FirstName = FirstName;
            Console.WriteLine(this.FirstName + " is created.");
        }

        #endregion

        #region data  or attributes

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public bool Gender;

        public static string StaticFirstName ;

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

        #region Destructor

        ~Person() {
            Console.WriteLine("Destructor is called.");
        }

        #endregion


    }
}
