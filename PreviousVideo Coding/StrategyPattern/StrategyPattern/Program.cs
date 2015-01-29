using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Written by Alim Ul Karim
 * mailto: alim@developers-organism.com
 * developers-organism.com
 * find us on fb.com/developersOrganism
 * */
namespace StrategyPattern {
    class Program {
        static void Main(string[] args) {
            try {
                var ostrish = new Ostrich();
                var parrot = new Parrot();
                var penguin = new Penguin();
                var rubberBird = new RubberBird();

                ostrish.Display();
                ostrish.Fly();
                Console.WriteLine("After modifying the flying behavior.");
                ostrish.FlyBehaviour = new FlyBehaviour();
                ostrish.Fly();
                ostrish.Speak();
                ostrish.Swim();

                Console.WriteLine("\n");

                parrot.Display();
                parrot.Fly();
                parrot.Speak();
                parrot.Swim();

                Console.WriteLine("\n");

                penguin.Display();
                penguin.Fly();
                penguin.Speak();
                penguin.Swim();

                Console.WriteLine("\n");

                rubberBird.Display();
                rubberBird.Fly();
                rubberBird.Speak();
                rubberBird.Swim();

            } catch (Exception ex) {
                Console.WriteLine("Error : " + ex.Message.ToString());
            }
            
            
            Console.ReadKey();



        }
    }
}
