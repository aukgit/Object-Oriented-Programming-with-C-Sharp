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
    class EncapPerson2 {

        #region Data or Fields
        private string _FirstName;
        private string _LastName;       
        #endregion

        #region Getter or Setters
        public string FirstName {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName {
            get { return _LastName; }
            set { _LastName = value; }
        }
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
