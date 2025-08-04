using System.Collections;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Class_IEnumerator_Class_Item_Class
{
    public class IEnumerableClass : IEnumerable
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
            return new IEnumeratorClass(_items, _count);
        }
    }

}
