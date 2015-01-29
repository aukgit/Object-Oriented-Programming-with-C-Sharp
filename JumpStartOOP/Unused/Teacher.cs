using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartOOP.Inheritence
{
    class Teacher
    {

        #region person data  or attributes

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public bool Gender;

        public static string StaticFirstName;

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
