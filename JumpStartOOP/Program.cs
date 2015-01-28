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
        static void Main(string[] args) {

            Person person = new Person("Alice");


            person.Walk();
            person.Talk();
            person.Eat();

            person = null;
            GC.Collect();

            Console.ReadLine();
        }
    }
}
