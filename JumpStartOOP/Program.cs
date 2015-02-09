//using JumpStartOOP.ClassConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleForAccessModifier;
using JumpStartOOP.ClassConcept.Generics;
using JumpStartOOP.Example;
using JumpStartOOP.Inheritence;
//using JumpStartOOP.ClassConcept.Generics;
//using JumpStartOOP.Inheritence;

namespace JumpStartOOP
{
    class Program
    {

        static void Destructor() {
            Person person = new Person("Alice");
            Person.LastName = " Hello";

            person.Walk();
            person.Eat();
            person.Talk();

        }

        static void PersonChange(Person person) {
            person.FirstName = "new first name";
        }
        
        static void Main(string[] args) {
            //var x;
            var example = new C();
            var c = new Class1();
            c.
            

            //alice.Walk();
            //PersonChange(alice);
            //alice.Eat();
            //var list = new VectorGenerics<Person>();
            //list.Add()
            Console.WriteLine(Person.LastName);
            Console.ReadLine();
        }
    }
}
