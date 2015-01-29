using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Written by Alim Ul Karim
 * mailto: alim@developers-organism.com
 * developers-organism.com
 * find us on fb.com/developersOrganism
 * */
namespace OOP1.Polymorphism {
    
    class Person {
        public Person() {
            Console.WriteLine("Person Created.");
        }
        #region Data or Fields without Encapsulation

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        /// <summary>
        /// False : Female
        /// </summary>
        public bool Gender; 

        #endregion

        #region Logic or Methods or Functions or Behaviors

        public void Walk() {
            Console.WriteLine(FirstName + " is walking.");
        }
        /// <summary>
        /// It's a method
        /// </summary>
        /// <param name="param">it's a param for name.</param>
        public void Eat() {
            Console.WriteLine(FirstName + " is eating.");            
        }

        #endregion
        #region Destructor
        ~Person() {
            //destructor
            Console.WriteLine("Destructor is called.");
        }
        #endregion

    }
}
