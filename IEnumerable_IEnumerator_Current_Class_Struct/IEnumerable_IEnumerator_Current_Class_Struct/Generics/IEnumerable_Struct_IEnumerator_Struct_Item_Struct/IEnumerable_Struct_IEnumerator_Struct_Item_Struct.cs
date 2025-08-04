namespace IEnumerable_IEnumerator_Item_Class_Struct.Generics.IEnumerable_Struct_IEnumerator_Struct_Item_Struct
{
    public class IEnumerable_Struct_IEnumerator_Struct_Item_Struct
    {
        public IEnumerable_Struct_IEnumerator_Struct_Item_Struct()
        {
            IEnumerableStruct enumerableStruct = new IEnumerableStruct(5);
            enumerableStruct.Add(new ItemStruct { Value = 3 });
            enumerableStruct.Add(new ItemStruct { Value = 3345 });
            enumerableStruct.Add(new ItemStruct { Value = 32342 });
            enumerableStruct.Add(new ItemStruct { Value = 675673 });
            enumerableStruct.Add(new ItemStruct { Value = 3453 });

            foreach (ItemStruct item in enumerableStruct)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
