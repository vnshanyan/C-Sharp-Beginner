namespace Homework15
{
    public class Employee:IComparable<Employee>
    {
        public string FullName { get; set; }
        public DateTime HireDate { get; set; }
        public string Position { get; set; }
        public PositionLevel Level { get; set; }

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1;
            int hireDate = HireDate.CompareTo(other.HireDate);
            if (hireDate != 0)
                return hireDate;
            return other.Level.CompareTo(this.Level);
        }
    }
}
