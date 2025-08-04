namespace Homework16
{
    public class Cat : Animal, IPet
    {
        public bool IsIndoor { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public new void Info()
        {
            var type = IsIndoor ? "house" : "street";
            Console.WriteLine($"{Name} is a {type} cat.");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is playing happily.");
        }
    }
}