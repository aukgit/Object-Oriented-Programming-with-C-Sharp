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
namespace OOP1.ExtensionMethod {
    static class  PersonExtensionMethod {
        public static void ExtensionMethodForPerson(this Person person, string firstName) {
            person.FirstName = firstName;
            person.Eat();            
        }
        public static double ToDouble(this string str) {
            return double.Parse(str);
        }

        public static string[] Add(this string[] str) {
            return new string[2];
        }
    }
}
