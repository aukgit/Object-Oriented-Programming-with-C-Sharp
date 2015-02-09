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
namespace OOP1.Interfaces {
    class DestructorClassIDispose : IDisposable {
        public List<string> List;
        public DestructorClassIDispose() {
            Console.WriteLine("Class is created.");
            List = new List<string>(2000);
            Console.WriteLine("List capacity : " + List.Capacity);

        }

        ~DestructorClassIDispose() {
            List = null;

            Console.WriteLine("Destructor is called from DestructorClassIDispose");
        }





        #region IDisposable Members

        public void Dispose() {
            List = null;

            Console.WriteLine("Dispose is called");
        }

        #endregion
    }
}
