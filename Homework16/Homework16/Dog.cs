namespace Homework16
{
    public class Dog : Animal, IPet
    {
        public string Breed { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
        public new void Info()
        {
            Console.WriteLine($"{Name} is a Dog of breed {Breed}");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is playing happily.");
        }
    }
}