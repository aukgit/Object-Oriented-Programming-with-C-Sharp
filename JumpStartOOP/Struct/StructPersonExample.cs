using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartOOP.Struct
{
    class StructPersonExample
    {
        string NoAccessModifier;
        public string PublicAccessModifierString;
        public static string PublicStaticString;
        public const string PublicConstString = "Const Example";

        #region data  or attributes

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public bool Gender;

        public static string StaticFirstName;

        #endregion

        #region Behaviours or Functions or Methods

        public void Walk()
        {
            Console.WriteLine(FirstName + " is walking.");
        }

        public void Eat()
        {
            Console.WriteLine(FirstName + " is eating.");
        }

        public void Talk()
        {
            Console.WriteLine(FirstName + " is talking.");
        }

        #endregion

    }
}
