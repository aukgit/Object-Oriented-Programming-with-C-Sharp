using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern {
    public class Parrot : Bird {
        public Parrot() : base(new FlyBehaviour(),new ParrotSpeakBehaviour(),new NoSwimBehaviour()) {
            
        }

        public override void Display() {
            Console.WriteLine("This is a parrot.");
        }
    }
}
