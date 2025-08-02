namespace Homework15
{
    public class Item: ICloneable
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public RarityLevel Rarity { get; set; }

        public object Clone()
        {
            return new Item
            {
                Name = Name,
                Weight = Weight,
                Rarity = Rarity
            };
        }
    }
}