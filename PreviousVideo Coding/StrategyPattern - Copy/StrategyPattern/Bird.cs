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
    public abstract class Bird : IFly, ISpeak, ISwim {
        public Bird(IFly flyBehaviour, ISpeak speakBehaviour, ISwim swimBehaviour) {
            FlyBehaviour = flyBehaviour;
            SpeakBehaviour = speakBehaviour;
            SwimBehaviour = swimBehaviour;
        }

        public IFly FlyBehaviour { get; set; }

        public ISwim SwimBehaviour { get; set; }

        public ISpeak SpeakBehaviour { get; set; }

        #region ISwim Members

        public void Swim() {
            try {
                SwimBehaviour.Swim();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        #endregion

        #region ISpeak Members

        public void Speak() {
            try {
                SpeakBehaviour.Speak();

            } catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        #endregion

        #region IFly Members

        public void Fly() {
            try {
                FlyBehaviour.Fly();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        #endregion

        public abstract void Display();
    }
}
