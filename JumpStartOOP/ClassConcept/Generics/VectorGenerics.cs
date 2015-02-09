using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartOOP.ClassConcept.Generics
{
    class VectorGenerics<T>
    {
        private List<T> _list;
        T x;
        
        public VectorGenerics()
        {
            _list = new List<T>(100);
        }

        public VectorGenerics(int Capacity)
        {
            _list = new List<T>(Capacity);
        }

        public void Add(T item)
        {
            _list.Add(item);
        }
        public void Delete(int position)
        {
            _list.RemoveAt(position);
        }
        public void PrintAll()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }

        public T Get(int position)
        {
            return _list[position];
        }
    }
}
