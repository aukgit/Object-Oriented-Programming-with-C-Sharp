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
    class Polymorphism3 : PersonPoly {
        #region New Properties Add
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        #endregion
        public Polymorphism3(string FirstName) {
            base.FirstName = FirstName;
            //this.FirstName = FirstName;
        }


        #region Polymorphism Methods
        public override void Walk() {
            base.Walk();
            Console.WriteLine(base.FirstName + " is walking from polymorphism3 class.");
        }

        /// <summary>
        /// Ad hoc polymorphism overloading
        /// Can only be done if parameter type is different 
        /// or the count of the parameter is different.
        /// It doesn't depend on return type.
        /// </summary>
        /// <param name="FirstName"></param>
        public void Walk(string FirstName) {
            base.FirstName = FirstName;
            Walk();
        }
 

        ///// <summary>
        ///// Can't compile
        ///// </summary>
        ///// <param name="FirstName"></param>
        //public void Walk(string LastName) {
        //    base.LastName = LastName;
        //    Walk();
        //}

        ///// <summary>
        ///// Can't compile
        ///// </summary>
        ///// <param name="FirstName"></param>
        //public string Walk(string LastName) {
        //    base.LastName = LastName;
        //    Walk();
        //}

        public void Walk(string FirstName, string LastName) {
            base.FirstName = FirstName;
            base.LastName = LastName;
            //When calls only Walk() it calls Walk() method inside this class.
            Walk();
            //base.Walk() calls the super class Walk() method.
        }

        public void ChangeThisProperties(string FirstName, string LastName) {
            this.FirstName = FirstName;
            this.LastName = FirstName;
            Console.WriteLine("This property changes : " +  this.FirstName + " " + this.LastName);
        }

        public void ChangeBaseProperties(string FirstName, string LastName) {
            base.FirstName = FirstName;
            base.LastName = FirstName;
            Console.WriteLine("This property changes : " + base.FirstName + " " + base.LastName);
        }

        ///// <summary>
        ///// Can't Compile because base method is not marked with virtual keyword.
        ///// </summary>
        //public override void Eat() {
        //    Console.WriteLine(base.FirstName + " is eating from polymorphism1 class.");
        //}

        public override string ToString() {
            return "Override tostring(): " + base.FirstName + " " + base.LastName;
        } 
        #endregion
    }
}
