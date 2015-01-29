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
    class Polymorphism2 : PersonPoly {
        public Polymorphism2(string FirstName) {
            base.FirstName = FirstName;
            //this.FirstName = FirstName;
        }


        #region Ad-hoc Polymorphism With Overloading
        public override void Walk() {
            base.Walk();
            Console.WriteLine(base.FirstName + " is walking from polymorphism2 class.");
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

        #endregion
    }
}
