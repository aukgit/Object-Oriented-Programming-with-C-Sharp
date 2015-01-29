using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern {
    public class Penguin : Bird {
        public Penguin()
            : base(new NoFlyBehaviour(), new PenguinSpeakBehaviour(), new SwimBehaviour()) {
        }
    
        public override void Display() {
            Console.WriteLine("This is a penguin");
        }
    }
}
