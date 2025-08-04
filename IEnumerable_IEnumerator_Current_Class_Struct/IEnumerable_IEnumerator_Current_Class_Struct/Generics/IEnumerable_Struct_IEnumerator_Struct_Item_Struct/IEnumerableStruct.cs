using System.Collections;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Struct_IEnumerator_Struct_Item_Struct
{
    public struct IEnumerableStruct : IEnumerable
    {
        private int _count;
        private readonly ItemStruct[] _items;

        public IEnumerableStruct(int capacity)
        {
            _items = new ItemStruct[capacity];
        }

        public void Add(ItemStruct element)
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
