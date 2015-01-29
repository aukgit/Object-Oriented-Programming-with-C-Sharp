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
    class EncapPerson4 {

        #region Data or Properties or Attributes
        public string FirstName { private get; set; }
        private string _lastName;

        public string LastName {
            get {
                if (_lastName == null) {
                    _lastName = "";
                }
                return _lastName; 
            }
            private set { if(_lastName != null) _lastName = value; }
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
