using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1 {
    class Person {
        public static string StaticExample {
            get { Console.WriteLine("Get"); return ""; } 
            set {
                Console.WriteLine("Set");
            }
        }
        public string Firstname = "Base Initialized Name";
        public Person(string Firstname) {
            Console.WriteLine("Person Created : " + this.Firstname);
        }
    }

    class B : Person {
        string Firstname = "Child Initialized Name";
        public B(string Firstname)
            : base("Hello") {
            Console.WriteLine("Person Created : " + this.Firstname);
            Console.WriteLine("Person Created : " + base.Firstname);
            Console.WriteLine("Person Created : " + Firstname);
        }
    }
}




