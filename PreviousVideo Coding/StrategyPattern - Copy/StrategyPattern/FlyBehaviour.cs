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
    public class FlyBehaviour : IFly {
        #region IFly Members

        public void Fly() {
            Console.WriteLine("I am flying");
        }

        #endregion
    }

    public class NoFlyBehaviour : IFly {
        #region IFly Members

        public void Fly() {
            Console.WriteLine("I can't fly.");
        }

        #endregion
    }
}
