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
    class Polymorphism1 : PersonPoly {
   
        public Polymorphism1(string FirstName) {
            base.FirstName = FirstName;
            //this.FirstName = FirstName;
        }


        #region Polymorphism Methods
        public override void Walk() {
            base.Walk();
            Console.WriteLine(base.FirstName + " is walking from polymorphism1 class.");
        }
        
        #endregion
    }
}
