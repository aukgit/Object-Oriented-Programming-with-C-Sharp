using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Written by Alim Ul Karim
 * mailto: alim@developers-organism.com
 * developers-organism.com
 * find us on fb.com/developersOrganism
 * */
namespace StrategyPattern {
    public class RubberBird : Bird {
        public RubberBird()
            : base(new NoFlyBehaviour(), new SilentBehaviour(), new SwimBehaviour()) {
            
        }

        public override void Display() {
            Console.WriteLine("This is rubber bird.");
        }
    }
}
