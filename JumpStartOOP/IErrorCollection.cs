using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpStartOOP {
    public interface IErrorCollection {
        void LogError();

        /// <summary>
        /// Display error information to user
        /// </summary>
        /// <remarks>Display error information to user (remarks)</remarks>
        void DisplayError();
    }
}
