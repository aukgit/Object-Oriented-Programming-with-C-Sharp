using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern {
    public class Ostrich : Bird {
        public Ostrich()
            : base(new NoFlyBehaviour(), new OstrichSpeakBehaviour(), new NoSwimBehaviour()) {
        }

        public override void Display() {
            Console.WriteLine("This is an Ostrich");
        }
    }
}
