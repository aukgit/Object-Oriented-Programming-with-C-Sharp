using JumpStartOOP.ClassConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartOOP
{
    class Program
    {
        static void DestructorExamples() {
            Person person = new Person("Alice");


            person.Walk();
            person.Talk();
            person.Eat();

            person = null;
            GC.Collect();
        }

        static void StaticExample()
        {
            Person alice = new Person("Alice");
            Person robin = new Person("Robin");

            Person.StaticFirstName = "Hello is called from static";

            Console.WriteLine(Person.StaticFirstName);

        }

        static void StaticExamplePrint()
        {
            Person alice2 = new Person("Alice 2");
            Person robin2 = new Person("Robin 2");
            Console.WriteLine(Person.StaticFirstName);
        }

        void NonStaticMember() {
            StaticExamplePrint();
        }
        static void Main(string[] args) {
            //DestructorExamples();

            StaticExample();

            Console.WriteLine(Person.StaticFirstName);


            Person.StaticFirstName = "2nd time static change";

            StaticExamplePrint();

            Console.ReadLine();
        }
    }
}
