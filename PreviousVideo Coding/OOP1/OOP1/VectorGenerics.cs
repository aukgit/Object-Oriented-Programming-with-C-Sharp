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
namespace OOP1 {
    class VectorGenerics<T,More> {
        private List<T> _list;
        public VectorGenerics() {
            _list = new List<T>(100);
        }

        public VectorGenerics(int Capacity) {
            _list = new List<T>(Capacity);
        }

        public void Add(T item) {
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

        public T Get(int position) {
            return _list[position];
        }
    }
}
