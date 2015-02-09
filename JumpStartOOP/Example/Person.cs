using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartOOP.Example {
   class Person {

       public Person() {
           
           Console.WriteLine("Person is created.");
       }
        public Person(string FirstName) {
            this.FirstName = FirstName;
            Console.WriteLine(this.FirstName + " is created.");
        }
        #region Data or attributes
        public string FirstName;
        public static string LastName;
        public DateTime DateOfBirth;
        /// <summary>
        /// True for male
        /// False for female
        /// </summary>
        public bool Gender;
        public string Adress;
        
        #endregion


        #region Behaviour
        public void Eat() {
            Console.WriteLine(FirstName + " is eating.");
        }

        public void Walk() {
            Console.WriteLine(FirstName + " is walking.");
        }

        public void Talk() {
            Console.WriteLine(FirstName + " is talking.");
        } 
        #endregion

        #region Destructor
        ~Person() {
            Console.WriteLine("Destructor called.");
        }
        #endregion
    }
}
