using System.Collections;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Class_IEnumerator_Struct_Item_Struct
{
    public class IEnumerableClass : IEnumerable
    {
        private readonly ItemStruct[] _items;
        private int _count = 0;
        public IEnumerableClass(int capacity)
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
