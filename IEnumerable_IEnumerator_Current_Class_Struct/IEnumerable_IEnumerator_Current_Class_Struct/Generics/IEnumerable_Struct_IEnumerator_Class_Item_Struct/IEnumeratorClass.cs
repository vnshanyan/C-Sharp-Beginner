using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Struct_IEnumerator_Class_Item_Struct
{
    internal class IEnumeratorClass: IEnumerator
    {
        private readonly ItemStruct[] _items;
        private int currentIndex = -1;
        private readonly int _length;

        public IEnumeratorClass(ItemStruct[] items, int length)
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
