using JumpStartOOP.ClassConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JumpStartOOP.ClassConcept.Generics;
using JumpStartOOP.Inheritence;

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

        void StaticExamplePrintAll() {
            StaticExample();

            Console.WriteLine(Person.StaticFirstName);


            Person.StaticFirstName = "2nd time static change";

            StaticExamplePrint();

        }

        static void ChangePersonName(Person person) {
            person.FirstName = "Changed first name";
        }

        static void ReferenceTypeObjectPassingExample() {
            Person alice2 = new Person("Alice 2");
            ChangePersonName(alice2);

            alice2.Eat();
        }
        //10
        
        static void Main(string[] args) {
            //DestructorExamples();


            //var vector = new Vector();
            //vector.Add("Hello");

            Teacher alice = (Teacher)new Student();

            

            Console.ReadLine();
        }
    }
}
