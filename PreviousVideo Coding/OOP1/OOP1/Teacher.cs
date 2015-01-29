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
    class Teacher {

        #region Data or Fields
        //copy paste from Person
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        /// <summary>
        /// False : Female
        /// </summary>
        public bool Gender;

        #endregion

        #region Extended Fields of Teacher

        public string SubjectProficiency;
        public string OfficeHours;
        public string Department;

        #endregion

        #region Logic or Methods or Functions or Behaviors

        public void Display() {
            
            Console.WriteLine("Teacher : " + FirstName + " " + LastName);
            Console.WriteLine("Subject Proficiency : " + SubjectProficiency);
            Console.WriteLine("Office Hours : " + OfficeHours.ToString());
            Console.WriteLine("Department : " + Department.ToString());
        }
        
        #endregion

    }
}
