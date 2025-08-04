
namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Class_IEnumerator_Class_Item_Struct
{
    public class IEnumerable_Class_IEnumerator_Class_Item_Struct
    {
        public IEnumerable_Class_IEnumerator_Class_Item_Struct()
        {
            IEnumerableClass enumerableClass = new IEnumerableClass(5);
            enumerableClass.Add(new ItemStruct { Value = 2564 });
            enumerableClass.Add(new ItemStruct { Value = 23456 });
            enumerableClass.Add(new ItemStruct { Value = 456223 });
            enumerableClass.Add(new ItemStruct { Value = 76243 });
            enumerableClass.Add(new ItemStruct { Value = 672452 });

            foreach (ItemStruct item in enumerableClass)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
