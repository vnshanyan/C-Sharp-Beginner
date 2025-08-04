namespace Homework16
{
    public abstract class Animal: IComparable<Animal>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void MakeSound();
        public virtual void Move()
        {
            Console.WriteLine($"{Name} moves in a generic way.");
        }
        public void Info()
        {
            Console.WriteLine($"{Name} is an animal.");
        }

        public int CompareTo(Animal? other)
        {
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }
    }
}