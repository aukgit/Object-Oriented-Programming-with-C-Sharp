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
namespace OOP1 {
    class EncapPerson3 {

        #region Data or Properties or Attributes
        public string FirstName { get; set; }
        public string LastName { get; set; }       

        #endregion


        #region Logic or Methods or Functions or Behaviours
        
        public void Walk() {
            Console.WriteLine(FirstName + " is walking.");
        }
        public void Eat() {
            Console.WriteLine(FirstName + " is eating.");
        }

        #endregion

    }
}
