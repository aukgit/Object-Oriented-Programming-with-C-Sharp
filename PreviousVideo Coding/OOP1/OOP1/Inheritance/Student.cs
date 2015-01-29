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
namespace OOP1.Inheritance {
    class Student : Person {
        public Student() {

        }
        #region Extension Fields of Students

        public float CGPA;
        public byte CompletedCourse;
        public DateTime JoinDate;

        #endregion

        #region Logic or Methods or Functions or Behaviours

        public void Display() {
            Console.WriteLine("Student : " + FirstName + " " + LastName);
            Console.WriteLine("CGPA : " + CGPA);
            Console.WriteLine("Date Of Birth : " + DateOfBirth.ToString());
            Console.WriteLine("Completed Courses : " + CompletedCourse.ToString());
        }

        #endregion
    }
}
