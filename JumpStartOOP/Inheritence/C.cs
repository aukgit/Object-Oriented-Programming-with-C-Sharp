using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartOOP.Inheritence {
    class C : Student {
        public C() : base(true) {
            this.Eat();
        }
    }
}
