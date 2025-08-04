using System.Collections;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Struct_IEnumerator_Struct_Item_Class
{
    public struct IEnumerableStruct: IEnumerable
    {
        private int _count = 0;
        private readonly ItemClass[] _items;

        public IEnumerableStruct(int capacity)
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

