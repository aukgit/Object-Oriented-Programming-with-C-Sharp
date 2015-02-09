using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpStartOOP {
    public class XExample : ISavable, IErrorCollection {
        public int X {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public void Save() {
            throw new NotImplementedException();
        }

        public void Count() {
            throw new NotImplementedException();
        }

        public void LogError() {
            throw new NotImplementedException();
        }

        public void DisplayError() {
            throw new NotImplementedException();
        }
    }
}
