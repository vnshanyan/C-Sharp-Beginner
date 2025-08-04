using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Struct_IEnumerator_Class_Item_Struct
{
    internal class IEnumerable_Struct_IEnumerator_Class_Item_Struct
    {
        public IEnumerable_Struct_IEnumerator_Class_Item_Struct()
        {
            IEnumerableStruct enumerableStruct = new IEnumerableStruct(5);
            enumerableStruct.Add(new ItemStruct { Value = 231 });
            enumerableStruct.Add(new ItemStruct { Value = 11111 });
            enumerableStruct.Add(new ItemStruct { Value = 23121 });
            enumerableStruct.Add(new ItemStruct { Value = 121212 });
            enumerableStruct.Add(new ItemStruct { Value = 43434343 });

            foreach (ItemStruct item in enumerableStruct)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
