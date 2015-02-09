
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JumpStartOOP.Example;

namespace JumpStartOOP.Inheritence
{
    class Student : Person
    {

        public Student() {

        }

        public Student(bool callPerson): base("Example First Name") {
            
        }
       
        #region Extended Fields of Students

        public float CGPA;
        public byte CompletedCourse;
        public DateTime JoinDate;

        #endregion

        #region Logic or Methods or Functions or Behaviors

        public void Display() {
            Console.WriteLine("Student : " + FirstName + " " + LastName);
            Console.WriteLine("CGPA : " + CGPA);
            Console.WriteLine("Date Of Birth : " + DateOfBirth.ToString());
            Console.WriteLine("Completed Courses : " + CompletedCourse.ToString());
        }
        
        #endregion


    }
}
