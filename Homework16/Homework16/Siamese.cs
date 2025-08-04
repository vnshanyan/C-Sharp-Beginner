namespace Homework16
{
    public class Siamese: Cat
    {
        public override void Move()
        {
            Console.WriteLine($"{Name} walks gracefully like a dancer.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} purrs softly.");
        }

        public new void Info()
        {
            Console.WriteLine($"{Name} is an elegant Siamese cat.");
        }
    }
}