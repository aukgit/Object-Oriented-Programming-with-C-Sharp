using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartOOP.ClassConcept.Generics
{
    
    class Vector {
        private List<int> _list;
        public Vector() {
            _list = new List<int>(100);
        }

        public Vector(int Capacity) {
            _list = new List<int>(Capacity);
        }

        public void Add(int item) {
            _list.Add(item);
        }
        public void Delete(int position) {
            _list.RemoveAt(position);
        }
        public void PrintAll() {
            foreach (var item in _list) {
                Console.WriteLine(item);
            }
        }

        public int Get(int position) {
            return _list[position];
        }
    }
 
}
