using System.IO;

namespace Homework16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            zoo.Add(new Dog { Name = "Rex", Age = 5, Breed = "Labrador" });
            zoo.Add(new Bulldog { Name = "Max", Age = 7, Breed = "Bulldog" });
            zoo.Add(new Cat { Name = "Mittens", Age = 3, IsIndoor = false });
            zoo.Add(new Siamese { Name = "Princess", Age = 2, IsIndoor = true });
            zoo.Add(new Bird { Name = "Sky", Age = 1, CanFly = true });
            zoo.Add(new Parrot { Name = "Polly", Age = 4, CanFly = true });
            zoo.MakeAllSounds();
            zoo.MoveAllAnimals();
            zoo.ShowAnimalInfos();
            zoo.PlayWithPets();
            zoo.LetBirdsFly();

            Console.WriteLine("-- Casting Info() Back to Original Types --");
            foreach (var animal in zoo)
            {
                switch (animal)
                {
                    case Dog d when !(d is Bulldog):
                        d.Info();
                        break;
                    case Bulldog b:
                        b.Info();
                        break;
                    case Siamese s:
                        s.Info();
                        break;
                    case Cat c:
                        c.Info();
                        break;
                    case Parrot p:
                        p.Info();
                        break;
                    case Bird b2:
                        b2.Info();
                        break;
                }
            }
        }
    }
}
/*
Design and implement an object-oriented zoo system using C# that models different animals and their behaviors.
The system must use inheritance, interfaces, polymorphism, casting, and method behavior differences (`virtual`, `override`, `new`).
The Zoo class must implement `IList<Animal>` directly.
---------------
1. Base Abstract Class: Animal
------------------------------
- Properties:
  - string Name
  - int Age
- Methods:
  - abstract void MakeSound()
  - virtual void Move() → default: "{Name} moves in a generic way."
  - void Info() → "{Name} is a general animal."
2. Derived Classes
------------------
2.1 Dog : Animal
----------------
- Property: string Breed
- Override MakeSound(): "Woof!"
- new void Info(): "{Name} is a Dog of breed {Breed}"
2.1.1 Bulldog : Dog
-------------------
- Override Move(): "{Name} walks slowly with heavy steps."
- Override MakeSound(): "{Name} grumbles and says: Woof!"
- new void Info(): "{Name} is a tough Bulldog."
2.2 Cat : Animal
----------------
- Property: bool IsIndoor
- Override MakeSound(): "Meow!"
- new void Info(): "{Name} is a {(IsIndoor ? "house" : "street")} cat."
2.2.1 Siamese : Cat
-------------------
- Override Move(): "{Name} walks gracefully like a dancer."
- Override MakeSound(): "{Name} purrs softly."
- new void Info(): "{Name} is an elegant Siamese cat."
2.3 Bird : Animal
-----------------
- Property: bool CanFly
- Override MakeSound(): "Tweet!"
- Override Move(): "{Name} {(CanFly ? "flies" : "walks")} around."
- new void Info(): "{Name} is a bird."
2.3.1 Parrot : Bird
-------------------
- Override MakeSound(): "{Name} mimics: Hello!"
- new void Info(): "{Name} is a talking Parrot."
3. Interfaces
-------------
3.1 IPet
--------
- Method: void Play()
3.2 IFlyable
------------
- Method: void Fly()
Implemented By:
- Dog, Cat → IPet (prints "{Name} is playing happily.")
- Bird → IFlyable (if CanFly == true) → "{Name} flaps and flies."
4. Zoo Class
------------
- Implements IList<Animal>
- Internally uses a List<Animal>
- Must implement all IList<Animal> members
- Extra Methods:
  - void MakeAllSounds()
  - void MoveAllAnimals()
  - void ShowAnimalInfos()
  - void PlayWithPets() → use casting to IPet
  - void LetBirdsFly() → use casting to IFlyable
5. Main Method Tasks
---------------------
- Create Zoo instance
- Add:
  - Dog + Bulldog
  - Cat + Siamese
  - Bird + Parrot
- Store all as Animal references (polymorphism)
- Call:
  - MakeAllSounds()
  - MoveAllAnimals()
  - ShowAnimalInfos()
  - PlayWithPets()
  - LetBirdsFly()
- Foreach over Zoo:
  - Downcast to specific type
  - Call Info()
  - Print unique properties (e.g., Breed, IsIndoor)
6. Demonstration of Polymorphism
--------------------------------
- Store `Dog`, `Bulldog`, `Cat`, `Siamese`, `Bird`, `Parrot` as `Animal`
- Use overridden methods like `MakeSound()` and `Move()` in a loop
- Output shows different behaviors for the same method call
7. Sample Output
----------------
-- Making All Sounds --
Rex says: Woof!
Max grumbles and says: Woof!
Mittens says: Meow!
Princess purrs softly.
Sky says: Tweet!
Polly mimics: Hello!
-- Moving All Animals --
Rex moves in a generic way.
Max walks slowly with heavy steps.
Mittens moves in a generic way.
Princess walks gracefully like a dancer.
Sky flies around.
Polly flies around.
-- Showing Info --
Rex is an animal.
Max is an animal.
Mittens is an animal.
Princess is an animal.
Sky is an animal.
Polly is an animal.
-- Casting Info() Back to Original Types --
Rex is a Dog of breed Labrador
Max is a tough Bulldog.
Mittens is a street cat.
Princess is an elegant Siamese cat.
Sky is a bird.
Polly is a talking Parrot.
-- Playing With Pets --
Rex is playing happily.
Max is playing happily.
Mittens is playing happily.
Princess is playing happily.
-- Letting Birds Fly --
Sky flaps and flies.
Polly flaps and flies.
8. Grading Criteria
-------------------
- Inheritance: 10
- Interface implementation: 10
- Virtual/Override/New: 10
- Casting and polymorphism: 10
- Zoo implements IList<Animal>: 15
- Functionality in Main: 10
- Code readability and structure: 5
- Bonus: +5
9. Bonus (Optional)
-------------------
- Add SortByAge() method (custom comparer)
- Implement IComparable<Animal> by Name
- Add Save/Load JSON functionality using System.Text.Json
 */