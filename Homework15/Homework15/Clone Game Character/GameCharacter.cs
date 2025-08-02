namespace Homework15
{
    public class GameCharacter: ICloneable
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public List<Item> Inventory { get; set; }

        public object Clone()
        {
            List<Item> clonedInventory = new List<Item>();

            foreach (Item item in Inventory)
            {
                clonedInventory.Add((Item) item.Clone());
            }
            
            return new GameCharacter
            {
                Name = Name,
                Level = Level,
                Inventory = clonedInventory
            };
        }
    }
}