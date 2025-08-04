namespace Homework16
{
    public class Bulldog: Dog
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} grumbles and says: Woof!");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} walks slowly with heavy steps.");
        }
        public new void Info()
        {
            Console.WriteLine($"{Name} is a tough Bulldog.");
        }
    }
}