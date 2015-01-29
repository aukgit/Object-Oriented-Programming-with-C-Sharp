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
    public class SwimBehaviour : ISwim {
        #region ISwim Members

        public void Swim() {
            Console.WriteLine("I am swimming.");
        }

        #endregion
    }

    public class NoSwimBehaviour : ISwim {
        #region ISwim Members

        public void Swim() {
            Console.WriteLine("I can't swim.");

        }

        #endregion
    }
}
