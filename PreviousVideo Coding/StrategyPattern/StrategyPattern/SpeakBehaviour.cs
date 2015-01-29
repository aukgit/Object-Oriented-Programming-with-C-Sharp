using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern {
    public class SpeakBehaviour : ISpeak {
        #region ISpeak Members

        public void Speak() {
            Console.WriteLine("Bird Noise.");
        }

        #endregion
    }

    public class ParrotSpeakBehaviour : ISpeak {
        #region ISpeak Members

        public void Speak() {
            Console.WriteLine("Parrot Noise.");
        }

        #endregion
    }

    public class SilentBehaviour : ISpeak {
        #region ISpeak Members

        public void Speak() {
            Console.WriteLine("Silence.");

        }

        #endregion
    }
}
