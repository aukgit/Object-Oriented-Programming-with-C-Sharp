using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Written by Alim Ul Karim
 * mailto: alim@developers-organism.com
 * developers-organism.com
 * find us on fb.com/developersOrganism
 * */
namespace CheckAccessModifiers
{
    public class ClassA
    {
        public void MethodA() { 
        }

        /// <summary>
        /// by default fields are private in C#
        /// </summary>
        int defaultA;
        /// <summary>
        /// Can only be accessible from same project or assembly
        /// </summary>
        internal int internalX;
        /// <summary>
        /// Can only be accessible if derived
        /// </summary>
        protected int protectedY;
        //means protected or internal
        protected internal int protectedInternalZ;
        /// <summary>
        /// No restriction at all
        /// </summary>
        public int TestPublic;
        /// <summary>
        /// Only accessible within this class
        /// </summary>
        private int TestPrivate;
        /// <summary>
        /// Can be accessible from abstract representation of the class.
        /// Or can be accessible without creating the class.
        /// </summary>
        public static int StaticATest;
    }
}
