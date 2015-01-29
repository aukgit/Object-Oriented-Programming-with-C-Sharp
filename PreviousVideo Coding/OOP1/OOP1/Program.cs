using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using OOP1.Inheritance;
//using OOP1.Polymorphism;
//using OOP1.ExtensionMethod;
//using OOP1.Inheritance;
//using OOP1.Interfaces;
/*
 * Written by Alim Ul Karim
 * mailto: alim@developers-organism.com
 * developers-organism.com
 * find us on fb.com/developersOrganism
 * */
namespace OOP1 {

    class X { 
        public virtual void Hello() {
            Console.WriteLine("Hello from X");
        } 
    }
    class Y : X {
        public  override  void Hello() {
            Console.WriteLine("Hello from Y");
        } 
    }
    class Z : Y {
        public  void Hello() {
            Console.WriteLine("Hello from Z");
        } 
    }
    class Program {
        public static void Main(string[] args) {
            //assume that this is in the static main method
           var c = new B("Hello 2");
           var ex = B.StaticExample;

           X x = new Y();
           //Y y = new X();
           X zC = new Z();
           //Z z1 = new X();
           //Z z2 = new Y();
           var x2 = new Y();
           zC.Hello();
           
           Console.ReadKey();
        }

    }
}
