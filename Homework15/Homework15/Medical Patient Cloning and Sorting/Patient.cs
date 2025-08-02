namespace Homework15
{
    public class Patient: ICloneable, IComparable<Patient>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public MedicalRecord Record {get; set;}

        public object Clone()
        {
            return new Patient
            {
                Name = Name,
                BirthDate = BirthDate,
                Record = (MedicalRecord) Record.Clone()
            };
        }

        public int CompareTo(Patient? other)
        {
            return BirthDate.CompareTo(other.BirthDate);
        }
    }
}