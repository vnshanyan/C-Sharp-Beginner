using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Class_IEnumerator_Struct_Item_Class
{
    internal class IEnumerableClass: IEnumerable
    {
        private int _count = 0;
        public readonly ItemClass[] _items;

        public IEnumerableClass(int capacity)
        {
            _items = new ItemClass[capacity];
        }

        public void Add(ItemClass element)
        {
            if (_count >= _items.Length)
                throw new InvalidOperationException("Array_List is full.");
            _items[_count++] = element;
        }

        public IEnumerator GetEnumerator()
        {
            return new IEnumeratorStruct(_items, _count);
        }
    }
}
