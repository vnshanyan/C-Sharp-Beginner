using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Struct_IEnumerator_Class_Item_Class
{
    internal struct IEnumerableStruct: IEnumerable
    {
        private readonly ItemClass[] _items;
        private int _count = 0;

        public IEnumerableStruct(int capacity)
        {
            _items = new ItemClass[capacity];
        }

        public void Add(ItemClass element)
        {
            _items[_count++] = element;
        }

        public IEnumerator GetEnumerator()
        {
            return new IEnumeratorClass(_items, _count);
        }
    }
}
