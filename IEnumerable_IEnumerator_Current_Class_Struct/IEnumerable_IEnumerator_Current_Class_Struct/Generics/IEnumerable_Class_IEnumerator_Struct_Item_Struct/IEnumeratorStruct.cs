using System.Collections;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Class_IEnumerator_Struct_Item_Struct
{
    public struct IEnumeratorStruct : IEnumerator
    {
        private int currentIndex = -1;
        private readonly ItemStruct[] _items;
        private readonly int _length;
        public IEnumeratorStruct(ItemStruct[] items, int length)
        {
            _items = items;
            _length = length;
        }
        public object Current
        {
            get
            {
                if (currentIndex < 0 || currentIndex >= _length)
                    throw new InvalidOperationException();
                return _items[currentIndex];
            }
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < _length;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
