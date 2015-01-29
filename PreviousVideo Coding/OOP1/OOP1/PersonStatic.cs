using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1 {
    static class PersonStatic {

        #region Data or Fields

        public static string FirstName;
        public static string LastName;
        public static DateTime DateOfBirth;
        /// <summary>
        /// False : Female
        /// </summary>
        public static bool Gender; 

        #endregion

        #region Logic or Methods or Functions or Behaviors

        public static  void Walk() {
            Console.WriteLine(FirstName + " is walking.");

        }
        
        static void Eat() {
            Console.WriteLine(FirstName + " is eating.");
            
        }

        #endregion

    }
}
