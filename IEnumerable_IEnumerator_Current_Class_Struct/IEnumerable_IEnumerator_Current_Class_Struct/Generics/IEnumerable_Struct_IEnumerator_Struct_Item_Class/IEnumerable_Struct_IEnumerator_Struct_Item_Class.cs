using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Struct_IEnumerator_Struct_Item_Class
{
    internal class IEnumerable_Struct_IEnumerator_Struct_Item_Class
    {
        public IEnumerable_Struct_IEnumerator_Struct_Item_Class()
        {
            IEnumerableStruct enumerableStruct = new IEnumerableStruct(5);
            enumerableStruct.Add(new ItemClass { Value = 3 });
            enumerableStruct.Add(new ItemClass { Value = 3345 });
            enumerableStruct.Add(new ItemClass { Value = 32342 });
            enumerableStruct.Add(new ItemClass { Value = 675673 });
            enumerableStruct.Add(new ItemClass { Value = 3453 });

            foreach (ItemClass item in enumerableStruct)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
        
    }
}
