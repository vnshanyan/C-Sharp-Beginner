namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Class_IEnumerator_Struct_Item_Struct
{
    public class IEnumerable_Class_IEnumerator_Struct_Item_Struct
    {
        public IEnumerable_Class_IEnumerator_Struct_Item_Struct()
        {
            IEnumerableClass enumerableClass = new IEnumerableClass(5);
            enumerableClass.Add(new ItemStruct { Value = 231 });
            enumerableClass.Add(new ItemStruct { Value = 11111 });
            enumerableClass.Add(new ItemStruct { Value = 23121 });
            enumerableClass.Add(new ItemStruct { Value = 121212 });
            enumerableClass.Add(new ItemStruct { Value = 43434343 });

            foreach (ItemStruct item in enumerableClass)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
