using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern {
    class OstrichSpeakBehaviour:ISpeak {
        #region ISpeak Members

        public void Speak() {
            Console.WriteLine("Ostrich noise.");
        }

        #endregion
    }
}
