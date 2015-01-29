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
    class EncapPerson1 {

        #region Data or Fields

        private string _FirstName;
        private string _LastName;

        #endregion

        #region Getter or Setters
        public string getFirstName() {
            return _FirstName;
        }
        public void setFirstName(string _FirstName) {
            this._FirstName = _FirstName;
        }

        public string getLastName() {
            return _LastName;
        }
        public void setLastName(string _LastName) {
            this._LastName = _LastName;
        }

        #endregion

        #region Logic or Methods or Functions or Behaviours
        
        public void Walk() {
            Console.WriteLine(getFirstName() + " is walking.");
        }
        public void Eat() {
            Console.WriteLine(getFirstName() + " is eating.");
        }

        #endregion

    }
}
