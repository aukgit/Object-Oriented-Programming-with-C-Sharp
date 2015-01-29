using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1.Polymorphism;
/*
 * Written by Alim Ul Karim
 * mailto: alim@developers-organism.com
 * developers-organism.com
 * find us on fb.com/developersOrganism
 * */
namespace OOP1.PassingClassParameter {
    class PassingClassParam {


        public void test1(string name) {
            name = "Hello Changed!";
        }
  

        public void ChangePerson(Person person) {
            person.FirstName = "First Name Changed!";
            person.LastName = "Last Name Changed!";
        }
    }
}
