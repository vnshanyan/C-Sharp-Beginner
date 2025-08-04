namespace Homework16
{
    public class Bird : Animal, IFlyable
    {
        public bool CanFly { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Tweet!");
        }
        public override void Move()
        {
            var action = CanFly ? "flies" : "walks";
            Console.WriteLine($"{Name} {action} around.");
        }
        public new void Info()
        {
            Console.WriteLine($"{Name} is a bird.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flaps and flies.");
        }
    }
}