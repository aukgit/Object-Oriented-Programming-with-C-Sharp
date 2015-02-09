using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpStartOOP {
    public interface ISavable {
        int X {
            get;
            set;
        }
    
        void Save();

        void Count();
    }
}
