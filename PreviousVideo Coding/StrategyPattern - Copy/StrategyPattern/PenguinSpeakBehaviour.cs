using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern {
    class PenguinSpeakBehaviour : ISpeak {
        #region ISpeak Members

        public void Speak() {
            Console.WriteLine("Penguin noise.");
        }

        #endregion
    }
}
