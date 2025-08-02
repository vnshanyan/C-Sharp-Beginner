namespace Homework15
{
    public class CloneGameCharacter
    {
        public CloneGameCharacter()
        {
            GameCharacter hero = new GameCharacter
            {
                Name = "Arin",
                Level = 10,
                Inventory = new List<Item>
                {
                    new Item { Name = "Sword", Weight = 3.5f, Rarity = RarityLevel.Rare },
                    new Item { Name = "Potion", Weight = 0.5f, Rarity = RarityLevel.Common }
                }
            };

            GameCharacter clone = (GameCharacter)hero.Clone();
            clone.Name = "Luna";
            clone.Inventory[0].Name = "Axe";

            Console.WriteLine("Original Character:");
            Console.WriteLine(hero.Name);
            Console.WriteLine(hero.Inventory[0].Name);

            Console.WriteLine("\nCloned Character:");
            Console.WriteLine(clone.Name);
            Console.WriteLine(clone.Inventory[0].Name);
        }
    }
}
/*
8. CloneGameCharacter
------------------------------------------------
Topic: ICloneable
Create a `GameCharacter` class:
- string Name
- int Level
- List<Item> Inventory
Model an `Item` class:
- string Name
- float Weight
- string Rarity
Tasks:
- Implement deep cloning of GameCharacter and Inventory.
- Bonus: Include Rarity levels using enum.
*/