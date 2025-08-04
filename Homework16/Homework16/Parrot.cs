namespace Homework16
{
    public class Parrot: Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} mimics: Hello!");
        }
        public new void Info()
        {
            Console.WriteLine($"{Name} is a talking Parrot.");
        }
    }
}