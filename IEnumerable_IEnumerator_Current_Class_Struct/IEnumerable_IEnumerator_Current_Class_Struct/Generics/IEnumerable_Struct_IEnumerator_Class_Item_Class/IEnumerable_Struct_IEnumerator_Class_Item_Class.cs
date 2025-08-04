using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Struct_IEnumerator_Class_Item_Class
{
    internal class IEnumerable_Struct_IEnumerator_Class_Item_Class
    {
        public IEnumerable_Struct_IEnumerator_Class_Item_Class()
        {
            IEnumerableStruct enumerableStruct = new IEnumerableStruct(5);
            enumerableStruct.Add(new ItemClass { Value = 231 });
            enumerableStruct.Add(new ItemClass { Value = 11111 });
            enumerableStruct.Add(new ItemClass { Value = 23121 });
            enumerableStruct.Add(new ItemClass { Value = 121212 });
            enumerableStruct.Add(new ItemClass { Value = 43434343 });

            foreach (ItemClass item in enumerableStruct)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
