
namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Class_IEnumerator_Class_Item_Class
{
    public class IEnumerable_Class_IEnumerator_Class_Item_Class
    {
        public IEnumerable_Class_IEnumerator_Class_Item_Class()
        {
            IEnumerableClass enumerableClass = new IEnumerableClass(5);
            enumerableClass.Add(new ItemClass { Value = 2 });
            enumerableClass.Add(new ItemClass { Value = 23 });
            enumerableClass.Add(new ItemClass { Value = 223 });
            enumerableClass.Add(new ItemClass { Value = 243 });
            enumerableClass.Add(new ItemClass { Value = 2452 });

            foreach (ItemClass item in enumerableClass)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}

