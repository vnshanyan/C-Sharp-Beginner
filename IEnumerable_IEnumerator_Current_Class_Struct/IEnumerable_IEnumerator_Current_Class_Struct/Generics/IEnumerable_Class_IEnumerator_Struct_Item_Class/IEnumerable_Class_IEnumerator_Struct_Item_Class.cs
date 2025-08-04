using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Class_IEnumerator_Struct_Item_Class
{
    internal class IEnumerable_Class_IEnumerator_Struct_Item_Class
    {
        public IEnumerable_Class_IEnumerator_Struct_Item_Class()
        {
            IEnumerableClass enumerableClass = new IEnumerableClass(5);
            enumerableClass.Add(new ItemClass { Value = 2564 });
            enumerableClass.Add(new ItemClass { Value = 23456 });
            enumerableClass.Add(new ItemClass { Value = 456223 });
            enumerableClass.Add(new ItemClass { Value = 76243 });
            enumerableClass.Add(new ItemClass { Value = 672452 });

            foreach (ItemClass item in enumerableClass)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
